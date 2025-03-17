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
        private OleDbConnection connection = SystemManager.GetConnection();

        public Register()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•'; //hide password by default
            txtConPass.PasswordChar = '•'; //hide confirm password by default
        }
        private void Register_Load(object sender, EventArgs e)
        {
            tmrFadeIn.Start();
        }

        //MAIN EVENT
        private void btnRegister_Click(object sender, EventArgs e) //MAIN EVENT: Register
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

            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password)) //step 1: check if username and password is empty
            {
                lblUsernameError.Text = "Username is empty";
                lblPasswordError.Text = "Password is empty";
                lblConPassError.Text = null;
                return;
            }
            else if (string.IsNullOrWhiteSpace(username)) //step 2: check if username is empty
            {
                lblUsernameError.Text = "Username is empty";
                lblPasswordError.Text = null;
                lblConPassError.Text = null;
                return;
            }
            else if (string.IsNullOrWhiteSpace(password)) //step 3: check if password is empty
            {
                lblUsernameError.Text = null;
                lblPasswordError.Text = "Password is empty";
                lblConPassError.Text = null;
                return;
            }
            else if (userCount > 0) //step 4: check if username already exists
            {
                lblUsernameError.Text = "Username Already Exists";
                lblPasswordError.Text = null;
                lblConPassError.Text = null;
                return;
            }
            else if (password != confirmPassword) //step 5: extra check if password matches
            {
                lblUsernameError.Text = null;
                lblPasswordError.Text = null;
                lblConPassError.Text = "Password does not match";
                return;
            }
            else if (!rbtnClient.Checked && !rbtnProvider.Checked) //step 6: check if role is chosen
            {
                lblUsernameError.Text = null;
                lblPasswordError.Text = null;
                lblConPassError.Text = "Please choose a role";
                return;
            }

            string hashPassword = SystemManager.HashPassword(password); //hash the password
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

        //EVENTS: Form navigation
        private void lblGoToL_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
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

        //SUPPORTING EVENTS
        private void rbtnClient_Click(object sender, EventArgs e) //SUPPORTING EVENT: Choose Client
        {
            if (rbtnProvider.Checked)
                rbtnProvider.Checked = false;
        }
        private void rbtnProvider_Click(object sender, EventArgs e) //SUPPORTING EVENT: Choose Vehicle Provider
        {
            if (rbtnClient.Checked)
                rbtnClient.Checked = false;
        }
        private void chkShowPass_CheckedChanged(object sender, EventArgs e) //SUPPORTING EVENT: Show/hide password
        {
            if (chkShowPass.Checked)
                txtPassword.PasswordChar = '•';
            else
                txtPassword.PasswordChar = '\0';
        }
        private void tmrFadeIn_Tick(object sender, EventArgs e) //SUPPORTING EVENT: Fade in animation
        {
            Opacity += 0.02;
            if (Opacity >= 1)
                tmrFadeIn.Stop();
        }
    }
}