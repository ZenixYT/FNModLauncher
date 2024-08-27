﻿namespace FNModLauncher
{
    partial class NewInstanceWindow
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
            this.InstanceNameLabel = new System.Windows.Forms.Label();
            this.InstNameBox = new System.Windows.Forms.TextBox();
            this.addArgsBox = new System.Windows.Forms.TextBox();
            this.AddArgsLabel = new System.Windows.Forms.Label();
            this.fnDirBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PathButton = new System.Windows.Forms.Button();
            this.AddInstanceButton = new System.Windows.Forms.Button();
            this.ModsPathButton = new System.Windows.Forms.Button();
            this.modsPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstanceNameLabel
            // 
            this.InstanceNameLabel.AutoSize = true;
            this.InstanceNameLabel.Location = new System.Drawing.Point(12, 16);
            this.InstanceNameLabel.Name = "InstanceNameLabel";
            this.InstanceNameLabel.Size = new System.Drawing.Size(38, 13);
            this.InstanceNameLabel.TabIndex = 0;
            this.InstanceNameLabel.Text = "Name:";
            // 
            // InstNameBox
            // 
            this.InstNameBox.Location = new System.Drawing.Point(56, 9);
            this.InstNameBox.Name = "InstNameBox";
            this.InstNameBox.Size = new System.Drawing.Size(328, 20);
            this.InstNameBox.TabIndex = 1;
            // 
            // addArgsBox
            // 
            this.addArgsBox.Location = new System.Drawing.Point(130, 39);
            this.addArgsBox.Name = "addArgsBox";
            this.addArgsBox.Size = new System.Drawing.Size(254, 20);
            this.addArgsBox.TabIndex = 3;
            // 
            // AddArgsLabel
            // 
            this.AddArgsLabel.AutoSize = true;
            this.AddArgsLabel.Location = new System.Drawing.Point(12, 42);
            this.AddArgsLabel.Name = "AddArgsLabel";
            this.AddArgsLabel.Size = new System.Drawing.Size(112, 13);
            this.AddArgsLabel.TabIndex = 2;
            this.AddArgsLabel.Text = "Additional Arguments: ";
            // 
            // fnDirBox
            // 
            this.fnDirBox.Location = new System.Drawing.Point(88, 65);
            this.fnDirBox.Name = "fnDirBox";
            this.fnDirBox.Size = new System.Drawing.Size(263, 20);
            this.fnDirBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fortnite Path:";
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(360, 64);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(26, 20);
            this.PathButton.TabIndex = 6;
            this.PathButton.Text = "...";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // AddInstanceButton
            // 
            this.AddInstanceButton.Location = new System.Drawing.Point(278, 119);
            this.AddInstanceButton.Name = "AddInstanceButton";
            this.AddInstanceButton.Size = new System.Drawing.Size(106, 23);
            this.AddInstanceButton.TabIndex = 7;
            this.AddInstanceButton.Text = "Add Instance";
            this.AddInstanceButton.UseVisualStyleBackColor = true;
            this.AddInstanceButton.Click += new System.EventHandler(this.AddInstanceButton_Click);
            // 
            // ModsPathButton
            // 
            this.ModsPathButton.Location = new System.Drawing.Point(360, 90);
            this.ModsPathButton.Name = "ModsPathButton";
            this.ModsPathButton.Size = new System.Drawing.Size(26, 20);
            this.ModsPathButton.TabIndex = 10;
            this.ModsPathButton.Text = "...";
            this.ModsPathButton.UseVisualStyleBackColor = true;
            this.ModsPathButton.Click += new System.EventHandler(this.ModsPathButton_Click);
            // 
            // modsPathBox
            // 
            this.modsPathBox.Location = new System.Drawing.Point(79, 91);
            this.modsPathBox.Name = "modsPathBox";
            this.modsPathBox.Size = new System.Drawing.Size(272, 20);
            this.modsPathBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mods Path:";
            // 
            // NewInstanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 154);
            this.Controls.Add(this.ModsPathButton);
            this.Controls.Add(this.modsPathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddInstanceButton);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.fnDirBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addArgsBox);
            this.Controls.Add(this.AddArgsLabel);
            this.Controls.Add(this.InstNameBox);
            this.Controls.Add(this.InstanceNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewInstanceWindow";
            this.Text = "Add New Build";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstanceNameLabel;
        private System.Windows.Forms.TextBox InstNameBox;
        private System.Windows.Forms.TextBox addArgsBox;
        private System.Windows.Forms.Label AddArgsLabel;
        private System.Windows.Forms.TextBox fnDirBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Button AddInstanceButton;
        private System.Windows.Forms.Button ModsPathButton;
        private System.Windows.Forms.TextBox modsPathBox;
        private System.Windows.Forms.Label label2;
    }
}