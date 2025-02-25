using Microsoft.VisualBasic;
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
                addRentableVehicleToolStripMenuItem.Visible = true;
                updateVehiclesToolStripMenuItem.Visible = true;
            }
            else if (SystemManager.currentRole == "Client")
            {
                addRentableVehicleToolStripMenuItem.Visible = false;
                updateVehiclesToolStripMenuItem.Visible = false;
            }
            else
            {
                //admin
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e) //SUPPORTING EVENT to refresh the time and images every second
        {
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
        }

        private void viewAllVehiclesToolStripMenuItem_Click(object sender, EventArgs e) //MENUSTRIP EVENT 1 both
        {
            ViewAllVehicles view = new ViewAllVehicles();
            view.Show();
            this.Hide();
        }

        private void viewRentalDetailsToolStripMenuItem_Click(object sender, EventArgs e) //MENUSTRIP EVENT 2 both
        {

        }

        private void addRentableVehicleToolStripMenuItem_Click(object sender, EventArgs e) //MENUSTRIP EVENT 3 provider specific
        {
            ProviderAddVehicle addVehicle = new ProviderAddVehicle();
            addVehicle.Show();
            this.Hide();
        }

        private void updateVehiclesToolStripMenuItem_Click(object sender, EventArgs e) //MENUSTRIP EVENT 4 provider specific
        {
            ProviderEditVehicle edit = new ProviderEditVehicle();
            edit.Show();
            this.Hide();
        }

        private void manageAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e) //MENUSTRIP EVENT 5 both
        {
            ManageAccount manage = new ManageAccount();
            manage.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e) //MENUSTRIP EVENT 6 both
        {
            MainLR home = new MainLR();
            home.Show();
            this.Hide();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e) //MENUSTRIP EVENT 7 both
        {
            Application.Exit();
        }

    }
}
