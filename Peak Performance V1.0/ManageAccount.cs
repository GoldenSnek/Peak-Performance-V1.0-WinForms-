using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Peak_Performance_V1._0
{
    public partial class ManageAccount : Form
    {
        private OleDbConnection connection;
        public ManageAccount()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
        }

        //SUPPORTING EVENT
        private void btnBrowse_Click(object sender, EventArgs e) //SUPPORTING EVENT: Browse and select an image
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picProfilePicture.Image = Image.FromFile(openFileDialog.FileName);
                    lblImagePath.Text = openFileDialog.FileName; //store image path for later use //pwede ra i .visible=false
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e) //SUPPORTING EVENT: Clear all textboxes
        {
            txtFullname.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtBirthday.Text = string.Empty;
            txtLicenseID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNumber.Text = string.Empty;
        }
        private void btnClearPicture_Click(object sender, EventArgs e) //SUPPORTING EVENT: Clear picture
        {
            picProfilePicture.Image = null;
            lblImagePath.Text = null;
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            if (SystemManager.currentRole == "Client")
                lblTotalRentals.Visible = false;

            string displayQuery = "SELECT UserID, Username, Role, Fullname, Address, Birthday, Email, DriversLicenseID, ContactNumber, Rating, TotalRentals, ProfilePicture FROM Users";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int userID = Convert.ToInt32(reader["userID"]);
                    if (SystemManager.currentUserID == userID)
                    {
                        string? username = reader["Username"].ToString();
                        string? role = reader["Role"].ToString();

                        string? fullName = reader["Fullname"].ToString();
                        string? address = reader["Address"].ToString();
                        string? birthday = reader["Birthday"].ToString();
                        string? email = reader["Email"].ToString();

                        int driversLicenseID = Convert.ToInt32(reader["DriversLicenseID"]);
                        int contactNumber = Convert.ToInt32(reader["ContactNumber"]);
                        double rating = Convert.ToDouble(reader["Rating"]);
                        int totalRentals = Convert.ToInt32(reader["TotalRentals"]);


                        //convert image from database to PictureBox
                        Image? profilePicture = null;
                        if (!Convert.IsDBNull(reader["ProfilePicture"])) //check if image is not NULL
                        {
                            byte[] imageData = (byte[])reader["ProfilePicture"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                profilePicture = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            picProfilePicture.Image = Properties.Resources.Avatar;
                        }

                        //non-editable
                        if (profilePicture != null)
                            picProfilePicture.Image = profilePicture;
                        else
                            picProfilePicture.Image = Properties.Resources.Avatar;

                        lblUserID.Text = $"User ID: {userID}";
                        lblUsername.Text = $"Username: {username}";
                        lblRole.Text = $"Role: {role}";
                        lblRating.Text = $"Rating: {rating.ToString()}";
                        lblTotalRentals.Text = $"Total vehicles rented: {totalRentals}";

                        //editables
                        txtFullname.Text = fullName;
                        txtAddress.Text = address;
                        txtBirthday.Text = birthday;
                        txtLicenseID.Text = driversLicenseID.ToString();
                        txtEmail.Text = email;
                        txtNumber.Text = contactNumber.ToString();
                    }
                }
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string imagePath = lblImagePath.Text;
            if (string.IsNullOrWhiteSpace(txtFullname.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtBirthday.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtLicenseID.Text) || string.IsNullOrWhiteSpace(txtNumber.Text)) //step 1: check if fields are empty
            {
                MessageBox.Show("Please fill in all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(imagePath)) //step 2: check if profile pic is empty
            {
                MessageBox.Show("Please upload an image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            string updateQuery = $"UPDATE Users SET Fullname = @fullName, Address = @address, Birthday = @birthday, Email = @email, DriversLicenseID = @licenseID, ContactNumber = @contactNumber, ProfilePicture = @imagePath Where UserID = {SystemManager.currentUserID}";
            using (OleDbCommand cmd = new OleDbCommand(updateQuery, connection))
            {
                cmd.Parameters.AddWithValue("@fullName", txtFullname.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@birthday", txtBirthday.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@licenseID", txtLicenseID.Text);
                cmd.Parameters.AddWithValue("@contactNumber", txtNumber.Text);
                cmd.Parameters.AddWithValue("@imagePath", imageBytes);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating: " + ex.Message);
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //ALSO DELETE ALL VEHICLES IN THE FUTURE (kapoy pa)

            string deleteQuery = $"DELETE FROM Users WHERE userID = {SystemManager.currentUserID}";
            using (OleDbCommand cmd = new OleDbCommand(deleteQuery, connection))
            {
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("BYEBYE", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainLR mainLR = new MainLR();
                    mainLR.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting" + ex.Message);
                    return;
                }
            }
        }
    }
}