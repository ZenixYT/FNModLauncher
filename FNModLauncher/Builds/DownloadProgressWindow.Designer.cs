namespace FNModLauncher.Builds
{
    partial class DownloadProgressWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadProgressWindow));
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.bytesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadBar
            // 
            this.downloadBar.Location = new System.Drawing.Point(12, 12);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(369, 20);
            this.downloadBar.TabIndex = 0;
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Location = new System.Drawing.Point(387, 19);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(33, 13);
            this.downloadLabel.TabIndex = 1;
            this.downloadLabel.Text = "999%";
            // 
            // bytesLabel
            // 
            this.bytesLabel.AutoSize = true;
            this.bytesLabel.Location = new System.Drawing.Point(12, 35);
            this.bytesLabel.Name = "bytesLabel";
            this.bytesLabel.Size = new System.Drawing.Size(42, 13);
            this.bytesLabel.TabIndex = 2;
            this.bytesLabel.Text = "0b / 0b";
            // 
            // DownloadProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 58);
            this.Controls.Add(this.bytesLabel);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.downloadBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadProgressWindow";
            this.Text = "DownloadProgressWindow";
            this.Load += new System.EventHandler(this.DownloadProgressWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar downloadBar;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.Label bytesLabel;
    }
}