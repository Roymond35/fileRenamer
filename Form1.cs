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

            //Checking if directory exists
            try
            {
                if (!Directory.Exists(fD))
                {
                    throw new DirectoryNotFoundException();
                }
                else
                {
                    dirExists = true;
                }
            }
            catch (DirectoryNotFoundException errorHandling) //To catch the directory not existing.
            {
                messageDelivery.Text = "Directory does not exist, using current directory";
                fD = Directory.GetCurrentDirectory();
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
            
            //Checking the third parameter
            int filesProcessed = rename(fD, fE, fP);
            if (extValid && dirExists)
            {
                messageDelivery.Text = filesProcessed.ToString() + " files processed";
            }
        }

        private void resetButton_Click(Object sender, EventArgs e)
        {
            fileDirectory.Text = String.Empty;
            fileExtension.Text = String.Empty;
            filePrefix.Text = String.Empty;
            messageDelivery.Text = String.Empty;
        }

        private void exitToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
