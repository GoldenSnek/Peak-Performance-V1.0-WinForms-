﻿using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peak_Performance_V1._0
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            MainLR mainLR = new MainLR();
            mainLR.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
