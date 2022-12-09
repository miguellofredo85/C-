﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = label1.BackColor;
            button1.BackColor = colorDialog1.Color;
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                label1.BackColor = colorDialog1.Color;
                button1.BackColor = colorDialog1.Color;
            }
        }
    }
}
