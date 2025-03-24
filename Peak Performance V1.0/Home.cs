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
using System.Runtime.InteropServices;
using System.Diagnostics.Metrics;
using System.Data.OleDb;


namespace Peak_Performance_V1._0
{
    
    public partial class Home : Form
    {
        private OleDbConnection connection;
        public Home()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadUsers();
            LoadVehicles();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            tmrFadeIn.Start();

            //set icon sizes
            btnHome.Image = SystemManager.ResizeImage(Properties.Resources.Home);
            btnAllVehicles.Image = SystemManager.ResizeImage(Properties.Resources.ViewAll);
            btnRentalDetails.Image = SystemManager.ResizeImage(Properties.Resources.ViewRental);
            btnAddVehicles.Image = SystemManager.ResizeImage(Properties.Resources.AddVehicle);
            btnUpdateVehicles.Image = SystemManager.ResizeImage(Properties.Resources.EditVehicle);
            btnManageAccount.Image = SystemManager.ResizeImage(Properties.Resources.ManageAccount);
            btnLogout.Image = SystemManager.ResizeImage(Properties.Resources.Back2);
            btnExit.Image = SystemManager.ResizeImage(Properties.Resources.ExitHome);
            btnAdminAllVehicles.Image = SystemManager.ResizeImage(Properties.Resources.Car___MainLR);
            btnAdminAllUsers.Image = SystemManager.ResizeImage(Properties.Resources.Username);

            //set time and date
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("HH:mm:ss");
            lblDate.Text = now.ToString("MMMM dd, yyyy");
            lblDay.Text = now.ToString("dddd");
            //lblTime.Left = (pnlForm.Width - lblTime.Width) / 2;
            //lblDate.Left = (pnlForm.Width - lblDate.Width) / 2;
            //lblDay.Left = (pnlForm.Width - lblDay.Width) / 2;
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
                }

                picDay.Visible = false;
                picNight.Visible = true;
            }

            //set form layout and colors
            btnHome.BackColor = Color.FromArgb(255, 128, 0);
            btnHome.FlatAppearance.BorderSize = 2;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            lblGreetings.Text = $"Hello {SystemManager.currentUsername}!";
            lblGreetings.Left = (pnlForm.Width - lblGreetings.Width) / 2;
            lblUsername.Text = $"{SystemManager.currentUsername}";
            lblRole.Text = $"{SystemManager.currentRole}";

            //set side menu buttons visibility
            if (SystemManager.currentRole == "Vehicle Provider")
            {
                btnAdminAllVehicles.Visible = false;
                btnAdminAllUsers.Visible = false;

                btnRentals.Visible = true;
                btnAllVehicles.Visible = true;
                btnRentalDetails.Visible = true;

                btnVehicles.Visible = true;
                btnAddVehicles.Visible = true;
                btnUpdateVehicles.Visible = true;

                btnAccount.Visible = true;
                btnManageAccount.Visible = true;
            }
            else if (SystemManager.currentRole == "Client")
            {
                btnAdminAllVehicles.Visible = false;
                btnAdminAllUsers.Visible = false;

                btnRentals.Visible = true;
                btnAllVehicles.Visible = true;
                btnRentalDetails.Visible = true;

                btnVehicles.Visible = false;
                btnAddVehicles.Visible = false;
                btnUpdateVehicles.Visible = false;

                btnAccount.Visible = true;
                btnManageAccount.Visible = true;
            }
            else //admin
            {
                btnAdminAllVehicles.Visible = true;
                btnAdminAllUsers.Visible = true;

                btnRentals.Visible = false;
                btnAllVehicles.Visible = false;
                btnRentalDetails.Visible = false;

                btnVehicles.Visible = false;
                btnAddVehicles.Visible = false;
                btnUpdateVehicles.Visible = false;

                btnAccount.Visible = false;
                btnManageAccount.Visible = false;
            }
        }
        private void LoadUsers() //INITIAL EVENT: Load the vehicle cards
        {
            flpDisplayUsers.Controls.Clear();

            string displayQuery = "SELECT Username, ProfilePicture FROM Users";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string? username = reader["Username"].ToString();


                    //convert image from database to PictureBox
                    Image? userImage = null;
                    if (!Convert.IsDBNull(reader["ProfilePicture"])) //check if image is not NULL
                    {
                        byte[] imageData = (byte[])reader["ProfilePicture"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            userImage = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        //set a default placeholder image
                    }


                    //create a TopProviderCard and add it to the FlowLayoutPanel
                    TopProviderCard card = new TopProviderCard(username, userImage);
                    flpDisplayUsers.Controls.Add(card);
                }
                connection.Close();
            }
        }
        private void LoadVehicles() //INITIAL EVENT: Load the vehicle cards
        {
            flpDisplayVehicles.Controls.Clear();

            string displayQuery = "SELECT GeneralType, SpecificType, Make, Model, VehicleYear, VehicleImage FROM Vehicles";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string? generalType = reader["GeneralType"].ToString();
                    string? specificType = reader["SpecificType"].ToString();
                    string? make = reader["Make"].ToString();

                    string? model = reader["Model"].ToString();
                    int vehicleYear = Convert.ToInt32(reader["VehicleYear"]);

                    //convert image from database to PictureBox
                    Image? vehicleImage = null;
                    if (!Convert.IsDBNull(reader["VehicleImage"])) //check if image is not NULL
                    {
                        byte[] imageData = (byte[])reader["VehicleImage"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            vehicleImage = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        //set a default placeholder image
                    }

                    TopVehicleCard card = new TopVehicleCard(generalType, specificType, make, model, vehicleYear, vehicleImage);
                    flpDisplayVehicles.Controls.Add(card);
                }
            }
        }

        //MAIN EVENT
        private Form activeForm = null;
        private void openChildForm(Form childForm) //MAIN EVENT: Display child forms
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

        //SUPPORTING METHOD
        private void ResetButtonColors() //SUPPORTING METHOD: Change colors
        {
            foreach (System.Windows.Forms.Button btn in new System.Windows.Forms.Button[] { btnHome, btnAllVehicles, btnRentalDetails, btnAddVehicles, btnUpdateVehicles, btnManageAccount, btnLogout, btnExit, btnAdminAllVehicles, btnAdminAllUsers })
            {
                btn.BackColor = Color.FromArgb(45, 60, 75);
                btn.FlatAppearance.BorderSize = 0;
            }
        }

        //EVENT: Form navigation
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
            if (SystemManager.currentRole == "Client")
                openChildForm(new ClientViewRental());
            else if (SystemManager.currentRole == "Vehicle Provider")
                openChildForm(new ProviderViewRental());
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
            openChildForm(new ManageAccount(this));
        }
        private void btnAdminAllVehicles_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnAdminAllVehicles.BackColor = Color.FromArgb(255, 128, 0);
            btnAdminAllVehicles.FlatAppearance.BorderSize = 2;
            btnAdminAllVehicles.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            openChildForm(new AdminAllVehicles());
        }
        private void btnAdminAllUsers_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnAdminAllUsers.BackColor = Color.FromArgb(255, 128, 0);
            btnAdminAllUsers.FlatAppearance.BorderSize = 2;
            btnAdminAllUsers.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            openChildForm(new AdminAllUsers());
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
                btnLogout.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
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
                btnExit.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            }
        }

        //SUPPORTING EVENTS
        private void tmrClock_Tick(object sender, EventArgs e) //SUPPORTING EVENT: Refresh the time and images every second
        {
            //int scrollPos = pnlSideMenu.VerticalScroll.Value; // Save scroll position
            //pnlSideMenu.SuspendLayout(); // Temporarily stop UI updates

            //update the label with the current date and time
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("HH:mm:ss");
            lblDate.Text = now.ToString("MMMM dd,yyyy");
            lblDay.Text = now.ToString("dddd");

            //lblTime.Left = (pnlForm.Width - lblTime.Width) / 2;
            //lblDate.Left = (pnlForm.Width - lblDate.Width) / 2;
            //lblDay.Left = (pnlForm.Width - lblDay.Width) / 2;

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

            if (lblGreetings.Width <= 600)
                lblGreetings.Text = $"Hello {SystemManager.currentUsername}!";
            else
                lblGreetings.Text = $"Hello {SystemManager.currentUsername}! What would you like to do today?";


            //pnlSideMenu.ResumeLayout(); // Resume layout updates
            //pnlSideMenu.PerformLayout();
            // Restore scroll position
            //pnlSideMenu.AutoScrollPosition = new Point(0, scrollPos);
        }
        private void picMin_Click(object sender, EventArgs e) //SUPPORTING EVENT: Maximize
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void picMax_Click(object sender, EventArgs e) //SUPPORTING EVENT: Minimize
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void btnRentals_Click(object sender, EventArgs e) //SUPPORTING EVENT: Sidemenu
        {
            bool isVisible = !btnAllVehicles.Visible;
            btnAllVehicles.Visible = isVisible;
            btnRentalDetails.Visible = isVisible;
        }
        private void btnVehicles_Click(object sender, EventArgs e) //SUPPORTING EVENT: Sidemenu
        {
            bool isVisible = !btnAddVehicles.Visible;
            btnAddVehicles.Visible = isVisible;
            btnUpdateVehicles.Visible = isVisible;
        }
        private void btnAccount_Click(object sender, EventArgs e) //SUPPORTING EVENT: Sidemenu
        {
            bool isVisible = !btnManageAccount.Visible;
            btnManageAccount.Visible = isVisible;
            btnLogout.Visible = isVisible;
        }
        private void tmrFadeIn_Tick(object sender, EventArgs e) //SUPPORTING EVENT: Fade in animation
        {
            Opacity += 0.02;
            if (Opacity >= 1) // Fully visible
            {
                tmrFadeIn.Stop(); // Stop the timer
            }
        }
        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private void pnlTop_MouseDown(object sender, MouseEventArgs e) //SUPPORTING EVENT: Draggable Panel
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
