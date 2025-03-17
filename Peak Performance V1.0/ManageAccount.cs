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
    public partial class ManageAccount : Form
    {
        public ManageAccount()
        {
            InitializeComponent();
        }

        //SUPPORTING EVENT
        private void btnBrowse_Click(object sender, EventArgs e) //SUPPORTING EVENT: Browse and select an image
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picProfilePicture.Image = Image.FromFile(openFileDialog.FileName);
                    lblImagePath.Text = openFileDialog.FileName; //store image path for later use //pwede ra i .visible=false
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e) //SUPPORTING EVENT: Clear all textboxes
        {
            txtFullname.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtBirthday.Text = string.Empty;
            txtLicenseID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            panel5.Text = string.Empty;
            picProfilePicture.Image = null;
            lblImagePath.Text = null;
        }
        private void btnClearPicture_Click(object sender, EventArgs e) //SUPPORTING EVENT: Clear picture
        {
            picProfilePicture.Image = null;
            lblImagePath.Text = null;
        }
    }
}