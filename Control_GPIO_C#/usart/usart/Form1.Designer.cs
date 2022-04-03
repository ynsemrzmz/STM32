namespace usart
{
    partial class USART
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxBaudRates = new System.Windows.Forms.ComboBox();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonReset1 = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelConnStat = new System.Windows.Forms.Label();
            this.labelGPIOStat1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serialPortConnection = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.labelGPIOStat3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonReset2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelGPIOStat2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.buttonReset3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxBaudRates
            // 
            this.comboBoxBaudRates.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBaudRates.FormattingEnabled = true;
            this.comboBoxBaudRates.Location = new System.Drawing.Point(196, 90);
            this.comboBoxBaudRates.Name = "comboBoxBaudRates";
            this.comboBoxBaudRates.Size = new System.Drawing.Size(173, 31);
            this.comboBoxBaudRates.TabIndex = 0;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(196, 30);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(173, 31);
            this.comboBoxPorts.TabIndex = 1;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDisconnect.Location = new System.Drawing.Point(642, 30);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(200, 61);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonReset1
            // 
            this.buttonReset1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonReset1.Location = new System.Drawing.Point(171, 68);
            this.buttonReset1.Name = "buttonReset1";
            this.buttonReset1.Size = new System.Drawing.Size(121, 31);
            this.buttonReset1.TabIndex = 3;
            this.buttonReset1.Text = "RESET";
            this.buttonReset1.UseVisualStyleBackColor = true;
            this.buttonReset1.Click += new System.EventHandler(this.buttonReset1_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConnect.Location = new System.Drawing.Point(434, 30);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(180, 64);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonSet1
            // 
            this.buttonSet1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSet1.Location = new System.Drawing.Point(10, 68);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(121, 31);
            this.buttonSet1.TabIndex = 5;
            this.buttonSet1.Text = "SET";
            this.buttonSet1.UseVisualStyleBackColor = true;
            this.buttonSet1.Click += new System.EventHandler(this.buttonSet1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ports : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud Rates : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Control GPIO 1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(430, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Connection Status : ";
            // 
            // labelConnStat
            // 
            this.labelConnStat.AutoSize = true;
            this.labelConnStat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelConnStat.Location = new System.Drawing.Point(672, 122);
            this.labelConnStat.Name = "labelConnStat";
            this.labelConnStat.Size = new System.Drawing.Size(70, 23);
            this.labelConnStat.TabIndex = 10;
            this.labelConnStat.Text = "label5";
            // 
            // labelGPIOStat1
            // 
            this.labelGPIOStat1.AutoSize = true;
            this.labelGPIOStat1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPIOStat1.Location = new System.Drawing.Point(167, 130);
            this.labelGPIOStat1.Name = "labelGPIOStat1";
            this.labelGPIOStat1.Size = new System.Drawing.Size(70, 23);
            this.labelGPIOStat1.TabIndex = 11;
            this.labelGPIOStat1.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "GPIO Status : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "GPIO Status : ";
            // 
            // labelGPIOStat3
            // 
            this.labelGPIOStat3.AutoSize = true;
            this.labelGPIOStat3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPIOStat3.Location = new System.Drawing.Point(177, 128);
            this.labelGPIOStat3.Name = "labelGPIOStat3";
            this.labelGPIOStat3.Size = new System.Drawing.Size(70, 23);
            this.labelGPIOStat3.TabIndex = 16;
            this.labelGPIOStat3.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(16, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Control GPIO 3 :";
            // 
            // buttonSet2
            // 
            this.buttonSet2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSet2.Location = new System.Drawing.Point(15, 67);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(121, 31);
            this.buttonSet2.TabIndex = 14;
            this.buttonSet2.Text = "SET";
            this.buttonSet2.UseVisualStyleBackColor = true;
            this.buttonSet2.Click += new System.EventHandler(this.buttonSet2_Click);
            // 
            // buttonReset2
            // 
            this.buttonReset2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonReset2.Location = new System.Drawing.Point(176, 67);
            this.buttonReset2.Name = "buttonReset2";
            this.buttonReset2.Size = new System.Drawing.Size(121, 31);
            this.buttonReset2.TabIndex = 13;
            this.buttonReset2.Text = "RESET";
            this.buttonReset2.UseVisualStyleBackColor = true;
            this.buttonReset2.Click += new System.EventHandler(this.buttonReset2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "GPIO Status : ";
            // 
            // labelGPIOStat2
            // 
            this.labelGPIOStat2.AutoSize = true;
            this.labelGPIOStat2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPIOStat2.Location = new System.Drawing.Point(172, 130);
            this.labelGPIOStat2.Name = "labelGPIOStat2";
            this.labelGPIOStat2.Size = new System.Drawing.Size(70, 23);
            this.labelGPIOStat2.TabIndex = 21;
            this.labelGPIOStat2.Text = "label5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(11, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Control GPIO 2 :";
            // 
            // buttonSet3
            // 
            this.buttonSet3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSet3.Location = new System.Drawing.Point(20, 68);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(121, 31);
            this.buttonSet3.TabIndex = 19;
            this.buttonSet3.Text = "SET";
            this.buttonSet3.UseVisualStyleBackColor = true;
            this.buttonSet3.Click += new System.EventHandler(this.buttonSet3_Click);
            // 
            // buttonReset3
            // 
            this.buttonReset3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonReset3.Location = new System.Drawing.Point(172, 67);
            this.buttonReset3.Name = "buttonReset3";
            this.buttonReset3.Size = new System.Drawing.Size(121, 31);
            this.buttonReset3.TabIndex = 18;
            this.buttonReset3.Text = "RESET";
            this.buttonReset3.UseVisualStyleBackColor = true;
            this.buttonReset3.Click += new System.EventHandler(this.buttonReset3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.buttonReset1);
            this.groupBox1.Controls.Add(this.buttonSet1);
            this.groupBox1.Controls.Add(this.labelGPIOStat1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 177);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPIO1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSet3);
            this.groupBox2.Controls.Add(this.buttonReset3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelGPIOStat3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(691, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 165);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GPIO3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSet2);
            this.groupBox3.Controls.Add(this.buttonReset2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.labelGPIOStat2);
            this.groupBox3.Location = new System.Drawing.Point(356, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 177);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPIO2";
            // 
            // USART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 404);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelConnStat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.comboBoxBaudRates);
            this.Name = "USART";
            this.Text = "USART";
            this.Load += new System.EventHandler(this.USART_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBaudRates;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonReset1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConnStat;
        private System.Windows.Forms.Label labelGPIOStat1;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialPortConnection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGPIOStat3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonReset2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelGPIOStat2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Button buttonReset3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

