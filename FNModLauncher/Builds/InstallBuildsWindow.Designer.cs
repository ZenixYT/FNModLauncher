namespace FNModLauncher.Builds
{
    partial class InstallBuildsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallBuildsWindow));
            this.buildsBox = new System.Windows.Forms.ListBox();
            this.installPathLabel = new System.Windows.Forms.Label();
            this.installPathBox = new System.Windows.Forms.TextBox();
            this.installPathButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildsBox
            // 
            this.buildsBox.FormattingEnabled = true;
            this.buildsBox.Location = new System.Drawing.Point(12, 12);
            this.buildsBox.Name = "buildsBox";
            this.buildsBox.Size = new System.Drawing.Size(562, 147);
            this.buildsBox.TabIndex = 0;
            this.buildsBox.SelectedIndexChanged += new System.EventHandler(this.buildsBox_SelectedIndexChanged);
            // 
            // installPathLabel
            // 
            this.installPathLabel.AutoSize = true;
            this.installPathLabel.Location = new System.Drawing.Point(12, 170);
            this.installPathLabel.Name = "installPathLabel";
            this.installPathLabel.Size = new System.Drawing.Size(88, 13);
            this.installPathLabel.TabIndex = 1;
            this.installPathLabel.Text = "Installation Path: ";
            // 
            // installPathBox
            // 
            this.installPathBox.Location = new System.Drawing.Point(106, 167);
            this.installPathBox.Name = "installPathBox";
            this.installPathBox.Size = new System.Drawing.Size(429, 20);
            this.installPathBox.TabIndex = 2;
            // 
            // installPathButton
            // 
            this.installPathButton.Location = new System.Drawing.Point(541, 165);
            this.installPathButton.Name = "installPathButton";
            this.installPathButton.Size = new System.Drawing.Size(33, 23);
            this.installPathButton.TabIndex = 3;
            this.installPathButton.Text = "...";
            this.installPathButton.UseVisualStyleBackColor = true;
            this.installPathButton.Click += new System.EventHandler(this.installPathButton_Click);
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(451, 194);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(123, 23);
            this.installButton.TabIndex = 4;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // InstallBuildsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 227);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.installPathButton);
            this.Controls.Add(this.installPathBox);
            this.Controls.Add(this.installPathLabel);
            this.Controls.Add(this.buildsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallBuildsWindow";
            this.Text = "Install Builds";
            this.Load += new System.EventHandler(this.InstallBuildsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox buildsBox;
        private System.Windows.Forms.Label installPathLabel;
        private System.Windows.Forms.TextBox installPathBox;
        private System.Windows.Forms.Button installPathButton;
        private System.Windows.Forms.Button installButton;
    }
}