using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        private void About_Load(object sender, EventArgs e)
        {
            tmrFadeIn.Start();
        }

        //EVENTS: Form navigation
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

        //SUPPORTING EVENT
        private void tmrFadeIn_Tick(object sender, EventArgs e) //SUPPORTING EVENT: Fade in animation
        {
            Opacity += 0.02;
            if (Opacity >= 1)
                tmrFadeIn.Stop();
        }

        private void picFB_Click(object sender, EventArgs e)
        {
            SystemManager.OpenURL("https://www.facebook.com/jm.nave.1/");
        }

        private void picGithub_Click(object sender, EventArgs e)
        {
            SystemManager.OpenURL("https://github.com/GoldenSnek");
        }

        private void picDiscord_Click(object sender, EventArgs e)
        {
            SystemManager.OpenURL("https://discord.com/users/546196480143392768");
        }
    }
}