namespace MyMobilerScanner
{
    partial class FormMyMobilerScanner
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
            this.comboBoxInterfaces = new System.Windows.Forms.ComboBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBoxIP = new System.Windows.Forms.ListBox();
            this.TextboxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIPLow = new System.Windows.Forms.TextBox();
            this.textBoxIPHigh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxInterfaces
            // 
            this.comboBoxInterfaces.FormattingEnabled = true;
            this.comboBoxInterfaces.Location = new System.Drawing.Point(12, 12);
            this.comboBoxInterfaces.Name = "comboBoxInterfaces";
            this.comboBoxInterfaces.Size = new System.Drawing.Size(247, 21);
            this.comboBoxInterfaces.TabIndex = 0;
            this.comboBoxInterfaces.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(278, 40);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 23);
            this.buttonScan.TabIndex = 1;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 400);
            this.progressBar1.Maximum = 254;
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(341, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 1;
            // 
            // listBoxIP
            // 
            this.listBoxIP.FormattingEnabled = true;
            this.listBoxIP.Location = new System.Drawing.Point(13, 66);
            this.listBoxIP.Name = "listBoxIP";
            this.listBoxIP.Size = new System.Drawing.Size(246, 186);
            this.listBoxIP.TabIndex = 4;
            this.listBoxIP.SelectedIndexChanged += new System.EventHandler(this.listBoxIP_SelectedIndexChanged);
            listBoxIP.DoubleClick += new System.EventHandler(this.listBoxIP_DoubleClick);
            // 
            // TextboxPort
            // 
            this.TextboxPort.Location = new System.Drawing.Point(278, 12);
            this.TextboxPort.Name = "TextboxPort";
            this.TextboxPort.Size = new System.Drawing.Size(75, 20);
            this.TextboxPort.TabIndex = 6;
            this.TextboxPort.Text = "1004";
            this.TextboxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(13, 40);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(80, 20);
            this.textBoxIP.TabIndex = 7;
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(13, 263);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(246, 121);
            this.listBoxLog.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = ".";
            // 
            // textBoxIPLow
            // 
            this.textBoxIPLow.Location = new System.Drawing.Point(108, 40);
            this.textBoxIPLow.Name = "textBoxIPLow";
            this.textBoxIPLow.Size = new System.Drawing.Size(60, 20);
            this.textBoxIPLow.TabIndex = 10;
            this.textBoxIPLow.Text = "1";
            this.textBoxIPLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxIPHigh
            // 
            this.textBoxIPHigh.Location = new System.Drawing.Point(199, 40);
            this.textBoxIPHigh.Name = "textBoxIPHigh";
            this.textBoxIPHigh.Size = new System.Drawing.Size(60, 20);
            this.textBoxIPHigh.TabIndex = 11;
            this.textBoxIPHigh.Text = "254";
            this.textBoxIPHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "-";
            // 
            // FormMyMobilerScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIPHigh);
            this.Controls.Add(this.textBoxIPLow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.TextboxPort);
            this.Controls.Add(this.listBoxIP);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.comboBoxInterfaces);
            this.Name = "FormMyMobilerScanner";
            this.Text = "MyMobilerScanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInterfaces;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBoxIP;
        private System.Windows.Forms.TextBox TextboxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIPLow;
        private System.Windows.Forms.TextBox textBoxIPHigh;
        private System.Windows.Forms.Label label2;
    }
}

