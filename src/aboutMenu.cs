﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace File_Renamer
{
    public partial class aboutMenu : Form
    {
        public aboutMenu()
        {
            InitializeComponent();
        }

        private void closeButton_Click(Object obj, EventArgs args)
        {
            this.Close();
        }
    }
}
