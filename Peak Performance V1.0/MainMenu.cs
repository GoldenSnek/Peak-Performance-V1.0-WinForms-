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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("HH:mm:ss");
            lblDate.Text = now.ToString("MMMM dd,yyyy");
            lblDay.Text = now.ToString("dddd");

            lblGreetings.Text = $"Hello {SystemManager.currentUsername}! What would you like to do today?";

            /*
            //initialization of time //unya rani if nana koy pic sa sun and moon
            string hours = now.ToString("HH");
            if (int.TryParse(hours, out int hour))
            {
                if (hour >= 0 && hour < 18)
                {
                    Sun.Visible = true;
                    Moon.Visible = false;
                }
                else
                {
                    Sun.Visible = false;
                    Moon.Visible = true;
                }
            }
            */
        }

        private void addRentableVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProviderAddVehicle addVehicle = new ProviderAddVehicle();
            addVehicle.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewAllVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllVehicles view = new ViewAllVehicles();
            view.Show();
            this.Hide();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            //update the label with the current date and time
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("HH:mm:ss");
            lblDate.Text = now.ToString("MMMM dd,yyyy");
            lblDay.Text = now.ToString("dddd");
        }

        private void updateVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProviderEditVehicle edit = new ProviderEditVehicle();
            edit.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
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
                //manager
            }
        }

        private void manageAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAccount manage = new ManageAccount();
            manage.Show();
            this.Hide();
        }
    }
}
