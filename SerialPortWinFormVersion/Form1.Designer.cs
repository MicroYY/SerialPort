namespace SerialPortWinFormVersion
{
    partial class Form
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
            this.PortName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DiscntBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataRBox = new System.Windows.Forms.TextBox();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.DataSBox = new System.Windows.Forms.TextBox();
            this.SendDataBtn = new System.Windows.Forms.Button();
            this.newLineChkBox = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortName
            // 
            this.PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortName.FormattingEnabled = true;
            this.PortName.Location = new System.Drawing.Point(40, 90);
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(180, 32);
            this.PortName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DiscntBtn);
            this.groupBox1.Controls.Add(this.ConnectBtn);
            this.groupBox1.Controls.Add(this.Parity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DataBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PortName);
            this.groupBox1.Location = new System.Drawing.Point(840, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 700);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            // 
            // DiscntBtn
            // 
            this.DiscntBtn.Enabled = false;
            this.DiscntBtn.Location = new System.Drawing.Point(40, 630);
            this.DiscntBtn.Name = "DiscntBtn";
            this.DiscntBtn.Size = new System.Drawing.Size(180, 40);
            this.DiscntBtn.TabIndex = 8;
            this.DiscntBtn.Text = "Disconnect";
            this.DiscntBtn.UseVisualStyleBackColor = true;
            this.DiscntBtn.Click += new System.EventHandler(this.DiscntBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(40, 560);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(180, 40);
            this.ConnectBtn.TabIndex = 2;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Parity
            // 
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.Parity.Location = new System.Drawing.Point(40, 490);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(180, 32);
            this.Parity.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Parity";
            // 
            // Stop
            // 
            this.Stop.FormattingEnabled = true;
            this.Stop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.Stop.Location = new System.Drawing.Point(40, 390);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(180, 32);
            this.Stop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stop Bits";
            // 
            // DataBits
            // 
            this.DataBits.FormattingEnabled = true;
            this.DataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBits.Location = new System.Drawing.Point(40, 290);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(180, 32);
            this.DataBits.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Bits";
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRate.Location = new System.Drawing.Point(40, 190);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(180, 32);
            this.BaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Name";
            // 
            // DataRBox
            // 
            this.DataRBox.Location = new System.Drawing.Point(0, 0);
            this.DataRBox.Multiline = true;
            this.DataRBox.Name = "DataRBox";
            this.DataRBox.ReadOnly = true;
            this.DataRBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataRBox.Size = new System.Drawing.Size(840, 450);
            this.DataRBox.TabIndex = 8;
            // 
            // DataSBox
            // 
            this.DataSBox.Location = new System.Drawing.Point(0, 480);
            this.DataSBox.Multiline = true;
            this.DataSBox.Name = "DataSBox";
            this.DataSBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataSBox.Size = new System.Drawing.Size(615, 79);
            this.DataSBox.TabIndex = 10;
            // 
            // SendDataBtn
            // 
            this.SendDataBtn.Enabled = false;
            this.SendDataBtn.Location = new System.Drawing.Point(640, 500);
            this.SendDataBtn.Name = "SendDataBtn";
            this.SendDataBtn.Size = new System.Drawing.Size(180, 40);
            this.SendDataBtn.TabIndex = 11;
            this.SendDataBtn.Text = "Send data";
            this.SendDataBtn.UseVisualStyleBackColor = true;
            this.SendDataBtn.Click += new System.EventHandler(this.SendDataBox_Click);
            // 
            // newLineChkBox
            // 
            this.newLineChkBox.AutoSize = true;
            this.newLineChkBox.Checked = true;
            this.newLineChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newLineChkBox.Location = new System.Drawing.Point(34, 636);
            this.newLineChkBox.Name = "newLineChkBox";
            this.newLineChkBox.Size = new System.Drawing.Size(138, 28);
            this.newLineChkBox.TabIndex = 9;
            this.newLineChkBox.Text = "发送新行";
            this.newLineChkBox.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(351, 627);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(180, 40);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "清除接收";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 759);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.newLineChkBox);
            this.Controls.Add(this.SendDataBtn);
            this.Controls.Add(this.DataSBox);
            this.Controls.Add(this.DataRBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form";
            this.Text = "SerialPort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Stop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DataBits;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.TextBox DataRBox;
        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.Button DiscntBtn;
        private System.Windows.Forms.TextBox DataSBox;
        private System.Windows.Forms.Button SendDataBtn;
        private System.Windows.Forms.CheckBox newLineChkBox;
        private System.Windows.Forms.Button clearBtn;
    }
}

