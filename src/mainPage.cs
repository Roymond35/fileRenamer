using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace File_Renamer
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private static int rename(string fD, string fE, string fP)
        {
            fD += @"\";
            int i = 1;
            var filesMatched = Directory.EnumerateFiles(fD, "*" + fE);
            int preceedingZeros = filesMatched.Count<String>().ToString().Length;
            foreach (String file in filesMatched)
            {
                string oldFileName = file.Substring(fD.Length);
                string newFileName = fP + i.ToString("D" + preceedingZeros.ToString("D")) + fE;
                try
                {
                    File.Move(fD + oldFileName, fD + newFileName);
                    i++;
                }
                catch (IOException e)
                {
                    //TODO: Figure out if anything NEEDS to be done;
                }


            }
            return filesMatched.Count<String>();
        }


        private void runUtility_Click(Object sender, EventArgs e)
        {
            //Gathers the variables
            string fD = fileDirectory.Text;
            string fE = fileExtension.Text;
            string fP = filePrefix.Text;
            bool dirExists = false;
            bool extValid = false;
            bool userOK = true;

            //Checking if directory exists
            if (!Directory.Exists(fD) || String.IsNullOrEmpty(fD))
            {
                verifyNoDirectory noDirProvided = new verifyNoDirectory();
                noDirProvided.ShowDialog();
                userOK = noDirProvided.oktoProceed;
                if (userOK)
                {
                    dirExists = true;
                    fD = Directory.GetCurrentDirectory();
                }
            }
            else
            {
                dirExists = true;
            }


            //Checking the file Extension
            try
            {
                if (!String.IsNullOrEmpty(fE))
                {
                    //If the extension doesn't have an inital period, add it.
                    //If it does, no need to add it.
                    if (fE.IndexOf('.') == -1)
                    {
                        fE = fE.Insert(0, ".");
                    }
                    extValid = true;
                }
                else
                {
                    throw new Exception("No Extension Provided.");
                }
            }
            catch (Exception errorHandling)
            {
                messageDelivery.Text = "No File Extension provided. Aborting.";
            }


            if (extValid && dirExists)
            {
                int filesProcessed = rename(fD, fE, fP);
                messageDelivery.Text = filesProcessed.ToString() + " files processed";
            }
            else if (!userOK)
            {
                messageDelivery.Text = "User Aborted!";
            }
        }

        private void resetButton_Click(Object sender, EventArgs e)
        {
            fileDirectory.Text = String.Empty;
            fileExtension.Text = String.Empty;
            filePrefix.Text = String.Empty;
            messageDelivery.Text = String.Empty;
            this.Size = new System.Drawing.Size(375, 300);
        }

        private void quit_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void about_Click(Object sender, EventArgs e)
        {
            aboutMenu about = new aboutMenu();
            about.Show();
        }

        private void browseButton_Click(Object sender, EventArgs e)
        {
            FolderBrowserDialog fdlg = new FolderBrowserDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileDirectory.Text = fdlg.SelectedPath;
            }
        }
    }
}
