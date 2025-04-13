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

namespace Peak_Performance_V1._0
{
    public partial class ManageAccount : Form, IManageAccount
    {
        private OleDbConnection connection;
        private Home homeForm; //reference to Home form

        public ManageAccount(Home home)
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            this.homeForm = home; //store reference to home form
        }

        //MAIN EVENTS
        private void ManageAccount_Load(object sender, EventArgs e) //INITIAL EVENT
        {
            if (SystemManager.currentRole == "Vehicle Provider")
            {
                lblTotalRentals.Visible = false;
                lblRating.Visible = true;
            }
            else if (SystemManager.currentRole == "Client")
            {
                lblTotalRentals.Visible = true;
                lblRating.Visible = false;
            }

            string displayQuery = "SELECT UserID, Username, Role, Fullname, Address, Birthday, Email, DriversLicenseID, ContactNumber, UserRating, UserTotalRentals, ProfilePicture FROM Users";

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

                        string? driversLicenseID = reader["DriversLicenseID"].ToString();
                        string? contactNumber = reader["ContactNumber"].ToString();
                        double rating = Convert.ToDouble(reader["UserRating"]);
                        int totalRentals = Convert.ToInt32(reader["UserTotalRentals"]);


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

                        //non-editable
                        if (profilePicture != null)
                            picProfilePicture.Image = profilePicture;

                        lblUserID.Text = $"User ID: {userID}";
                        lblUsername.Text = $"Username: {username}";
                        lblRole.Text = $"Role: {role}";
                        lblRating.Text = $"Rating: {rating.ToString()}";
                        lblTotalRentals.Text = $"Total vehicles rented: {totalRentals}";

                        //editables
                        txtFullname.Text = fullName;
                        txtAddress.Text = address;
                        txtBirthday.Text = birthday;
                        txtLicenseID.Text = driversLicenseID;
                        txtEmail.Text = email;
                        txtNumber.Text = contactNumber;
                    }
                }
                connection.Close();
            }
        }
        public void btnSave_Click(object sender, EventArgs e) //MAIN EVENT: Update details
        {
            string imagePath = lblImagePath.Text;
            byte[] imageBytes = null;
            if (string.IsNullOrWhiteSpace(txtFullname.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtBirthday.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtLicenseID.Text) || string.IsNullOrWhiteSpace(txtNumber.Text)) //step 1: check if fields are empty
            {
                using (ErrorMessage errorForm = new ErrorMessage($"Please fill in all the details."))
                {
                    errorForm.ShowDialog();
                }
                return;
            }

            if (!string.IsNullOrWhiteSpace(imagePath)) //if a new image is selected
                imageBytes = File.ReadAllBytes(imagePath);
            else if (picProfilePicture.Image == null) //if an image exists in the PictureBox
            {
                using (ErrorMessage errorForm = new ErrorMessage($"Please upload an image."))
                {
                    errorForm.ShowDialog();
                }
                return;
            }
            else
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand cmdGetImage = new OleDbCommand("SELECT ProfilePicture FROM Users WHERE UserID = @userID", connection))
                    {
                        cmdGetImage.Parameters.AddWithValue("@userID", SystemManager.currentUserID);
                        object existingImage = cmdGetImage.ExecuteScalar();
                        if (existingImage != DBNull.Value)
                            imageBytes = (byte[])existingImage;
                    }
                }
                catch (Exception ex)
                {
                    using (ErrorMessage errorForm = new ErrorMessage($"Error retrieving image: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                    return;
                }
                finally
                {
                    connection.Close(); //ensure connection is closed
                }
            }

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
                    using (ErrorMessage errorForm = new ErrorMessage($"Details updated successfully!"))
                    {
                        errorForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    using (ErrorMessage errorForm = new ErrorMessage($"Error updating: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                    return;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void btnDelete_Click(object sender, EventArgs e) //MAIN EVENT: Delete Account and all vehicles owned (di pa functional all vehicles owned)
        {
            //ALSO DELETE ALL VEHICLES IN THE FUTURE (kapoy pa)

            string deleteQuery = $"DELETE FROM Users WHERE UserID = {SystemManager.currentUserID}";
            using (OleDbCommand cmd = new OleDbCommand(deleteQuery, connection))
            {
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    using (ErrorMessage errorForm = new ErrorMessage($"Thank you for using Peak Performance! Drive safe, stay awesome, and we’ll see you again soon! BYEBYE! -JM"))
                    {
                        errorForm.ShowDialog();
                    }

                    //close the Home form
                    if (homeForm != null)
                        homeForm.Close();

                    //ppen login form
                    MainLR mainLR = new MainLR();
                    mainLR.Show();

                    this.Close(); //close ManageAccount form
                }
                catch (Exception ex)
                {
                    using (ErrorMessage errorForm = new ErrorMessage($"Error deleting: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                    return;
                }
                finally
                {
                    connection.Close();
                }
            }
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
    }
}