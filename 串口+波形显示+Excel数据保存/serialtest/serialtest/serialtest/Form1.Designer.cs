namespace serialtest
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldatabit = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblstopbit = new System.Windows.Forms.Label();
            this.lblbtl = new System.Windows.Forms.Label();
            this.lblckh = new System.Windows.Forms.Label();
            this.cbxdatabit = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.cbxstopbit = new System.Windows.Forms.ComboBox();
            this.cbxbtl = new System.Windows.Forms.ComboBox();
            this.cbxckh = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Senddata = new System.Windows.Forms.Button();
            this.btn_Checkcom = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtb_send = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbReceive = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldatabit);
            this.groupBox1.Controls.Add(this.lblParity);
            this.groupBox1.Controls.Add(this.lblstopbit);
            this.groupBox1.Controls.Add(this.lblbtl);
            this.groupBox1.Controls.Add(this.lblckh);
            this.groupBox1.Controls.Add(this.cbxdatabit);
            this.groupBox1.Controls.Add(this.cbxParity);
            this.groupBox1.Controls.Add(this.cbxstopbit);
            this.groupBox1.Controls.Add(this.cbxbtl);
            this.groupBox1.Controls.Add(this.cbxckh);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbldatabit
            // 
            this.lbldatabit.AutoSize = true;
            this.lbldatabit.Location = new System.Drawing.Point(131, 63);
            this.lbldatabit.Name = "lbldatabit";
            this.lbldatabit.Size = new System.Drawing.Size(41, 12);
            this.lbldatabit.TabIndex = 9;
            this.lbldatabit.Text = "数据位";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(131, 27);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(41, 12);
            this.lblParity.TabIndex = 8;
            this.lblParity.Text = "校验位";
            // 
            // lblstopbit
            // 
            this.lblstopbit.AutoSize = true;
            this.lblstopbit.Location = new System.Drawing.Point(7, 100);
            this.lblstopbit.Name = "lblstopbit";
            this.lblstopbit.Size = new System.Drawing.Size(41, 12);
            this.lblstopbit.TabIndex = 7;
            this.lblstopbit.Text = "停止位";
            // 
            // lblbtl
            // 
            this.lblbtl.AutoSize = true;
            this.lblbtl.Location = new System.Drawing.Point(6, 64);
            this.lblbtl.Name = "lblbtl";
            this.lblbtl.Size = new System.Drawing.Size(41, 12);
            this.lblbtl.TabIndex = 6;
            this.lblbtl.Text = "波特率";
            // 
            // lblckh
            // 
            this.lblckh.AutoSize = true;
            this.lblckh.Location = new System.Drawing.Point(7, 20);
            this.lblckh.Name = "lblckh";
            this.lblckh.Size = new System.Drawing.Size(41, 12);
            this.lblckh.TabIndex = 5;
            this.lblckh.Text = "端口号";
            // 
            // cbxdatabit
            // 
            this.cbxdatabit.FormattingEnabled = true;
            this.cbxdatabit.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.cbxdatabit.Location = new System.Drawing.Point(178, 55);
            this.cbxdatabit.Name = "cbxdatabit";
            this.cbxdatabit.Size = new System.Drawing.Size(65, 20);
            this.cbxdatabit.TabIndex = 4;
            this.cbxdatabit.Text = "8";
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbxParity.Location = new System.Drawing.Point(178, 20);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(65, 20);
            this.cbxParity.TabIndex = 3;
            this.cbxParity.Text = "None";
            // 
            // cbxstopbit
            // 
            this.cbxstopbit.FormattingEnabled = true;
            this.cbxstopbit.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.cbxstopbit.Location = new System.Drawing.Point(54, 92);
            this.cbxstopbit.Name = "cbxstopbit";
            this.cbxstopbit.Size = new System.Drawing.Size(69, 20);
            this.cbxstopbit.TabIndex = 2;
            this.cbxstopbit.Text = "1";
            // 
            // cbxbtl
            // 
            this.cbxbtl.FormattingEnabled = true;
            this.cbxbtl.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cbxbtl.Location = new System.Drawing.Point(54, 56);
            this.cbxbtl.Name = "cbxbtl";
            this.cbxbtl.Size = new System.Drawing.Size(69, 20);
            this.cbxbtl.TabIndex = 1;
            this.cbxbtl.Text = "9600";
            // 
            // cbxckh
            // 
            this.cbxckh.FormattingEnabled = true;
            this.cbxckh.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.cbxckh.Location = new System.Drawing.Point(54, 20);
            this.cbxckh.Name = "cbxckh";
            this.cbxckh.Size = new System.Drawing.Size(69, 20);
            this.cbxckh.TabIndex = 0;
            this.cbxckh.Text = "COM1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_display);
            this.groupBox2.Controls.Add(this.btn_Exit);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btn_Open);
            this.groupBox2.Controls.Add(this.btn_Senddata);
            this.groupBox2.Controls.Add(this.btn_Checkcom);
            this.groupBox2.Location = new System.Drawing.Point(299, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能操作";
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(97, 56);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 23);
            this.btn_display.TabIndex = 6;
            this.btn_display.Text = "实时数据";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(97, 89);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "保存数据";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清空接收区";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(6, 55);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 4;
            this.btn_Open.Text = "打开串口";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Senddata
            // 
            this.btn_Senddata.Location = new System.Drawing.Point(97, 18);
            this.btn_Senddata.Name = "btn_Senddata";
            this.btn_Senddata.Size = new System.Drawing.Size(75, 23);
            this.btn_Senddata.TabIndex = 1;
            this.btn_Senddata.Text = "发送数据";
            this.btn_Senddata.UseVisualStyleBackColor = true;
            this.btn_Senddata.Click += new System.EventHandler(this.btn_Senddata_Click);
            // 
            // btn_Checkcom
            // 
            this.btn_Checkcom.Location = new System.Drawing.Point(6, 20);
            this.btn_Checkcom.Name = "btn_Checkcom";
            this.btn_Checkcom.Size = new System.Drawing.Size(75, 23);
            this.btn_Checkcom.TabIndex = 0;
            this.btn_Checkcom.Text = "端口检测";
            this.btn_Checkcom.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtb_send);
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 256);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送数据";
            // 
            // rtb_send
            // 
            this.rtb_send.BackColor = System.Drawing.SystemColors.Menu;
            this.rtb_send.Location = new System.Drawing.Point(8, 20);
            this.rtb_send.Name = "rtb_send";
            this.rtb_send.Size = new System.Drawing.Size(217, 230);
            this.rtb_send.TabIndex = 0;
            this.rtb_send.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbReceive);
            this.groupBox4.Location = new System.Drawing.Point(259, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 256);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收数据";
            // 
            // rtbReceive
            // 
            this.rtbReceive.BackColor = System.Drawing.SystemColors.Window;
            this.rtbReceive.Location = new System.Drawing.Point(6, 20);
            this.rtbReceive.Name = "rtbReceive";
            this.rtbReceive.Size = new System.Drawing.Size(216, 230);
            this.rtbReceive.TabIndex = 0;
            this.rtbReceive.Text = "0";
            this.rtbReceive.TextChanged += new System.EventHandler(this.rtbReceive_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 404);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "串口通信";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldatabit;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblstopbit;
        private System.Windows.Forms.Label lblbtl;
        private System.Windows.Forms.Label lblckh;
        private System.Windows.Forms.ComboBox cbxdatabit;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxstopbit;
        private System.Windows.Forms.ComboBox cbxbtl;
        private System.Windows.Forms.ComboBox cbxckh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Senddata;
        private System.Windows.Forms.Button btn_Checkcom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtb_send;
        private System.Windows.Forms.GroupBox groupBox4;
        public  System.Windows.Forms.RichTextBox rtbReceive;
        private System.Windows.Forms.Button btn_Open;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnClear;
        public  System.Windows.Forms.Button btn_display;
    }
}

