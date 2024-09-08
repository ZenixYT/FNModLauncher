namespace FNModLauncher
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.defaultModServerLabel = new System.Windows.Forms.Label();
            this.defaultModServerBox = new System.Windows.Forms.TextBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.autoUpdateCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // defaultModServerLabel
            // 
            this.defaultModServerLabel.AutoSize = true;
            this.defaultModServerLabel.Location = new System.Drawing.Point(12, 9);
            this.defaultModServerLabel.Name = "defaultModServerLabel";
            this.defaultModServerLabel.Size = new System.Drawing.Size(105, 13);
            this.defaultModServerLabel.TabIndex = 0;
            this.defaultModServerLabel.Text = "Default Mod Server: ";
            // 
            // defaultModServerBox
            // 
            this.defaultModServerBox.Location = new System.Drawing.Point(123, 6);
            this.defaultModServerBox.Name = "defaultModServerBox";
            this.defaultModServerBox.Size = new System.Drawing.Size(231, 20);
            this.defaultModServerBox.TabIndex = 1;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(279, 58);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 2;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // autoUpdateCheck
            // 
            this.autoUpdateCheck.AutoSize = true;
            this.autoUpdateCheck.Location = new System.Drawing.Point(12, 30);
            this.autoUpdateCheck.Name = "autoUpdateCheck";
            this.autoUpdateCheck.Size = new System.Drawing.Size(180, 17);
            this.autoUpdateCheck.TabIndex = 3;
            this.autoUpdateCheck.Text = "Automatically Check for Updates";
            this.autoUpdateCheck.UseVisualStyleBackColor = true;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 93);
            this.Controls.Add(this.autoUpdateCheck);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.defaultModServerBox);
            this.Controls.Add(this.defaultModServerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label defaultModServerLabel;
        private System.Windows.Forms.TextBox defaultModServerBox;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.CheckBox autoUpdateCheck;
    }
}