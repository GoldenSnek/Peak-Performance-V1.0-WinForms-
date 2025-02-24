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
using System.Diagnostics.Eventing.Reader; //added for password hashing

namespace Peak_Performance_V1._0
{
    public partial class Login : Form
    {
        private OleDbConnection connection;

        public Login()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
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

            string hashPassword = SystemManager.HashPassword(password);
            string validateQuery = "SELECT UserID, Role FROM Users WHERE Username = @username AND Password = @password";

            using (OleDbCommand cmd = new OleDbCommand(validateQuery, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashPassword);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // If user exists
                    {
                        int userID = reader.GetInt32(0); // Get UserID
                        string role = reader.GetString(1); // Get Role

                        // Store UserID in a global/static variable
                        SystemManager.currentUserID = userID;

                        MessageBox.Show($"Login Successful! Role: {role}, UserID: {userID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open respective main form based on role
                        if (role == "Vehicle Provider")
                        {
                            ProviderMain provider = new ProviderMain();
                            provider.Show();
                            this.Hide();
                        }
                        else if (role == "Client")
                        {
                            ClientMain client = new ClientMain();
                            client.Show();
                            this.Hide();
                        }
                        /*
                        else if (role == "Admin")
                        {
                            AdminMain admin = new AdminMain();
                            admin.Show();
                            this.Hide();
                        }
                        */
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close(); // Close the reader
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