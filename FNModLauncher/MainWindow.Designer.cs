﻿namespace FNModLauncher
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
            this.NewBuildButton = new System.Windows.Forms.Button();
            this.ModifyBuildButton = new System.Windows.Forms.Button();
            this.OpenModsButton = new System.Windows.Forms.Button();
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
            this.LaunchButton.Location = new System.Drawing.Point(309, 273);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(105, 30);
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
            // NewBuildButton
            // 
            this.NewBuildButton.Location = new System.Drawing.Point(309, 309);
            this.NewBuildButton.Name = "NewBuildButton";
            this.NewBuildButton.Size = new System.Drawing.Size(105, 30);
            this.NewBuildButton.TabIndex = 4;
            this.NewBuildButton.Text = "Add New Build";
            this.NewBuildButton.UseVisualStyleBackColor = true;
            this.NewBuildButton.Click += new System.EventHandler(this.NewBuildButton_Click);
            // 
            // ModifyBuildButton
            // 
            this.ModifyBuildButton.Location = new System.Drawing.Point(309, 345);
            this.ModifyBuildButton.Name = "ModifyBuildButton";
            this.ModifyBuildButton.Size = new System.Drawing.Size(105, 30);
            this.ModifyBuildButton.TabIndex = 5;
            this.ModifyBuildButton.Text = "Modify Build";
            this.ModifyBuildButton.UseVisualStyleBackColor = true;
            this.ModifyBuildButton.Click += new System.EventHandler(this.ModifyBuildButton_Click);
            // 
            // OpenModsButton
            // 
            this.OpenModsButton.Location = new System.Drawing.Point(309, 401);
            this.OpenModsButton.Name = "OpenModsButton";
            this.OpenModsButton.Size = new System.Drawing.Size(105, 30);
            this.OpenModsButton.TabIndex = 6;
            this.OpenModsButton.Text = "Open Mods Folder";
            this.OpenModsButton.UseVisualStyleBackColor = true;
            this.OpenModsButton.Click += new System.EventHandler(this.OpenModsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 443);
            this.Controls.Add(this.OpenModsButton);
            this.Controls.Add(this.ModifyBuildButton);
            this.Controls.Add(this.NewBuildButton);
            this.Controls.Add(this.InstancesLabel);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.InstancesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = " FNModManager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InstancesBox;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Label InstancesLabel;
        private System.Windows.Forms.Button NewBuildButton;
        private System.Windows.Forms.Button ModifyBuildButton;
        private System.Windows.Forms.Button OpenModsButton;
    }
}

