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
using ReaLTaiizor.Animate;
using ReaLTaiizor.Animate.Parrot;


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

            btnHome.Image = SystemManager.ResizeImage(Properties.Resources.Home);
            btnAllVehicles.Image = SystemManager.ResizeImage(Properties.Resources.ViewAll);
            btnRentalDetails.Image = SystemManager.ResizeImage(Properties.Resources.ViewRental);
            btnAddVehicles.Image = SystemManager.ResizeImage(Properties.Resources.AddVehicle);
            btnUpdateVehicles.Image = SystemManager.ResizeImage(Properties.Resources.EditVehicle);
            btnManageAccount.Image = SystemManager.ResizeImage(Properties.Resources.ManageAccount);
            btnLogout.Image = SystemManager.ResizeImage(Properties.Resources.Back2);
            btnExit.Image = SystemManager.ResizeImage(Properties.Resources.ExitHome);

            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("HH:mm:ss");
            lblDate.Text = now.ToString("MMMM dd, yyyy");
            lblDay.Text = now.ToString("dddd");

            lblTime.Left = (pnlForm.Width - lblTime.Width) / 2;
            lblDate.Left = (pnlForm.Width - lblDate.Width) / 2;
            lblDay.Left = (pnlForm.Width - lblDay.Width) / 2;

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

            btnHome.BackColor = Color.FromArgb(255, 128, 0);
            btnHome.FlatAppearance.BorderSize = 2;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            lblGreetings.Text = $"Hello {SystemManager.currentUsername}! What would you like to do today?";
            lblGreetings.Left = (pnlForm.Width - lblGreetings.Width) / 2;

            if (SystemManager.currentRole == "Vehicle Provider")
            {
                btnVehicles.Visible = true;
                btnAddVehicles.Visible = true;
                btnUpdateVehicles.Visible = true;
            }
            else if (SystemManager.currentRole == "Client")
            {
                btnVehicles.Visible = false;
                btnAddVehicles.Visible = false;
                btnUpdateVehicles.Visible = false;
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
            //int scrollPos = pnlSideMenu.VerticalScroll.Value; // Save scroll position
            //pnlSideMenu.SuspendLayout(); // Temporarily stop UI updates

            //update the label with the current date and time
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("HH:mm:ss");
            lblDate.Text = now.ToString("MMMM dd,yyyy");
            lblDay.Text = now.ToString("dddd");

            lblTime.Left = (pnlForm.Width - lblTime.Width) / 2;
            lblDate.Left = (pnlForm.Width - lblDate.Width) / 2;
            lblDay.Left = (pnlForm.Width - lblDay.Width) / 2;

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

            //pnlSideMenu.ResumeLayout(); // Resume layout updates
            //pnlSideMenu.PerformLayout();
            // Restore scroll position
            //pnlSideMenu.AutoScrollPosition = new Point(0, scrollPos);
        }

        private void ResetButtonColors()
        {
            foreach (System.Windows.Forms.Button btn in new System.Windows.Forms.Button[] { btnHome, btnAllVehicles, btnRentalDetails, btnAddVehicles, btnUpdateVehicles, btnManageAccount, btnLogout, btnExit })
            {
                btn.BackColor = Color.FromArgb(45, 60, 75);
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnHome.BackColor = Color.FromArgb(255, 128, 0);
            btnHome.FlatAppearance.BorderSize = 2;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);

            if (activeForm != null)
                activeForm.Close();
        }

        private void btnAllVehicles_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnAllVehicles.BackColor = Color.FromArgb(255, 128, 0);
            btnAllVehicles.FlatAppearance.BorderSize = 2;
            btnAllVehicles.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            openChildForm(new ViewAllVehicles());
        }

        private void btnRentalDetails_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnRentalDetails.BackColor = Color.FromArgb(255, 128, 0);
            btnRentalDetails.FlatAppearance.BorderSize = 2;
            btnRentalDetails.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            //openChildForm(new ClientViewRental());
            //openChildForm(new ProviderViewRental());
        }

        private void btnAddVehicles_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnAddVehicles.BackColor = Color.FromArgb(255, 128, 0);
            btnAddVehicles.FlatAppearance.BorderSize = 2;
            btnAddVehicles.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            openChildForm(new ProviderAddVehicle());
        }

        private void btnUpdateVehicles_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnUpdateVehicles.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdateVehicles.FlatAppearance.BorderSize = 2;
            btnUpdateVehicles.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            openChildForm(new ProviderUpdateVehicle());
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnManageAccount.BackColor = Color.FromArgb(255, 128, 0);
            btnManageAccount.FlatAppearance.BorderSize = 2;
            btnManageAccount.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
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
            {
                ResetButtonColors();
                btnLogout.BackColor = Color.Red;
                btnLogout.FlatAppearance.BorderSize = 2;
                btnLogout.FlatAppearance.BorderColor = Color.Maroon;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.BackColor == Color.Red)
                Application.Exit();
            else
            {
                ResetButtonColors();
                btnExit.BackColor = Color.Red;
                btnExit.FlatAppearance.BorderSize = 2;
                btnExit.FlatAppearance.BorderColor = Color.Maroon;
            }
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

        private void picShow_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = true;
            picShow.Visible = false;
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            pnlSideMenu.Visible = false;
            picShow.Visible = true;
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            bool isVisible = !btnAllVehicles.Visible;
            btnAllVehicles.Visible = isVisible;
            btnRentalDetails.Visible = isVisible;
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            bool isVisible = !btnAddVehicles.Visible; // Toggle visibility
            btnAddVehicles.Visible = isVisible;
            btnUpdateVehicles.Visible = isVisible;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            bool isVisible = !btnManageAccount.Visible; // Toggle visibility
            btnManageAccount.Visible = isVisible;
            btnLogout.Visible = isVisible;

        }
    }
}
