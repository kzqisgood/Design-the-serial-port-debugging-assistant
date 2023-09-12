namespace 串口调试助手设计
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.port_cbb = new System.Windows.Forms.ComboBox();
            this.baud_cbb = new System.Windows.Forms.ComboBox();
            this.check_cbb = new System.Windows.Forms.ComboBox();
            this.databit_cbb = new System.Windows.Forms.ComboBox();
            this.stopbit_cbb = new System.Windows.Forms.ComboBox();
            this.RTS_chb = new System.Windows.Forms.CheckBox();
            this.DTR_chb = new System.Windows.Forms.CheckBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.autoclear_chb = new System.Windows.Forms.CheckBox();
            this.hex_chb = new System.Windows.Forms.CheckBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.xzlj_btn = new System.Windows.Forms.Button();
            this.bcsj_btn = new System.Windows.Forms.Button();
            this.recivefile_txb = new System.Windows.Forms.TextBox();
            this.receivehex_chb = new System.Windows.Forms.CheckBox();
            this.sendhex_chb = new System.Windows.Forms.CheckBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.sendclear_btn = new System.Windows.Forms.Button();
            this.dkwj_btn = new System.Windows.Forms.Button();
            this.fswj_btn = new System.Windows.Forms.Button();
            this.sendfile_txb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.autotimer_txb = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.state_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendcount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.recivecount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.cleancount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.recive_rtb = new System.Windows.Forms.RichTextBox();
            this.send_rtb = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.DTR_chb);
            this.groupBox1.Controls.Add(this.RTS_chb);
            this.groupBox1.Controls.Add(this.stopbit_cbb);
            this.groupBox1.Controls.Add(this.databit_cbb);
            this.groupBox1.Controls.Add(this.check_cbb);
            this.groupBox1.Controls.Add(this.baud_cbb);
            this.groupBox1.Controls.Add(this.port_cbb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recivefile_txb);
            this.groupBox2.Controls.Add(this.bcsj_btn);
            this.groupBox2.Controls.Add(this.xzlj_btn);
            this.groupBox2.Controls.Add(this.stop_btn);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Controls.Add(this.hex_chb);
            this.groupBox2.Controls.Add(this.autoclear_chb);
            this.groupBox2.Location = new System.Drawing.Point(0, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.autotimer_txb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.sendfile_txb);
            this.groupBox3.Controls.Add(this.sendclear_btn);
            this.groupBox3.Controls.Add(this.fswj_btn);
            this.groupBox3.Controls.Add(this.receivehex_chb);
            this.groupBox3.Controls.Add(this.dkwj_btn);
            this.groupBox3.Controls.Add(this.sendhex_chb);
            this.groupBox3.Controls.Add(this.send_btn);
            this.groupBox3.Location = new System.Drawing.Point(0, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 202);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.recive_rtb);
            this.groupBox4.Location = new System.Drawing.Point(248, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(555, 420);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.send_rtb);
            this.groupBox5.Location = new System.Drawing.Point(248, 428);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(555, 202);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "端口号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "停止位";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // port_cbb
            // 
            this.port_cbb.FormattingEnabled = true;
            this.port_cbb.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3"});
            this.port_cbb.Location = new System.Drawing.Point(104, 18);
            this.port_cbb.Name = "port_cbb";
            this.port_cbb.Size = new System.Drawing.Size(121, 23);
            this.port_cbb.TabIndex = 9;
            this.port_cbb.SelectedIndexChanged += new System.EventHandler(this.port_cbb_SelectedIndexChanged);
            // 
            // baud_cbb
            // 
            this.baud_cbb.FormattingEnabled = true;
            this.baud_cbb.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.baud_cbb.Location = new System.Drawing.Point(104, 46);
            this.baud_cbb.Name = "baud_cbb";
            this.baud_cbb.Size = new System.Drawing.Size(121, 23);
            this.baud_cbb.TabIndex = 10;
            // 
            // check_cbb
            // 
            this.check_cbb.FormattingEnabled = true;
            this.check_cbb.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.check_cbb.Location = new System.Drawing.Point(104, 74);
            this.check_cbb.Name = "check_cbb";
            this.check_cbb.Size = new System.Drawing.Size(121, 23);
            this.check_cbb.TabIndex = 11;
            // 
            // databit_cbb
            // 
            this.databit_cbb.FormattingEnabled = true;
            this.databit_cbb.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databit_cbb.Location = new System.Drawing.Point(104, 102);
            this.databit_cbb.Name = "databit_cbb";
            this.databit_cbb.Size = new System.Drawing.Size(121, 23);
            this.databit_cbb.TabIndex = 12;
            // 
            // stopbit_cbb
            // 
            this.stopbit_cbb.FormattingEnabled = true;
            this.stopbit_cbb.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbit_cbb.Location = new System.Drawing.Point(104, 130);
            this.stopbit_cbb.Name = "stopbit_cbb";
            this.stopbit_cbb.Size = new System.Drawing.Size(121, 23);
            this.stopbit_cbb.TabIndex = 13;
            // 
            // RTS_chb
            // 
            this.RTS_chb.AutoSize = true;
            this.RTS_chb.Location = new System.Drawing.Point(9, 172);
            this.RTS_chb.Name = "RTS_chb";
            this.RTS_chb.Size = new System.Drawing.Size(53, 19);
            this.RTS_chb.TabIndex = 14;
            this.RTS_chb.Text = "RTS";
            this.RTS_chb.UseVisualStyleBackColor = true;
            // 
            // DTR_chb
            // 
            this.DTR_chb.AutoSize = true;
            this.DTR_chb.Location = new System.Drawing.Point(9, 206);
            this.DTR_chb.Name = "DTR_chb";
            this.DTR_chb.Size = new System.Drawing.Size(53, 19);
            this.DTR_chb.TabIndex = 15;
            this.DTR_chb.Text = "DTR";
            this.DTR_chb.UseVisualStyleBackColor = true;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(129, 172);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(96, 53);
            this.open_btn.TabIndex = 16;
            this.open_btn.Text = "打开串口";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // autoclear_chb
            // 
            this.autoclear_chb.AutoSize = true;
            this.autoclear_chb.Location = new System.Drawing.Point(9, 34);
            this.autoclear_chb.Name = "autoclear_chb";
            this.autoclear_chb.Size = new System.Drawing.Size(89, 19);
            this.autoclear_chb.TabIndex = 15;
            this.autoclear_chb.Text = "自动清空";
            this.autoclear_chb.UseVisualStyleBackColor = true;
            this.autoclear_chb.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // hex_chb
            // 
            this.hex_chb.AutoSize = true;
            this.hex_chb.Location = new System.Drawing.Point(9, 72);
            this.hex_chb.Name = "hex_chb";
            this.hex_chb.Size = new System.Drawing.Size(89, 19);
            this.hex_chb.TabIndex = 16;
            this.hex_chb.Text = "十六进制";
            this.hex_chb.UseVisualStyleBackColor = true;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(140, 29);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(85, 27);
            this.clear_btn.TabIndex = 17;
            this.clear_btn.Text = "手动清空";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(140, 69);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(85, 27);
            this.stop_btn.TabIndex = 18;
            this.stop_btn.Text = "暂停";
            this.stop_btn.UseVisualStyleBackColor = true;
            // 
            // xzlj_btn
            // 
            this.xzlj_btn.Location = new System.Drawing.Point(9, 110);
            this.xzlj_btn.Name = "xzlj_btn";
            this.xzlj_btn.Size = new System.Drawing.Size(85, 27);
            this.xzlj_btn.TabIndex = 19;
            this.xzlj_btn.Text = "选择路径";
            this.xzlj_btn.UseVisualStyleBackColor = true;
            // 
            // bcsj_btn
            // 
            this.bcsj_btn.Location = new System.Drawing.Point(140, 109);
            this.bcsj_btn.Name = "bcsj_btn";
            this.bcsj_btn.Size = new System.Drawing.Size(85, 27);
            this.bcsj_btn.TabIndex = 20;
            this.bcsj_btn.Text = "保留数据";
            this.bcsj_btn.UseVisualStyleBackColor = true;
            // 
            // recivefile_txb
            // 
            this.recivefile_txb.Location = new System.Drawing.Point(9, 142);
            this.recivefile_txb.Name = "recivefile_txb";
            this.recivefile_txb.Size = new System.Drawing.Size(216, 25);
            this.recivefile_txb.TabIndex = 4;
            this.recivefile_txb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // receivehex_chb
            // 
            this.receivehex_chb.AutoSize = true;
            this.receivehex_chb.Location = new System.Drawing.Point(9, 34);
            this.receivehex_chb.Name = "receivehex_chb";
            this.receivehex_chb.Size = new System.Drawing.Size(89, 19);
            this.receivehex_chb.TabIndex = 15;
            this.receivehex_chb.Text = "自动清空";
            this.receivehex_chb.UseVisualStyleBackColor = true;
            this.receivehex_chb.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // sendhex_chb
            // 
            this.sendhex_chb.AutoSize = true;
            this.sendhex_chb.Location = new System.Drawing.Point(9, 72);
            this.sendhex_chb.Name = "sendhex_chb";
            this.sendhex_chb.Size = new System.Drawing.Size(89, 19);
            this.sendhex_chb.TabIndex = 16;
            this.sendhex_chb.Text = "十六进制";
            this.sendhex_chb.UseVisualStyleBackColor = true;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(140, 29);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(85, 27);
            this.send_btn.TabIndex = 17;
            this.send_btn.Text = "手动发送";
            this.send_btn.UseVisualStyleBackColor = true;
            // 
            // sendclear_btn
            // 
            this.sendclear_btn.Location = new System.Drawing.Point(140, 69);
            this.sendclear_btn.Name = "sendclear_btn";
            this.sendclear_btn.Size = new System.Drawing.Size(85, 27);
            this.sendclear_btn.TabIndex = 18;
            this.sendclear_btn.Text = "清空发送";
            this.sendclear_btn.UseVisualStyleBackColor = true;
            // 
            // dkwj_btn
            // 
            this.dkwj_btn.Location = new System.Drawing.Point(9, 110);
            this.dkwj_btn.Name = "dkwj_btn";
            this.dkwj_btn.Size = new System.Drawing.Size(85, 27);
            this.dkwj_btn.TabIndex = 19;
            this.dkwj_btn.Text = "打开文件";
            this.dkwj_btn.UseVisualStyleBackColor = true;
            // 
            // fswj_btn
            // 
            this.fswj_btn.Location = new System.Drawing.Point(140, 109);
            this.fswj_btn.Name = "fswj_btn";
            this.fswj_btn.Size = new System.Drawing.Size(85, 27);
            this.fswj_btn.TabIndex = 20;
            this.fswj_btn.Text = "发送文件";
            this.fswj_btn.UseVisualStyleBackColor = true;
            // 
            // sendfile_txb
            // 
            this.sendfile_txb.Location = new System.Drawing.Point(0, 142);
            this.sendfile_txb.Name = "sendfile_txb";
            this.sendfile_txb.Size = new System.Drawing.Size(227, 25);
            this.sendfile_txb.TabIndex = 4;
            this.sendfile_txb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "自动发送周期(ms):";
            // 
            // autotimer_txb
            // 
            this.autotimer_txb.Location = new System.Drawing.Point(140, 171);
            this.autotimer_txb.Name = "autotimer_txb";
            this.autotimer_txb.Size = new System.Drawing.Size(87, 25);
            this.autotimer_txb.TabIndex = 22;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.state_tssl,
            this.toolStripStatusLabel3,
            this.sendcount_tssl,
            this.toolStripStatusLabel5,
            this.recivecount_tssl,
            this.cleancount_tssl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "状态：";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // state_tssl
            // 
            this.state_tssl.AutoSize = false;
            this.state_tssl.Name = "state_tssl";
            this.state_tssl.Size = new System.Drawing.Size(200, 20);
            this.state_tssl.Text = "初始化正常！";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // sendcount_tssl
            // 
            this.sendcount_tssl.AutoSize = false;
            this.sendcount_tssl.Name = "sendcount_tssl";
            this.sendcount_tssl.Size = new System.Drawing.Size(50, 20);
            this.sendcount_tssl.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel5.Text = "接收计数：";
            // 
            // recivecount_tssl
            // 
            this.recivecount_tssl.AutoSize = false;
            this.recivecount_tssl.Name = "recivecount_tssl";
            this.recivecount_tssl.Size = new System.Drawing.Size(50, 20);
            this.recivecount_tssl.Text = "0";
            // 
            // cleancount_tssl
            // 
            this.cleancount_tssl.Name = "cleancount_tssl";
            this.cleancount_tssl.Size = new System.Drawing.Size(69, 20);
            this.cleancount_tssl.Text = "清空计数";
            // 
            // recive_rtb
            // 
            this.recive_rtb.BackColor = System.Drawing.SystemColors.Info;
            this.recive_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recive_rtb.Location = new System.Drawing.Point(3, 21);
            this.recive_rtb.Name = "recive_rtb";
            this.recive_rtb.Size = new System.Drawing.Size(549, 396);
            this.recive_rtb.TabIndex = 0;
            this.recive_rtb.Text = "";
            // 
            // send_rtb
            // 
            this.send_rtb.BackColor = System.Drawing.SystemColors.Info;
            this.send_rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.send_rtb.Location = new System.Drawing.Point(3, 21);
            this.send_rtb.Name = "send_rtb";
            this.send_rtb.Size = new System.Drawing.Size(549, 178);
            this.send_rtb.TabIndex = 1;
            this.send_rtb.Text = "";
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 660);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口调试助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.CheckBox DTR_chb;
        private System.Windows.Forms.CheckBox RTS_chb;
        private System.Windows.Forms.ComboBox stopbit_cbb;
        private System.Windows.Forms.ComboBox databit_cbb;
        private System.Windows.Forms.ComboBox check_cbb;
        private System.Windows.Forms.ComboBox baud_cbb;
        private System.Windows.Forms.ComboBox port_cbb;
        private System.Windows.Forms.Button bcsj_btn;
        private System.Windows.Forms.Button xzlj_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.CheckBox hex_chb;
        private System.Windows.Forms.CheckBox autoclear_chb;
        private System.Windows.Forms.TextBox recivefile_txb;
        private System.Windows.Forms.TextBox sendfile_txb;
        private System.Windows.Forms.Button sendclear_btn;
        private System.Windows.Forms.Button fswj_btn;
        private System.Windows.Forms.CheckBox receivehex_chb;
        private System.Windows.Forms.Button dkwj_btn;
        private System.Windows.Forms.CheckBox sendhex_chb;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox autotimer_txb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel state_tssl;
        private System.Windows.Forms.RichTextBox recive_rtb;
        private System.Windows.Forms.RichTextBox send_rtb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel sendcount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel recivecount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel cleancount_tssl;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
    }
}

