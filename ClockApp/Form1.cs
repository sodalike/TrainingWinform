﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
       {
       
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("HH:mm:ss");
        }
    }
}
