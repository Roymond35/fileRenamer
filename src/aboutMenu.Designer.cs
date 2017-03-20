using System;
namespace File_Renamer
{
    partial class aboutMenu
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
            this.titleBar = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.versionData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createdBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.AutoSize = true;
            this.titleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.Location = new System.Drawing.Point(13, 9);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(259, 24);
            this.titleBar.TabIndex = 0;
            this.titleBar.Text = "Welcome to File Renamer!";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(14, 227);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(257, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // versionData
            // 
            this.versionData.AutoSize = true;
            this.versionData.Location = new System.Drawing.Point(14, 211);
            this.versionData.Name = "versionData";
            this.versionData.Size = new System.Drawing.Size(60, 13);
            this.versionData.TabIndex = 2;
            this.versionData.Text = "Version 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "The purpose of this program was to be an exercise\r\n in creating a GUI.\r\n";
            // 
            // createdBy
            // 
            this.createdBy.AutoSize = true;
            this.createdBy.Location = new System.Drawing.Point(48, 56);
            this.createdBy.Name = "createdBy";
            this.createdBy.Size = new System.Drawing.Size(189, 13);
            this.createdBy.TabIndex = 4;
            this.createdBy.Text = "This program was written by Roy Gero.";
            this.createdBy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aboutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.createdBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.versionData);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleBar);
            this.Name = "aboutMenu";
            this.Text = "About - File Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleBar;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label versionData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label createdBy;
    }
}