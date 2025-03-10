using Microsoft.VisualBasic;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Peak_Performance_V1._0
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e) //INITIAL EVENT to load the time and images
        {
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("HH:mm:ss");
            lblDate.Text = now.ToString("MMMM dd,yyyy");
            lblDay.Text = now.ToString("dddd");

            string hours = now.ToString("HH");
            if (int.TryParse(hours, out int hour))
            {
                if (hour >= 0 && hour < 18)
                {
                    picDay.Visible = true;
                    picNight.Visible = false;
                }
                else
                {
                    picDay.Visible = false;
                    picNight.Visible = true;
                }
            }

            lblGreetings.Text = $"Hello {SystemManager.currentUsername}! What would you like to do today? <{SystemManager.currentRole}>";

            if (SystemManager.currentRole == "Vehicle Provider")
            {
                //addRentableVehicleToolStripMenuItem.Visible = true;
                //updateVehiclesToolStripMenuItem.Visible = true;
            }
            else if (SystemManager.currentRole == "Client")
            {
                //addRentableVehicleToolStripMenuItem.Visible = false;
                //updateVehiclesToolStripMenuItem.Visible = false;
            }
            else
            {
                //admin
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(childForm);
            pnlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void tmrClock_Tick(object sender, EventArgs e) //SUPPORTING EVENT to refresh the time and images every second
        {
            int scrollPos = pnlSideMenu.VerticalScroll.Value; // Save scroll position
            pnlSideMenu.SuspendLayout(); // Temporarily stop UI updates

            //update the label with the current date and time
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("HH:mm:ss");
            lblDate.Text = now.ToString("MMMM dd,yyyy");
            lblDay.Text = now.ToString("dddd");

            //setup day/night images
            string hours = now.ToString("HH");
            if (int.TryParse(hours, out int hour))
            {
                if (hour >= 0 && hour < 18)
                {
                    picDay.Visible = true;
                    picNight.Visible = false;
                }
                else
                {
                    picDay.Visible = false;
                    picNight.Visible = true;
                }
            }

            pnlSideMenu.ResumeLayout(); // Resume layout updates
            pnlSideMenu.PerformLayout();
            // Restore scroll position
            pnlSideMenu.AutoScrollPosition = new Point(0, scrollPos);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void btnAllVehicles_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewAllVehicles());
        }

        private void btnRentalDetails_Click(object sender, EventArgs e)
        {
            //openChildForm(new ClientViewRental());
            //openChildForm(new ProviderViewRental());
        }

        private void btnAddVehicles_Click(object sender, EventArgs e)
        {
            openChildForm(new ProviderAddVehicle());
        }

        private void btnUpdateVehicles_Click(object sender, EventArgs e)
        {
            openChildForm(new ProviderEditVehicle());
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageAccount());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (btnLogout.BackColor == Color.Red)
            {
                MainLR mainLR = new MainLR();
                mainLR.Show();
                this.Hide();
            }
            else
                btnLogout.BackColor = Color.Red;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            

            if (btnExit.BackColor == Color.Red)
                Application.Exit();
            else
                btnExit.BackColor = Color.Red;
        }

        private void picMin_Click(object sender, EventArgs e)
        { 
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}
