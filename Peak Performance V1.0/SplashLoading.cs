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
    public partial class SplashLoading : Form
    {
        public SplashLoading()
        {
            InitializeComponent();
            tmrProgress.Start();
        }
        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            if (SystemManager.splash == 1)
            {
                picSplash1.Visible = true;
                picSplash2.Visible = false;
                lblLoading.Text = "Loading...";
                if (ProgressBar.Value == 100)
                {
                    tmrProgress.Stop();
                    MainLR mainLR = new MainLR();
                    mainLR.Show();
                    this.Hide();
                }
                ProgressBar.Value += 1;
            }
            else
            {
                picSplash1.Visible = false;
                picSplash2.Visible = true;
                lblLoading.Text = "Log-in successful- Preparing vehicles...";
                if (ProgressBar.Value == 100)
                {
                    tmrProgress.Stop();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                ProgressBar.Value += 2;
            }
        }
    }
}
