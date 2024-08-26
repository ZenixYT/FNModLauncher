namespace FNModLauncher
{
    partial class MainWindow
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
            this.InstancesBox = new System.Windows.Forms.ListBox();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.InstancesLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstancesBox
            // 
            this.InstancesBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstancesBox.FormattingEnabled = true;
            this.InstancesBox.ItemHeight = 19;
            this.InstancesBox.Location = new System.Drawing.Point(12, 28);
            this.InstancesBox.Name = "InstancesBox";
            this.InstancesBox.Size = new System.Drawing.Size(291, 403);
            this.InstancesBox.TabIndex = 0;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(309, 28);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(97, 30);
            this.LaunchButton.TabIndex = 1;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // InstancesLabel
            // 
            this.InstancesLabel.AutoSize = true;
            this.InstancesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstancesLabel.Location = new System.Drawing.Point(12, 9);
            this.InstancesLabel.Name = "InstancesLabel";
            this.InstancesLabel.Size = new System.Drawing.Size(44, 16);
            this.InstancesLabel.TabIndex = 3;
            this.InstancesLabel.Text = "Builds";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add New Build";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(307, 401);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(97, 30);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 443);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InstancesLabel);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.InstancesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "FNModLauncher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InstancesBox;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Label InstancesLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SettingsButton;
    }
}

