using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peak_Performance_V1._0
{
    public partial class ClientFeedback : Form
    {
        OleDbConnection connection;
        public ClientFeedback()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicleComments(SystemManager.currentCommentsVehicleID);
        }

        public void LoadVehicleComments(int vehicleID)
        {
            flpComments.Controls.Clear(); // Clear existing comments first

            string query = "SELECT Username, Comments, DateSubmitted FROM VehicleFeedback WHERE VehicleID = @vehicleID ORDER BY DateSubmitted DESC";

            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@vehicleID", vehicleID);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string username = reader["Username"].ToString();
                        string comment = reader["Comments"].ToString();
                        DateTime date = Convert.ToDateTime(reader["DateSubmitted"]);

                        // Create and add a comment panel
                        flpComments.Controls.Add(CreateCommentCard(username, comment, date));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading comments: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private Panel CreateCommentCard(string username, string comment, DateTime date)
        {
            Panel panel = new Panel();
            panel.Width = flpComments.Width - 10;
            panel.Height = 80;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Margin = new Padding(5);
            panel.BackColor = Color.Lavender;

            // Username Label
            Label lblUser = new Label();
            lblUser.Text = username + " • " + date.ToShortDateString();
            lblUser.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
            lblUser.AutoSize = true;
            lblUser.Location = new Point(10, 10);

            // Comment Label
            Label lblComment = new Label();
            lblComment.Text = comment;
            lblComment.Font = new Font("Cascadia Code", 9);
            lblComment.MaximumSize = new Size(panel.Width - 20, 0);
            lblComment.AutoSize = true;
            lblComment.Location = new Point(10, 30);

            // Add to panel
            panel.Controls.Add(lblUser);
            panel.Controls.Add(lblComment);

            return panel;
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

        private void picBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
