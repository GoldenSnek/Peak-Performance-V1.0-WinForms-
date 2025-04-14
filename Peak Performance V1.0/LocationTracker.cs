using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace Peak_Performance_V1._0
{
    public partial class LocationTracker : Form
    {
        //private WebView2 webViewMap;
        public LocationTracker()
        {
            InitializeComponent();
            tmrFadeIn.Start();
        }

        private async void LocationTracker_Load(object sender, EventArgs e)
        {
            try
            {
                await webViewMap.EnsureCoreWebView2Async();
                webViewMap.Source = new Uri("https://maps.app.goo.gl/uXQYpWeZBc7cL6Ks9");
            }
            catch (Exception ex)
            {
                using (ErrorMessage errorForm = new ErrorMessage($"Error: {ex.Message}"))
                {
                    errorForm.ShowDialog();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webViewMap.Reload();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity >= 1)
                tmrFadeIn.Stop();
        }
    }
}