﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "text|*.txt | document | *.doc | portavel | *.pdf";
            if (saveFile.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = saveFile.FileName;
            }
        }
    }
}
