using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace File_Renamer
{
    public partial class verifyNoDirectory : Form
    {

        public bool oktoProceed;

        public verifyNoDirectory()
        {
            InitializeComponent();
        }

        private void verifyOkButton_Click(Object s, EventArgs args)
        {
            oktoProceed = true;
            this.Close();
            
        }

        private void cancelButton_Click(Object s, EventArgs args)
        {
            oktoProceed = false;
            this.Close();
            
        }
    }
}
