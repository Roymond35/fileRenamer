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
            int i = 0;
            var filesMatched = Directory.EnumerateFiles(fD, "*" + fE);
            int preceedingZeros = filesMatched.Count<String>().ToString().Length;
            foreach (String file in filesMatched)
            {
                string oldFileName = file.Substring(fD.Length);
                string newFileName = fP + i.ToString("D" + preceedingZeros.ToString()) + fE;
                File.Move(fD + oldFileName, fD + newFileName);
                i++;

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
            bool userOK = false;

            //Checking if directory exists
            if ( !Directory.Exists(fD) || String.IsNullOrEmpty(fD) )
            {
                verifyNoDirectory noDirProvided = new verifyNoDirectory();
                noDirProvided.ShowDialog();
                userOK = noDirProvided.oktoProceed;
                messageDelivery.Text = "We entered this code Path";
                if (userOK)
                {
                    dirExists = true;
                    fD = Directory.GetCurrentDirectory();
                }
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
            this.Size = new System.Drawing.Size(300, 300);
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
    }
}
