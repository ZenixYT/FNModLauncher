namespace FNModLauncher.Mods
{
    partial class ManageModsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageModsWindow));
            this.modListBox = new System.Windows.Forms.CheckedListBox();
            this.deleteModButton = new System.Windows.Forms.Button();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.findModsButton = new System.Windows.Forms.Button();
            this.refreshModsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modListBox
            // 
            this.modListBox.FormattingEnabled = true;
            this.modListBox.Location = new System.Drawing.Point(12, 12);
            this.modListBox.Name = "modListBox";
            this.modListBox.Size = new System.Drawing.Size(206, 424);
            this.modListBox.TabIndex = 0;
            // 
            // deleteModButton
            // 
            this.deleteModButton.Location = new System.Drawing.Point(224, 406);
            this.deleteModButton.Name = "deleteModButton";
            this.deleteModButton.Size = new System.Drawing.Size(105, 30);
            this.deleteModButton.TabIndex = 1;
            this.deleteModButton.Text = "Delete Mod";
            this.deleteModButton.UseVisualStyleBackColor = true;
            this.deleteModButton.Click += new System.EventHandler(this.deleteModButton_Click);
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(224, 334);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(105, 30);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.Text = "Open Mods Folder";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // findModsButton
            // 
            this.findModsButton.Location = new System.Drawing.Point(224, 298);
            this.findModsButton.Name = "findModsButton";
            this.findModsButton.Size = new System.Drawing.Size(105, 30);
            this.findModsButton.TabIndex = 3;
            this.findModsButton.Text = "Find Mods";
            this.findModsButton.UseVisualStyleBackColor = true;
            this.findModsButton.Click += new System.EventHandler(this.findModsButton_Click);
            // 
            // refreshModsButton
            // 
            this.refreshModsButton.Location = new System.Drawing.Point(224, 370);
            this.refreshModsButton.Name = "refreshModsButton";
            this.refreshModsButton.Size = new System.Drawing.Size(105, 30);
            this.refreshModsButton.TabIndex = 4;
            this.refreshModsButton.Text = "Refresh Mods List";
            this.refreshModsButton.UseVisualStyleBackColor = true;
            this.refreshModsButton.Click += new System.EventHandler(this.refreshModsButton_Click);
            // 
            // ManageModsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 451);
            this.Controls.Add(this.refreshModsButton);
            this.Controls.Add(this.findModsButton);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.deleteModButton);
            this.Controls.Add(this.modListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageModsWindow";
            this.Text = "Manage Mods";
            this.Load += new System.EventHandler(this.ManageModsWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox modListBox;
        private System.Windows.Forms.Button deleteModButton;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.Button findModsButton;
        private System.Windows.Forms.Button refreshModsButton;
    }
}