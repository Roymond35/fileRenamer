using System;
namespace File_Renamer
{
    partial class verifyNoDirectory
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
            this.verifyMessage = new System.Windows.Forms.Label();
            this.verifyOkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verifyMessage
            // 
            this.verifyMessage.AutoSize = true;
            this.verifyMessage.Location = new System.Drawing.Point(12, 9);
            this.verifyMessage.Name = "verifyMessage";
            this.verifyMessage.Size = new System.Drawing.Size(254, 52);
            this.verifyMessage.TabIndex = 0;
            this.verifyMessage.Text = "You did not provide a directory.\r\nThe program will proceeed with the current dire" +
    "ctory.\r\n\r\nClick \"OK\" to Proceed.";
            // 
            // verifyOkButton
            // 
            this.verifyOkButton.Location = new System.Drawing.Point(34, 75);
            this.verifyOkButton.Name = "verifyOkButton";
            this.verifyOkButton.Size = new System.Drawing.Size(75, 23);
            this.verifyOkButton.TabIndex = 1;
            this.verifyOkButton.Text = "OK";
            this.verifyOkButton.UseVisualStyleBackColor = true;
            this.verifyOkButton.Click += new EventHandler(verifyOkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(169, 75);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new EventHandler(cancelButton_Click);
            // 
            // verifyNoDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 108);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.verifyOkButton);
            this.Controls.Add(this.verifyMessage);
            this.Name = "verifyNoDirectory";
            this.Text = "Are you sure?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label verifyMessage;
        private System.Windows.Forms.Button verifyOkButton;
        private System.Windows.Forms.Button cancelButton;
    }
}