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
    public partial class ProviderMain : Form
    {
        public ProviderMain()
        {
            InitializeComponent();
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
    }
}
