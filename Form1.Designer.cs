namespace TCP_Check_Port_tool07
{
    partial class Form1
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
            this.httpcheckbox = new System.Windows.Forms.CheckBox();
            this.httpscheckbox = new System.Windows.Forms.CheckBox();
            this.restcheckbox = new System.Windows.Forms.CheckBox();
            this.ippscheckbox = new System.Windows.Forms.CheckBox();
            this.ldpcheckbox = new System.Windows.Forms.CheckBox();
            this.ippcheckbox = new System.Windows.Forms.CheckBox();
            this.ftpcheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtipaddress = new System.Windows.Forms.TextBox();
            this.txtportnumber = new System.Windows.Forms.TextBox();
            this.httpresult = new System.Windows.Forms.TextBox();
            this.httpsresult = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ippsresult = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.HTTP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.restresult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ldpresult = new System.Windows.Forms.Label();
            this.ippresult = new System.Windows.Forms.Label();
            this.ftpresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // httpcheckbox
            // 
            this.httpcheckbox.AutoSize = true;
            this.httpcheckbox.Location = new System.Drawing.Point(282, 177);
            this.httpcheckbox.Name = "httpcheckbox";
            this.httpcheckbox.Size = new System.Drawing.Size(75, 24);
            this.httpcheckbox.TabIndex = 0;
            this.httpcheckbox.Text = "HTTP";
            this.httpcheckbox.UseVisualStyleBackColor = true;
            this.httpcheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // httpscheckbox
            // 
            this.httpscheckbox.AutoSize = true;
            this.httpscheckbox.Location = new System.Drawing.Point(459, 177);
            this.httpscheckbox.Name = "httpscheckbox";
            this.httpscheckbox.Size = new System.Drawing.Size(86, 24);
            this.httpscheckbox.TabIndex = 1;
            this.httpscheckbox.Text = "HTTPS";
            this.httpscheckbox.UseVisualStyleBackColor = true;
            this.httpscheckbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // restcheckbox
            // 
            this.restcheckbox.AutoSize = true;
            this.restcheckbox.Location = new System.Drawing.Point(607, 177);
            this.restcheckbox.Name = "restcheckbox";
            this.restcheckbox.Size = new System.Drawing.Size(78, 24);
            this.restcheckbox.TabIndex = 2;
            this.restcheckbox.Text = "REST";
            this.restcheckbox.UseVisualStyleBackColor = true;
            this.restcheckbox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ippscheckbox
            // 
            this.ippscheckbox.AutoSize = true;
            this.ippscheckbox.Location = new System.Drawing.Point(282, 240);
            this.ippscheckbox.Name = "ippscheckbox";
            this.ippscheckbox.Size = new System.Drawing.Size(71, 24);
            this.ippscheckbox.TabIndex = 3;
            this.ippscheckbox.Text = "IPPS";
            this.ippscheckbox.UseVisualStyleBackColor = true;
            this.ippscheckbox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ldpcheckbox
            // 
            this.ldpcheckbox.AutoSize = true;
            this.ldpcheckbox.Location = new System.Drawing.Point(459, 240);
            this.ldpcheckbox.Name = "ldpcheckbox";
            this.ldpcheckbox.Size = new System.Drawing.Size(66, 24);
            this.ldpcheckbox.TabIndex = 4;
            this.ldpcheckbox.Text = "LDP";
            this.ldpcheckbox.UseVisualStyleBackColor = true;
            this.ldpcheckbox.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // ippcheckbox
            // 
            this.ippcheckbox.AutoSize = true;
            this.ippcheckbox.Location = new System.Drawing.Point(607, 240);
            this.ippcheckbox.Name = "ippcheckbox";
            this.ippcheckbox.Size = new System.Drawing.Size(60, 24);
            this.ippcheckbox.TabIndex = 5;
            this.ippcheckbox.Text = "IPP";
            this.ippcheckbox.UseVisualStyleBackColor = true;
            this.ippcheckbox.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // ftpcheckbox
            // 
            this.ftpcheckbox.AutoSize = true;
            this.ftpcheckbox.Location = new System.Drawing.Point(459, 296);
            this.ftpcheckbox.Name = "ftpcheckbox";
            this.ftpcheckbox.Size = new System.Drawing.Size(64, 24);
            this.ftpcheckbox.TabIndex = 6;
            this.ftpcheckbox.Text = "FTP";
            this.ftpcheckbox.UseVisualStyleBackColor = true;
            this.ftpcheckbox.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtipaddress
            // 
            this.txtipaddress.Location = new System.Drawing.Point(231, 36);
            this.txtipaddress.Name = "txtipaddress";
            this.txtipaddress.Size = new System.Drawing.Size(250, 26);
            this.txtipaddress.TabIndex = 11;
            this.txtipaddress.TextChanged += new System.EventHandler(this.txtipaddress_TextChanged);
            // 
            // txtportnumber
            // 
            this.txtportnumber.Location = new System.Drawing.Point(231, 106);
            this.txtportnumber.Name = "txtportnumber";
            this.txtportnumber.Size = new System.Drawing.Size(100, 26);
            this.txtportnumber.TabIndex = 12;
            this.txtportnumber.TextChanged += new System.EventHandler(this.txtportnumber_TextChanged);
            // 
            // httpresult
            // 
            this.httpresult.Location = new System.Drawing.Point(172, 361);
            this.httpresult.Name = "httpresult";
            this.httpresult.Size = new System.Drawing.Size(185, 26);
            this.httpresult.TabIndex = 13;
            this.httpresult.TextChanged += new System.EventHandler(this.httpresult_TextChanged);
            // 
            // httpsresult
            // 
            this.httpsresult.Location = new System.Drawing.Point(448, 361);
            this.httpsresult.Name = "httpsresult";
            this.httpsresult.Size = new System.Drawing.Size(155, 26);
            this.httpsresult.TabIndex = 14;
            this.httpsresult.TextChanged += new System.EventHandler(this.httpsresult_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(677, 348);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 26);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ippsresult
            // 
            this.ippsresult.Location = new System.Drawing.Point(172, 429);
            this.ippsresult.Name = "ippsresult";
            this.ippsresult.Size = new System.Drawing.Size(193, 26);
            this.ippsresult.TabIndex = 16;
            this.ippsresult.TextChanged += new System.EventHandler(this.ippsresult_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(448, 429);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 26);
            this.textBox5.TabIndex = 17;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(677, 429);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 26);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(423, 474);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(244, 26);
            this.textBox7.TabIndex = 19;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // HTTP
            // 
            this.HTTP.AutoSize = true;
            this.HTTP.Location = new System.Drawing.Point(81, 366);
            this.HTTP.Name = "HTTP";
            this.HTTP.Size = new System.Drawing.Size(49, 20);
            this.HTTP.TabIndex = 20;
            this.HTTP.Text = "HTTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "HTTPS";
            // 
            // restresult
            // 
            this.restresult.AutoSize = true;
            this.restresult.Location = new System.Drawing.Point(616, 361);
            this.restresult.Name = "restresult";
            this.restresult.Size = new System.Drawing.Size(52, 20);
            this.restresult.TabIndex = 22;
            this.restresult.Text = "REST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "IPPS";
            // 
            // ldpresult
            // 
            this.ldpresult.AutoSize = true;
            this.ldpresult.Location = new System.Drawing.Point(371, 435);
            this.ldpresult.Name = "ldpresult";
            this.ldpresult.Size = new System.Drawing.Size(40, 20);
            this.ldpresult.TabIndex = 24;
            this.ldpresult.Text = "LDP";
            // 
            // ippresult
            // 
            this.ippresult.AutoSize = true;
            this.ippresult.Location = new System.Drawing.Point(620, 432);
            this.ippresult.Name = "ippresult";
            this.ippresult.Size = new System.Drawing.Size(34, 20);
            this.ippresult.TabIndex = 25;
            this.ippresult.Text = "IPP";
            // 
            // ftpresult
            // 
            this.ftpresult.AutoSize = true;
            this.ftpresult.Location = new System.Drawing.Point(352, 489);
            this.ftpresult.Name = "ftpresult";
            this.ftpresult.Size = new System.Drawing.Size(38, 20);
            this.ftpresult.TabIndex = 26;
            this.ftpresult.Text = "FTP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 512);
            this.Controls.Add(this.ftpresult);
            this.Controls.Add(this.ippresult);
            this.Controls.Add(this.ldpresult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.restresult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HTTP);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ippsresult);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.httpsresult);
            this.Controls.Add(this.httpresult);
            this.Controls.Add(this.txtportnumber);
            this.Controls.Add(this.txtipaddress);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ftpcheckbox);
            this.Controls.Add(this.ippcheckbox);
            this.Controls.Add(this.ldpcheckbox);
            this.Controls.Add(this.ippscheckbox);
            this.Controls.Add(this.restcheckbox);
            this.Controls.Add(this.httpscheckbox);
            this.Controls.Add(this.httpcheckbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP CheckPort tool update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox httpcheckbox;
        private System.Windows.Forms.CheckBox httpscheckbox;
        private System.Windows.Forms.CheckBox restcheckbox;
        private System.Windows.Forms.CheckBox ippscheckbox;
        private System.Windows.Forms.CheckBox ldpcheckbox;
        private System.Windows.Forms.CheckBox ippcheckbox;
        private System.Windows.Forms.CheckBox ftpcheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtipaddress;
        private System.Windows.Forms.TextBox txtportnumber;
        private System.Windows.Forms.TextBox httpresult;
        private System.Windows.Forms.TextBox httpsresult;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox ippsresult;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label HTTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label restresult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ldpresult;
        private System.Windows.Forms.Label ippresult;
        private System.Windows.Forms.Label ftpresult;
    }
}

