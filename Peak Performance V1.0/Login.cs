using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //added for database connection
using System.Security.Cryptography;

namespace Peak_Performance_V1._0
{
    public partial class Login : Form
    {
        private OleDbConnection connection;

        public Login()
        {
            InitializeComponent();
            string dbPath = @"|DataDirectory|\PeakPerformanceDB.accdb"; //path to the database
            connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;");
            txtPassword.PasswordChar = '*'; //hide password by default
        }

        private void btnLogin_Click(object sender, EventArgs e) //MAIN EVENT for Login
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) //check if username and password are empty
            {
                MessageBox.Show("Username and Password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashPassword = Methods.HashPassword(password);
            string validateQuery = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";

            using (OleDbCommand cmd = new OleDbCommand(validateQuery, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashPassword);

                try
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show($"Login Successful! Role: {role}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        /*
                        if (role == "Provider")
                        {
                            ProviderDashboard providerForm = new ProviderDashboard();
                            providerForm.Show();
                        }
                        else if (role == "Client")
                        {
                            ClientDashboard providerForm = new ClientDashboard();
                            ClientForm.Show();
                        }
                        else
                        {
                            AdminDashboard providerForm = new AdminDashboard();
                            AdminForm.Show();
                        }
                        */
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e) //SUPPORTING EVENT to show/hide password
        {
            if (chkShowPass.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void lblGoToR_Click(object sender, EventArgs e) //EVENT to go back to Login
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}