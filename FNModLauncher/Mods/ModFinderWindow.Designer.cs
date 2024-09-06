namespace FNModLauncher.Mods
{
    partial class ModFinderWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModFinderWindow));
            this.modsBox = new System.Windows.Forms.ListBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.installModButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modsBox
            // 
            this.modsBox.FormattingEnabled = true;
            this.modsBox.Location = new System.Drawing.Point(12, 12);
            this.modsBox.Name = "modsBox";
            this.modsBox.Size = new System.Drawing.Size(206, 290);
            this.modsBox.TabIndex = 1;
            this.modsBox.SelectedIndexChanged += new System.EventHandler(this.modsBox_SelectedIndexChanged);
            // 
            // descLabel
            // 
            this.descLabel.Location = new System.Drawing.Point(12, 305);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(313, 127);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "Description: ";
            this.descLabel.Click += new System.EventHandler(this.descLabel_Click);
            // 
            // installModButton
            // 
            this.installModButton.Location = new System.Drawing.Point(224, 272);
            this.installModButton.Name = "installModButton";
            this.installModButton.Size = new System.Drawing.Size(105, 30);
            this.installModButton.TabIndex = 3;
            this.installModButton.Text = "Install Mod";
            this.installModButton.UseVisualStyleBackColor = true;
            this.installModButton.Click += new System.EventHandler(this.installModButton_Click);
            // 
            // ModFinderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 451);
            this.Controls.Add(this.installModButton);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.modsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModFinderWindow";
            this.Text = "Download Mods";
            this.Load += new System.EventHandler(this.ModFinderWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox modsBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Button installModButton;
    }
}