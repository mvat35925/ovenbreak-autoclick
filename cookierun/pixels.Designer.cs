namespace cookierun
{
    partial class pixels
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
            this.pixelsLabel = new System.Windows.Forms.Label();
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pixelsLabel
            // 
            this.pixelsLabel.AutoSize = true;
            this.pixelsLabel.Location = new System.Drawing.Point(13, 13);
            this.pixelsLabel.Name = "pixelsLabel";
            this.pixelsLabel.Size = new System.Drawing.Size(35, 13);
            this.pixelsLabel.TabIndex = 0;
            this.pixelsLabel.Text = "label1";
            // 
            // delayTimer
            // 
            this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copy to clipboard\r\nf1: x,y\r\nf2: color\r\nf3: both\r\n\r\n";
            // 
            // pixels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 111);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pixelsLabel);
            this.Name = "pixels";
            this.Text = "pixels";
            this.Load += new System.EventHandler(this.pixels_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pixels_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pixelsLabel;
        private System.Windows.Forms.Timer delayTimer;
        private System.Windows.Forms.Label label1;
    }
}