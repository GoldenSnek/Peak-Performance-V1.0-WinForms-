using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.Data.OleDb; //added for database connection
using System.Security.Cryptography; //added for password hashing

namespace Peak_Performance_V1._0
{
    public partial class Login : Form
    {
        private OleDbConnection connection;

        public Login()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            tmrFadeIn.Start();
            txtPassword.PasswordChar = '•'; //hide password by default
        }

        //MAIN EVENT
        private void btnLogin_Click(object sender, EventArgs e) //MAIN EVENT: Login
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password)) //step 1: check if username and password is empty
            {
                lblUsernameError.Text = "Username is empty";
                lblPasswordError.Text = "Password is empty";
                return;
            }
            else if (string.IsNullOrWhiteSpace(username)) //step 2: check if username is empty
            {
                lblUsernameError.Text = "Username is empty";
                lblPasswordError.Text = null;
                return;
            }
            else if (string.IsNullOrWhiteSpace(password)) //step 3: check if password is empty
            {
                lblUsernameError.Text = null;
                lblPasswordError.Text = "Password is empty";
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

                    if (reader.Read()) //if user exists
                    {
                        int userID = reader.GetInt32(0); //get UserID
                        string role = reader.GetString(1); //get Role

                        //store UserID in a global/static variable
                        SystemManager.currentUserID = userID;
                        SystemManager.currentUsername = username;
                        SystemManager.currentRole = role;

                        SplashLoading splashLoading = new SplashLoading();
                        splashLoading.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblUsernameError.Text = null;
                        lblPasswordError.Text = "Invalid Credentials!";
                    }

                    reader.Close();
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
        private void lblGoToR_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
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