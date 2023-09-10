namespace cookierun
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.pixelsBtn = new System.Windows.Forms.Button();
            this.sizeGB = new System.Windows.Forms.GroupBox();
            this.size2 = new System.Windows.Forms.RadioButton();
            this.size1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.autoclickTimer = new System.Windows.Forms.Timer(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.tutorial = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.LinkLabel();
            this.sizeGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pixelsBtn
            // 
            this.pixelsBtn.Location = new System.Drawing.Point(217, 12);
            this.pixelsBtn.Name = "pixelsBtn";
            this.pixelsBtn.Size = new System.Drawing.Size(75, 23);
            this.pixelsBtn.TabIndex = 1;
            this.pixelsBtn.Text = "Tools";
            this.pixelsBtn.UseVisualStyleBackColor = true;
            this.pixelsBtn.Click += new System.EventHandler(this.pixelsBtn_Click);
            // 
            // sizeGB
            // 
            this.sizeGB.Controls.Add(this.size2);
            this.sizeGB.Controls.Add(this.size1);
            this.sizeGB.Controls.Add(this.label1);
            this.sizeGB.Location = new System.Drawing.Point(12, 57);
            this.sizeGB.Name = "sizeGB";
            this.sizeGB.Size = new System.Drawing.Size(200, 100);
            this.sizeGB.TabIndex = 2;
            this.sizeGB.TabStop = false;
            this.sizeGB.Text = "Setting";
            // 
            // size2
            // 
            this.size2.AutoSize = true;
            this.size2.Location = new System.Drawing.Point(26, 59);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(67, 17);
            this.size2.TabIndex = 3;
            this.size2.Text = "just radio";
            this.size2.UseVisualStyleBackColor = true;
            // 
            // size1
            // 
            this.size1.AutoSize = true;
            this.size1.Checked = true;
            this.size1.Location = new System.Drawing.Point(26, 36);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(87, 17);
            this.size1.TabIndex = 1;
            this.size1.TabStop = true;
            this.size1.Text = "1920  x 1080";
            this.size1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Screen size";
            // 
            // autoclickTimer
            // 
            this.autoclickTimer.Interval = 1000;
            this.autoclickTimer.Tick += new System.EventHandler(this.autoclickTimer_Tick);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(12, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(85, 18);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "status: stop";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(12, 36);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(72, 13);
            this.count.TabIndex = 4;
            this.count.Text = "Run: 0 time(s)";
            // 
            // tutorial
            // 
            this.tutorial.AllowDrop = true;
            this.tutorial.AutoSize = true;
            this.tutorial.Location = new System.Drawing.Point(12, 160);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(72, 26);
            this.tutorial.TabIndex = 5;
            this.tutorial.Text = "Ctrl + F1: start\r\nCtrl + F2: stop\r\n";
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.contact.Location = new System.Drawing.Point(248, 173);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(44, 13);
            this.contact.TabIndex = 6;
            this.contact.TabStop = true;
            this.contact.Text = "Contact";
            this.contact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contact_LinkClicked);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 194);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.tutorial);
            this.Controls.Add(this.count);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.sizeGB);
            this.Controls.Add(this.pixelsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Cookierun Autoclick";
            this.Load += new System.EventHandler(this.main_Load);
            this.sizeGB.ResumeLayout(false);
            this.sizeGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pixelsBtn;
        private System.Windows.Forms.GroupBox sizeGB;
        private System.Windows.Forms.RadioButton size2;
        private System.Windows.Forms.RadioButton size1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer autoclickTimer;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label tutorial;
        private System.Windows.Forms.LinkLabel contact;
    }
}

