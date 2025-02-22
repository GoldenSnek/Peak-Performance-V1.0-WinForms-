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
using System.Security.Cryptography; //added for password hashing
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;

namespace Peak_Performance_V1._0
{
    public partial class Register : Form
    {
        private OleDbConnection connection = Methods.GetConnection();

        public Register()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*'; //hide password by default
            txtConPass.PasswordChar = '*'; //hide password by default
        }

        private void btnRegister_Click(object sender, EventArgs e) //MAIN EVENT for Register
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = rbtnClient.Checked ? "Client" : "Vehicle Provider";
            string confirmPassword = txtConPass.Text;

            int userCount = 0;
            string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";

            using (OleDbCommand checkCmd = new OleDbCommand(checkUserQuery, connection)) //update userCount
            {
                checkCmd.Parameters.AddWithValue("@username", username);
                connection.Open();
                userCount = (int)checkCmd.ExecuteScalar();
                connection.Close();
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) //step 1: check if username and password are empty
            {
                MessageBox.Show("Username and Password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (userCount > 0) //step 2: check if username already exists
            {
                MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!rbtnClient.Checked && !rbtnProvider.Checked) //step 3: check if role is chosen
            {
                MessageBox.Show("Please choose a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password != confirmPassword) //step 4: extra check if password matches
            {
                MessageBox.Show("Password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashPassword = Methods.HashPassword(password); //hash the password
            string addUserQuery = "INSERT INTO Users (Username, [Password], Role) VALUES (@username, @password, @role)";

            using (OleDbCommand cmd = new OleDbCommand(addUserQuery, connection)) //add the user to the database
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashPassword);
                cmd.Parameters.AddWithValue("@role", role);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lblGoToL_Click(object sender, EventArgs e) //EVENT to go back to Login
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}