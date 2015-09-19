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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileExtension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filePrefix = new System.Windows.Forms.TextBox();
            this.runUtility = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.messageDelivery = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aboutToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new EventHandler(this.resetButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new EventHandler(exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory";
            // 
            // fileDirectory
            // 
            this.fileDirectory.Location = new System.Drawing.Point(108, 50);
            this.fileDirectory.Name = "fileDirectory";
            this.fileDirectory.Size = new System.Drawing.Size(164, 20);
            this.fileDirectory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Extension";
            // 
            // fileExtension
            // 
            this.fileExtension.Location = new System.Drawing.Point(108, 76);
            this.fileExtension.Name = "fileExtension";
            this.fileExtension.Size = new System.Drawing.Size(164, 20);
            this.fileExtension.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "File Prefix";
            // 
            // filePrefix
            // 
            this.filePrefix.Location = new System.Drawing.Point(108, 107);
            this.filePrefix.Name = "filePrefix";
            this.filePrefix.Size = new System.Drawing.Size(164, 20);
            this.filePrefix.TabIndex = 6;
            // 
            // runUtility
            // 
            this.runUtility.Location = new System.Drawing.Point(108, 162);
            this.runUtility.Name = "runUtility";
            this.runUtility.Size = new System.Drawing.Size(75, 23);
            this.runUtility.TabIndex = 7;
            this.runUtility.Text = "Run Utility";
            this.runUtility.UseVisualStyleBackColor = true;
            this.runUtility.Click += new System.EventHandler(this.runUtility_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(108, 192);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // messageDelivery
            // 
            this.messageDelivery.AutoSize = true;
            this.messageDelivery.Location = new System.Drawing.Point(12, 240);
            this.messageDelivery.Name = "messageDelivery";
            this.messageDelivery.Size = new System.Drawing.Size(0, 13);
            this.messageDelivery.TabIndex = 9;
            this.messageDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.messageDelivery);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.runUtility);
            this.Controls.Add(this.filePrefix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileExtension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainPage";
            this.Text = "The Simple File Renamer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileExtension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filePrefix;
        private System.Windows.Forms.Button runUtility;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label messageDelivery;
    }
}

