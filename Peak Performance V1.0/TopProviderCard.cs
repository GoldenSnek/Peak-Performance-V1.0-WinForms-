﻿using System;
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
    public partial class TopProviderCard : UserControl
    {
        public TopProviderCard(string username, Image userImage, double userRating)
        {
            InitializeComponent();

            lblName.Text = username;
            if (userImage != null)
                picUser.Image = userImage;
            else
                picUser.Image = Properties.Resources.Username;

            lblRating.Text = userRating.ToString();
        }
    }
}
