using System;

namespace File_Renamer
{
    partial class mainPage
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileOption = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDirLabel = new System.Windows.Forms.Label();
            this.fileDirectory = new System.Windows.Forms.TextBox();
            this.fileExtLabel = new System.Windows.Forms.Label();
            this.fileExtension = new System.Windows.Forms.TextBox();
            this.filePrefixLabel = new System.Windows.Forms.Label();
            this.filePrefix = new System.Windows.Forms.TextBox();
            this.runUtility = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.messageDelivery = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOption,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(479, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileOption
            // 
            this.fileOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileOption.Name = "fileOption";
            this.fileOption.Size = new System.Drawing.Size(44, 24);
            this.fileOption.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.quit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about_Click);
            // 
            // fileDirLabel
            // 
            this.fileDirLabel.AutoSize = true;
            this.fileDirLabel.Location = new System.Drawing.Point(28, 66);
            this.fileDirLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileDirLabel.Name = "fileDirLabel";
            this.fileDirLabel.Size = new System.Drawing.Size(65, 17);
            this.fileDirLabel.TabIndex = 1;
            this.fileDirLabel.Text = "Directory";
            // 
            // fileDirectory
            // 
            this.fileDirectory.Location = new System.Drawing.Point(129, 62);
            this.fileDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileDirectory.Name = "fileDirectory";
            this.fileDirectory.Size = new System.Drawing.Size(217, 22);
            this.fileDirectory.TabIndex = 2;
            // 
            // fileExtLabel
            // 
            this.fileExtLabel.AutoSize = true;
            this.fileExtLabel.Location = new System.Drawing.Point(28, 101);
            this.fileExtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileExtLabel.Name = "fileExtLabel";
            this.fileExtLabel.Size = new System.Drawing.Size(95, 17);
            this.fileExtLabel.TabIndex = 3;
            this.fileExtLabel.Text = "File Extension";
            // 
            // fileExtension
            // 
            this.fileExtension.Location = new System.Drawing.Point(131, 96);
            this.fileExtension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileExtension.Name = "fileExtension";
            this.fileExtension.Size = new System.Drawing.Size(217, 22);
            this.fileExtension.TabIndex = 4;
            // 
            // filePrefixLabel
            // 
            this.filePrefixLabel.AutoSize = true;
            this.filePrefixLabel.Location = new System.Drawing.Point(28, 135);
            this.filePrefixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filePrefixLabel.Name = "filePrefixLabel";
            this.filePrefixLabel.Size = new System.Drawing.Size(69, 17);
            this.filePrefixLabel.TabIndex = 5;
            this.filePrefixLabel.Text = "File Prefix";
            // 
            // filePrefix
            // 
            this.filePrefix.Location = new System.Drawing.Point(131, 130);
            this.filePrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filePrefix.Name = "filePrefix";
            this.filePrefix.Size = new System.Drawing.Size(217, 22);
            this.filePrefix.TabIndex = 6;
            // 
            // runUtility
            // 
            this.runUtility.Location = new System.Drawing.Point(57, 236);
            this.runUtility.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runUtility.Name = "runUtility";
            this.runUtility.Size = new System.Drawing.Size(100, 28);
            this.runUtility.TabIndex = 7;
            this.runUtility.Text = "Run Utility";
            this.runUtility.UseVisualStyleBackColor = true;
            this.runUtility.Click += new System.EventHandler(this.runUtility_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(189, 236);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 28);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // messageDelivery
            // 
            this.messageDelivery.AutoSize = true;
            this.messageDelivery.Location = new System.Drawing.Point(16, 295);
            this.messageDelivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageDelivery.Name = "messageDelivery";
            this.messageDelivery.Size = new System.Drawing.Size(0, 17);
            this.messageDelivery.TabIndex = 9;
            this.messageDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(321, 236);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 28);
            this.quitButton.TabIndex = 10;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quit_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(357, 62);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 28);
            this.browseButton.TabIndex = 11;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 322);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.messageDelivery);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.runUtility);
            this.Controls.Add(this.filePrefix);
            this.Controls.Add(this.filePrefixLabel);
            this.Controls.Add(this.fileExtension);
            this.Controls.Add(this.fileExtLabel);
            this.Controls.Add(this.fileDirectory);
            this.Controls.Add(this.fileDirLabel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainPage";
            this.Text = "The Simple File Renamer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileOption;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label fileDirLabel;
        private System.Windows.Forms.TextBox fileDirectory;
        private System.Windows.Forms.Label fileExtLabel;
        private System.Windows.Forms.TextBox fileExtension;
        private System.Windows.Forms.Label filePrefixLabel;
        private System.Windows.Forms.TextBox filePrefix;
        private System.Windows.Forms.Button runUtility;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label messageDelivery;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button browseButton;
    }
}

