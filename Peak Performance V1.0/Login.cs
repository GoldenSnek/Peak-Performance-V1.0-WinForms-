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

//NuGet UI packages
using ReaLTaiizor;          // Core namespace
using ReaLTaiizor.Manager;
using ReaLTaiizor.Controls; // For custom controls like buttons, labels, etc.
using ReaLTaiizor.Forms;    // For using Taiizor-styled forms
using ReaLTaiizor.Enum;     // For enumerations (e.g., themes, styles)



//keywords for RealTaiizor
//ReaLTaiizor.Colors.
//ReaLTaiizor.Util.










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
            //set realtaiizor materialskin theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ReaLTaiizor.Colors.MaterialColorScheme(ReaLTaiizor.Colors.MaterialPrimary.Orange700, ReaLTaiizor.Colors.MaterialPrimary.Orange800, ReaLTaiizor.Colors.MaterialPrimary.Orange900, ReaLTaiizor.Colors.MaterialAccent.Orange700, ReaLTaiizor.Util.MaterialTextShade.WHITE);

            txtUsername.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            txtUsername.ForeColor = Color.Red;
            txtUsername.Refresh();


            txtPassword.PasswordChar = '•'; //hide password by default
        }

        private void btnLogin_Click(object sender, EventArgs e) //MAIN EVENT, Login
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

                    if (reader.Read()) //if user exists
                    {
                        int userID = reader.GetInt32(0); //get UserID
                        string role = reader.GetString(1); //get Role

                        //store UserID in a global/static variable
                        SystemManager.currentUserID = userID;
                        SystemManager.currentUsername = username;
                        SystemManager.currentRole = role;

                        MessageBox.Show($"Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //open respective main form based on role
                        if (role == "Admin")
                        {
                            /*
                            MainMenu provider = new MainMenu();
                            provider.Show();
                            this.Hide();
                            */
                        }
                        else
                        {
                            Home mainMenu = new Home();
                            mainMenu.Show();
                            this.Hide();
                        }
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

        private void chkShowPass_CheckedChanged(object sender, EventArgs e) //SUPPORTING EVENT, show/hide password
        {
            if (chkShowPass.Checked)
                txtPassword.PasswordChar = '•';
            else
                txtPassword.PasswordChar = '\0';
        }

        private void lblGoToR_Click(object sender, EventArgs e) //EVENT, go back to Login
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }


        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); ;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            MainLR mainLR = new MainLR();
            mainLR.Show();
            this.Hide();
        }
    }
}