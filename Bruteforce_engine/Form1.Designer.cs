namespace Bruteforce_engine
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.AccLabel = new System.Windows.Forms.Label();
            this.AccLabelC = new System.Windows.Forms.Label();
            this.ProxLabel = new System.Windows.Forms.Label();
            this.ProxLabelC = new System.Windows.Forms.Label();
            this.GoodLabel = new System.Windows.Forms.Label();
            this.GoodLabelC = new System.Windows.Forms.Label();
            this.BadLabel = new System.Windows.Forms.Label();
            this.BadLabelC = new System.Windows.Forms.Label();
            this.ErrLabel = new System.Windows.Forms.Label();
            this.ErrLabelC = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CaptLabel = new System.Windows.Forms.Label();
            this.CaptLabelC = new System.Windows.Forms.Label();
            this.ThreadsLabel = new System.Windows.Forms.Label();
            this.ThreadsLabelC = new System.Windows.Forms.Label();
            this.ThreLabelC = new System.Windows.Forms.Label();
            this.ProxyCheckB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProxyCheckB);
            this.groupBox1.Controls.Add(this.ThreLabelC);
            this.groupBox1.Controls.Add(this.ThreadsLabelC);
            this.groupBox1.Controls.Add(this.ThreadsLabel);
            this.groupBox1.Controls.Add(this.CaptLabelC);
            this.groupBox1.Controls.Add(this.CaptLabel);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.ErrLabelC);
            this.groupBox1.Controls.Add(this.ErrLabel);
            this.groupBox1.Controls.Add(this.BadLabelC);
            this.groupBox1.Controls.Add(this.BadLabel);
            this.groupBox1.Controls.Add(this.GoodLabelC);
            this.groupBox1.Controls.Add(this.GoodLabel);
            this.groupBox1.Controls.Add(this.ProxLabelC);
            this.groupBox1.Controls.Add(this.ProxLabel);
            this.groupBox1.Controls.Add(this.AccLabelC);
            this.groupBox1.Controls.Add(this.AccLabel);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 321);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 110);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(298, 204);
            this.textBox3.TabIndex = 0;
            // 
            // AccLabel
            // 
            this.AccLabel.AutoSize = true;
            this.AccLabel.Location = new System.Drawing.Point(6, 16);
            this.AccLabel.Name = "AccLabel";
            this.AccLabel.Size = new System.Drawing.Size(55, 13);
            this.AccLabel.TabIndex = 1;
            this.AccLabel.Text = "Accounts:";
            // 
            // AccLabelC
            // 
            this.AccLabelC.AutoSize = true;
            this.AccLabelC.Location = new System.Drawing.Point(58, 16);
            this.AccLabelC.Name = "AccLabelC";
            this.AccLabelC.Size = new System.Drawing.Size(13, 13);
            this.AccLabelC.TabIndex = 2;
            this.AccLabelC.Text = "0";
            this.AccLabelC.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProxLabel
            // 
            this.ProxLabel.AutoSize = true;
            this.ProxLabel.Location = new System.Drawing.Point(6, 29);
            this.ProxLabel.Name = "ProxLabel";
            this.ProxLabel.Size = new System.Drawing.Size(36, 13);
            this.ProxLabel.TabIndex = 3;
            this.ProxLabel.Text = "Proxy:";
            // 
            // ProxLabelC
            // 
            this.ProxLabelC.AutoSize = true;
            this.ProxLabelC.Location = new System.Drawing.Point(58, 29);
            this.ProxLabelC.Name = "ProxLabelC";
            this.ProxLabelC.Size = new System.Drawing.Size(13, 13);
            this.ProxLabelC.TabIndex = 4;
            this.ProxLabelC.Text = "0";
            // 
            // GoodLabel
            // 
            this.GoodLabel.AutoSize = true;
            this.GoodLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GoodLabel.Location = new System.Drawing.Point(6, 55);
            this.GoodLabel.Name = "GoodLabel";
            this.GoodLabel.Size = new System.Drawing.Size(33, 13);
            this.GoodLabel.TabIndex = 5;
            this.GoodLabel.Text = "Good";
            // 
            // GoodLabelC
            // 
            this.GoodLabelC.AutoSize = true;
            this.GoodLabelC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GoodLabelC.Location = new System.Drawing.Point(58, 55);
            this.GoodLabelC.Name = "GoodLabelC";
            this.GoodLabelC.Size = new System.Drawing.Size(13, 13);
            this.GoodLabelC.TabIndex = 6;
            this.GoodLabelC.Text = "0";
            // 
            // BadLabel
            // 
            this.BadLabel.AutoSize = true;
            this.BadLabel.ForeColor = System.Drawing.Color.Crimson;
            this.BadLabel.Location = new System.Drawing.Point(6, 68);
            this.BadLabel.Name = "BadLabel";
            this.BadLabel.Size = new System.Drawing.Size(29, 13);
            this.BadLabel.TabIndex = 7;
            this.BadLabel.Text = "Bad:";
            // 
            // BadLabelC
            // 
            this.BadLabelC.AutoSize = true;
            this.BadLabelC.ForeColor = System.Drawing.Color.Crimson;
            this.BadLabelC.Location = new System.Drawing.Point(58, 68);
            this.BadLabelC.Name = "BadLabelC";
            this.BadLabelC.Size = new System.Drawing.Size(13, 13);
            this.BadLabelC.TabIndex = 8;
            this.BadLabelC.Text = "0";
            // 
            // ErrLabel
            // 
            this.ErrLabel.AutoSize = true;
            this.ErrLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ErrLabel.Location = new System.Drawing.Point(6, 81);
            this.ErrLabel.Name = "ErrLabel";
            this.ErrLabel.Size = new System.Drawing.Size(32, 13);
            this.ErrLabel.TabIndex = 9;
            this.ErrLabel.Text = "Error:";
            this.ErrLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ErrLabelC
            // 
            this.ErrLabelC.AutoSize = true;
            this.ErrLabelC.ForeColor = System.Drawing.Color.Maroon;
            this.ErrLabelC.Location = new System.Drawing.Point(58, 81);
            this.ErrLabelC.Name = "ErrLabelC";
            this.ErrLabelC.Size = new System.Drawing.Size(13, 13);
            this.ErrLabelC.TabIndex = 10;
            this.ErrLabelC.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(205, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 26);
            this.button4.TabIndex = 12;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CaptLabel
            // 
            this.CaptLabel.AutoSize = true;
            this.CaptLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CaptLabel.Location = new System.Drawing.Point(7, 94);
            this.CaptLabel.Name = "CaptLabel";
            this.CaptLabel.Size = new System.Drawing.Size(50, 13);
            this.CaptLabel.TabIndex = 13;
            this.CaptLabel.Text = "Captcha:";
            // 
            // CaptLabelC
            // 
            this.CaptLabelC.AutoSize = true;
            this.CaptLabelC.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.CaptLabelC.Location = new System.Drawing.Point(58, 94);
            this.CaptLabelC.Name = "CaptLabelC";
            this.CaptLabelC.Size = new System.Drawing.Size(13, 13);
            this.CaptLabelC.TabIndex = 14;
            this.CaptLabelC.Text = "0";
            // 
            // ThreadsLabel
            // 
            this.ThreadsLabel.AutoSize = true;
            this.ThreadsLabel.ForeColor = System.Drawing.Color.Black;
            this.ThreadsLabel.Location = new System.Drawing.Point(6, 42);
            this.ThreadsLabel.Name = "ThreadsLabel";
            this.ThreadsLabel.Size = new System.Drawing.Size(49, 13);
            this.ThreadsLabel.TabIndex = 15;
            this.ThreadsLabel.Text = "Threads:";
            // 
            // ThreadsLabelC
            // 
            this.ThreadsLabelC.AutoSize = true;
            this.ThreadsLabelC.ForeColor = System.Drawing.Color.Black;
            this.ThreadsLabelC.Location = new System.Drawing.Point(58, 42);
            this.ThreadsLabelC.Name = "ThreadsLabelC";
            this.ThreadsLabelC.Size = new System.Drawing.Size(0, 13);
            this.ThreadsLabelC.TabIndex = 16;
            // 
            // ThreLabelC
            // 
            this.ThreLabelC.AutoSize = true;
            this.ThreLabelC.ForeColor = System.Drawing.Color.Black;
            this.ThreLabelC.Location = new System.Drawing.Point(58, 42);
            this.ThreLabelC.Name = "ThreLabelC";
            this.ThreLabelC.Size = new System.Drawing.Size(13, 13);
            this.ThreLabelC.TabIndex = 17;
            this.ThreLabelC.Text = "0";
            // 
            // ProxyCheckB
            // 
            this.ProxyCheckB.AutoSize = true;
            this.ProxyCheckB.Location = new System.Drawing.Point(205, 90);
            this.ProxyCheckB.Name = "ProxyCheckB";
            this.ProxyCheckB.Size = new System.Drawing.Size(74, 17);
            this.ProxyCheckB.TabIndex = 18;
            this.ProxyCheckB.Text = "Use Proxy";
            this.ProxyCheckB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 330);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BruteForce Engine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label AccLabel;
        private System.Windows.Forms.Label GoodLabel;
        private System.Windows.Forms.Label ProxLabel;
        private System.Windows.Forms.Label ErrLabel;
        private System.Windows.Forms.Label BadLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label AccLabelC;
        public System.Windows.Forms.Label GoodLabelC;
        public System.Windows.Forms.Label ProxLabelC;
        public System.Windows.Forms.Label BadLabelC;
        public System.Windows.Forms.Label ErrLabelC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CaptLabelC;
        private System.Windows.Forms.Label CaptLabel;
        private System.Windows.Forms.Label ThreadsLabel;
        private System.Windows.Forms.Label ThreadsLabelC;
        private System.Windows.Forms.Label ThreLabelC;
        public System.Windows.Forms.CheckBox ProxyCheckB;
    }
}

