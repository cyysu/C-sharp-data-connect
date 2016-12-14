using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting; //需要添加的命名空间  

namespace SerialPortConnection
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 存储Excel数据
        /// </summary>
        private string time_Sheet;
        private string tempture_Sheet;
        private string power_Sheet;
        private string voltage_Sheet;
        private string current_Sheet;
        private static float countNum = 1;
        private string strRcv = null;
        /// <summary>
        /// 存储数据链表
        /// </summary>
        private List<String> DataList       = new List<String>();
        private List<int> IntListPower      = new List<int>();
        private List<int> IntListTempture   = new List<int>();
        private List<int> IntListVoltage    = new List<int>();
        private List<int> IntListCurrent    = new List<int>();
        


        bool Choose_Serial_Enable = false;
        public Form1()
        {
            InitializeComponent();
            //InitChart();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //private void InitChart()
        //{
        //    DateTime time = DateTime.Now;
        //    timer1.Tick += timer1_Tick;
        //    chart1.DoubleClick += chart1_DoubleClick;

        //    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "";
        //    chart1.ChartAreas[0].AxisX.ScaleView.Size = 5;
        //    chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
        //    chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
        //}

        //void chart1_DoubleClick(object sender, EventArgs e)
        //{
        //    chart1.ChartAreas[0].AxisX.ScaleView.Size = 5;
        //    chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
        //    chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
        //    //throw new NotImplementedException();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "115200";
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            SearchAndAddSerialToComBox(serialPort1 ,comboBox1);
        }

        private void SearchAndAddSerialToComBox(SerialPort MyPort,ComboBox MyBox)
        {
            string buffer;
            bool serialIsTure = false;
            MyBox.Items.Clear();
           
            for(int i = 1; i < 20 ;i ++)
            {
                try
                {
                    buffer = "COM" + i.ToString();
                    MyPort.PortName = buffer;
                    MyPort.Open();
                    MyBox.Items.Add(buffer);
                    MyBox.Text = buffer;
                    MyPort.Close();
                    serialIsTure = true;
                }
                catch
                {
                   
                }
            }
            if (serialIsTure)
            {

            }
            else
            {
                MessageBox.Show("未找到串口", "提示");
            }
           
        }

        private void port_DataReceived(object sender,SerialDataReceivedEventArgs e)
        {
            /// 字符串发送 
            if (!radioButton2.Checked)
            {
                try
                {
                    DataList.Add(serialPort1.ReadLine());
                    //输出当前时间
                    DateTime dt = DateTime.Now;
                    textBox1.Text += dt.GetDateTimeFormats('f')[0].ToString() + "\r\n";
                    textBox1.Text += serialPort1.ReadLine() + "\r\n";
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message, "数据处理出错提示");
                    return;
                }
                
            }
            else
            {
                //输出当前系统时间
                DateTime dt = DateTime.Now;
                textBox1.Text += dt.GetDateTimeFormats('f')[0].ToString() + "\r\n";

                try
                {
                    Byte[] receivedData = new Byte[serialPort1.BytesToRead];        //创建接收字节数组
                    serialPort1.Read(receivedData, 0, receivedData.Length);         //读取数据

                    for (int i = 0; i < receivedData.Length; i++)
                    {
                        if (receivedData[i] == 0xFE || receivedData[i] == 0xfe)
                        {
                            textBox1.AppendText("\r\n");
                        }
                        else
                        {
                            textBox1.AppendText(receivedData[i].ToString("X2") + " ");
                            strRcv += receivedData[i].ToString("X2") + " ";
                        }
                    }

                    int count = strRcv.Length / 48;                           // 记录数据的个数
                    for (int j = 0; j < count; j++)
                    {
                        /// 获取每条记录
                        string buf1 = strRcv.Substring(j * 48, 48);
                        /// 添加字符串数据到数据库
                        DataList.Add(buf1);
                    }

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "出错提示");
                    textBox1.Text = "";
                }

                                             
            }
        }
        /// <summary>
        /// 实时图像显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Choose_Serial_Enable = !Choose_Serial_Enable;
            if (Choose_Serial_Enable)
            {
                timer1.Start();
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text, 10);
                    serialPort1.Open();
                    button3.Text = "关闭串口";
                }
                catch
                {
                    MessageBox.Show("端口错误，请检查","ERROR");
                    Choose_Serial_Enable = !Choose_Serial_Enable;
                }
            }
            else
            {
                timer1.Stop();
                serialPort1.Close();
                button3.Text = "打开串口";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchAndAddSerialToComBox(serialPort1, comboBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }


        private string ShowSaveFileDialog()
        {
            string localFilePath = "";// fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.Filter = "Excel文件(*.xlsx)|*.xlsx";
            //file.Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx";
            //设置默认文件类型显示顺序 
            //sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                //string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                //获取文件路径，不带文件名 
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));
            }
            return localFilePath;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ///*******************数据导入Excel**********************/
            string fileName = ShowSaveFileDialog();         //文件的保存路径和文件名
            try
            {
                // 创建Excel文档
                Microsoft.Office.Interop.Excel.Application ExcelApp
                    = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelDoc = ExcelApp.Workbooks.Add(Type.Missing);
                // 
                Microsoft.Office.Interop.Excel.Worksheet xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelDoc.Worksheets.Add(Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing);
                ExcelApp.DisplayAlerts = false;

                // 单元格下标是从[1，1]开始的
                xlSheet.Cells[1, 1] = "日期时间";
                xlSheet.Cells[1, 2] = "温度";
                xlSheet.Cells[1, 3] = "功率";
                xlSheet.Cells[1, 4] = "电压";
                xlSheet.Cells[1, 5] = "电源";


                foreach (String ss in DataList)
                {

                    countNum++;
                    /// 从接受数据库获取数据源
                    string[] s = ss.Split(new char[2] { 'F', 'F' });
                    /// 时间通道处理 -> 添加时间显示
                    string[] sss = s[0].Split(new char[1] { ' ' });
                    string hour     = "0x" + sss[0];
                    string minute   = "0x" + sss[1];
                    string second   = "0x" + sss[2];
                    time_Sheet = Convert.ToInt32(hour, 16) + "时" + Convert.ToInt32(minute, 16) + "分" + Convert.ToInt32(second, 16) + "秒";
                    /// 温度通道显示 -> 添加温度显示    并将数据保存到类型为Int的ListTempture里面
                    string buf2 = "0x" + s[2].Replace(" ", "");
                    IntListTempture.Add(Convert.ToInt32(buf2, 16));
                    tempture_Sheet = Convert.ToInt32(buf2, 16) + "°C";
                    /// 功率通道显示 -> 添加功率显示    并将数据保存到类型为Int的ListPower里面
                    string buf3 = "0x" + s[4].Replace(" ", "");
                    IntListPower.Add(Convert.ToInt32(buf3, 16));
                    power_Sheet = Convert.ToInt32(buf3, 16) + "W";
                    /// 电压通道显示 -> 添加电压显示    并将数据保存到类型为Int的IntListVoltage里面
                    string buf4 = "0x" + s[6].Replace(" ", "");
                    IntListVoltage.Add(Convert.ToInt32(buf4, 16));
                    voltage_Sheet = Convert.ToInt32(buf3, 16) + "V";
                    /// 电流通道显示 -> 电流功率显示    并将数据保存到类型为Int的IntListCurrent里面
                    string buf5 = "0x" + s[8].Replace(" ", "");
                    IntListCurrent.Add(Convert.ToInt32(buf5, 16));
                    current_Sheet = Convert.ToInt32(buf3, 16) + "A";
                    ///写入Excel表格
                    xlSheet.Cells[countNum, 1] = time_Sheet;
                    xlSheet.Cells[countNum, 2] = tempture_Sheet;
                    xlSheet.Cells[countNum, 3] = power_Sheet;
                    xlSheet.Cells[countNum, 4] = voltage_Sheet;
                    xlSheet.Cells[countNum, 5] = current_Sheet;
                }

                // 文件保存完毕输出信息
                xlSheet.SaveAs(fileName);
                ExcelDoc.Close(Type.Missing, fileName, Type.Missing);
                ExcelApp.Quit();
                MessageBox.Show("数据已保存！！");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "数据处理出错提示");
                return;
            } 
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 实时显示图像处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Series series = chart1.Series[0];
            //foreach (String ss in DataList)
            //{
            //    /// 从接受数据库获取数据源
            //    string[] s = ss.Split(new char[2] { 'F', 'F' });
            //    /// 时间通道处理 -> 添加时间显示
            //    string[] sss = s[0].Split(new char[1] { ' ' });
            //    string hour   = "0x" + sss[0];
            //    string minute = "0x" + sss[1];
            //    string second = "0x" + sss[2];
            //    time_Sheet = Convert.ToInt32(hour, 16) + "时" + Convert.ToInt32(minute, 16) + "分" + Convert.ToInt32(second, 16) + "秒";
            //    /// 温度通道显示 -> 添加温度显示    并将数据保存到类型为Int的ListTempture里面
            //    string buf2 = "0x" + s[2].Replace(" ", "");
            //    IntListTempture.Add(Convert.ToInt32(buf2, 16));

            //    /// 功率通道显示 -> 添加功率显示    并将数据保存到类型为Int的ListPower里面
            //    string buf3 = "0x" + s[4].Replace(" ", "");
            //    IntListPower.Add(Convert.ToInt32(buf3, 16));
            //}

            // 添加功率曲线数据
            //foreach (int Intvalue in IntListPower)
            //{
            //    this.chart1.Series[0].Points.AddXY(time_Sheet, Intvalue);
            //}

            // 添加温度曲线数据
            //foreach (int Intvalue in IntListTempture)
            //{
            //    this.chart1.Series[1].Points.Add(Intvalue);
            //}

            //波形显示在最后 - 5的位置
            //chart1.ChartAreas[0].AxisX.ScaleView.Position = series.Points.Count - 5;


            
        }

    }
}
