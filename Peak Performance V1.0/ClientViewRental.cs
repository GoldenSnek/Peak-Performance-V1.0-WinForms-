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
    public partial class ClientViewRental : Form, IClientViewRental
    {
        OleDbConnection connection;

        private PictureBox[] userStars;
        private PictureBox[] vehicleStars;
        private Image starFilled = Properties.Resources.RateYes;
        private Image starEmpty = Properties.Resources.RateNo;

        public int VehicleID { get; set; }
        public int OwnerID { get; set; }
        public int UserRating { get; set; }
        public int VehicleRating { get; set; }
        public bool CurrentRent { get; set; }

        public ClientViewRental()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadDetails();
            AssignEventHandlers();
        }

        //EVENTS
        private void ClientViewRental_Load(object sender, EventArgs e) //INITIAL EVENT
        {
            string rentQuery = "SELECT RentedBy FROM Vehicles";

            using (OleDbCommand cmd = new OleDbCommand(rentQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int rentedBy = Convert.ToInt32(reader["RentedBy"]);

                    if (rentedBy == SystemManager.currentUserID)
                    {
                        connection.Close();
                        CurrentRent = true;
                        break;
                    }
                }
                connection.Close();
            }
            if (CurrentRent == false)
            {
                //i visible false tanan labels
                HideStarSelection();
            }
        }
        public void LoadDetails() //MAIN METHOD: Load Details
        {
            string displayQuery = $"SELECT VehicleID, OwnerID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, VehicleImage, VehicleRating, Username, Fullname, Address, Birthday, Email, DriversLicenseID, ContactNumber, UserRating, ProfilePicture, RentType, Duration, PaymentType, ChildSeat, SoundSystem, Powerbank, WiFi, Notes, Price FROM OwnerVehicleRentalQuery WHERE ClientID = {SystemManager.currentUserID}";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //IMPORTANT DATA
                    VehicleID = Convert.ToInt32(reader["VehicleID"]);
                    OwnerID = Convert.ToInt32(reader["OwnerID"]);

                    //VEHICLE
                    string? generalType = reader["GeneralType"].ToString();
                    string? specificType = reader["SpecificType"].ToString();
                    string? make = reader["Make"].ToString();

                    string? model = reader["Model"].ToString();
                    int vehicleYear = Convert.ToInt32(reader["VehicleYear"]);
                    string? transmission = reader["Transmission"].ToString();
                    string? drivetrain = reader["Drivetrain"].ToString();

                    string? licensePlate = reader["LicensePlate"].ToString();
                    string? color = reader["Color"].ToString();
                    string? fuelType = reader["FuelType"].ToString();

                    int seats = Convert.ToInt32(reader["Seats"]);
                    double mileage = Convert.ToDouble(reader["Mileage"]);

                    string? rentType = reader["RentType"].ToString();
                    int duration = Convert.ToInt32(reader["Duration"]);
                    string? paymentType = reader["PaymentType"].ToString();
                    string? childSeat = reader["ChildSeat"].ToString();
                    string? soundSystem = reader["SoundSystem"].ToString();
                    string? powerbank = reader["Powerbank"].ToString();
                    string? wifi = reader["WiFi"].ToString();
                    string? notes = reader["Notes"].ToString();
                    double totalPrice = Convert.ToDouble(reader["Price"]);

                    lblType.Text = $"Type: {generalType} ({specificType})";
                    lblMake.Text = $"Make: {make}";
                    lblModel.Text = $"Model: {model} ({vehicleYear})";
                    lblTransmission.Text = $"Transmission: {transmission}";
                    lblDrivetrain.Text = $"Drivetrain: {drivetrain}";
                    lblLicensePlate.Text = $"License Plate No: {licensePlate}";
                    lblColor.Text = $"Color: {color}";
                    lblFuelType.Text = $"Fuel Type: {fuelType}";
                    lblSeats.Text = $"Seats: {seats}";
                    lblMileage.Text = $"Mileage: {mileage} km";
                    lblOC.Text = "Client";

                    lblDuration.Text = $"Duration: {duration} {rentType}";
                    lblPayment.Text = $"Payment Type: {paymentType}";
                    lblExtras.Text = $"Extras: ";
                    if (childSeat != "None")
                        lblExtras.Text += $"{childSeat} ";
                    if (soundSystem != "Basic")
                        lblExtras.Text += $"{soundSystem} ";
                    if (powerbank != "None")
                        lblExtras.Text += $"{powerbank} ";
                    if (wifi != "None")
                        lblExtras.Text += $"{wifi}";
                    lblNotes.Text = $"Additional notes: {notes}";
                    lblTotalPrice.Text = $"Php {totalPrice}";

                    //convert image from database to PictureBox
                    Image? vehicleImage = null;
                    if (!Convert.IsDBNull(reader["VehicleImage"])) //check if image is not NULL
                    {
                        byte[] imageData = (byte[])reader["VehicleImage"];
                        using (MemoryStream? ms = new MemoryStream(imageData))
                        {
                            vehicleImage = Image.FromStream(ms);
                        }
                    }

                    double vehicleRating = Convert.ToDouble(reader["VehicleRating"]);
                    lblVehicleRating.Text = $"Rating: {vehicleRating.ToString()}";

                    if (vehicleImage != null)
                        picVehicleImage.Image = vehicleImage;
                    else
                        picVehicleImage.Image = Properties.Resources.Car___MainLR;

                    //OWNER
                    string? username = reader["Username"].ToString();

                    string? fullName = reader["Fullname"].ToString();
                    string? address = reader["Address"].ToString();
                    string? birthday = reader["Birthday"].ToString();
                    string? email = reader["Email"].ToString();

                    int driversLicenseID = Convert.ToInt32(reader["DriversLicenseID"]);
                    int contactNumber = Convert.ToInt32(reader["ContactNumber"]);
                    double userRating = Convert.ToDouble(reader["UserRating"]);

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

                    lblUsername.Text = $"Username: {username}";
                    lblUserRating.Text = $"Rating: {userRating.ToString()}";

                    lblFullname.Text = $"Fullname: {fullName}";
                    lblAddress.Text = $"Address: {address}";
                    lblBirthday.Text = $"Birthday: {birthday}";
                    lblLicenseID.Text = $"Drivers License ID: {driversLicenseID.ToString()}";
                    lblEmail.Text = $"Email: {email}";
                    lblNumber.Text = $"Contact Number: {contactNumber}";

                    if (profilePicture != null)
                        picProfilePicture.Image = profilePicture;
                    else
                        picProfilePicture.Image = Properties.Resources.Avatar;
                }

                connection.Close();
            }
        }
        public void btnRate_Click(object sender, EventArgs e) //MAIN EVENT: Save the ratings
        {
            string getQuery = "SELECT UserRating, UserRaters, UserTotalRatings, VehicleRating, VehicleRaters, VehicleTotalRatings, RateStatus " +
                              "FROM RatingQuery WHERE OwnerID = @ownerID AND VehicleID = @vehicleID";

            using (OleDbCommand cmd = new OleDbCommand(getQuery, connection))
            {
                cmd.Parameters.AddWithValue("@ownerID", OwnerID);
                cmd.Parameters.AddWithValue("@vehicleID", VehicleID);

                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                //variables to store database values
                int userRaters = 0, userTotalRatings = 0;
                double userRating = 0;
                int vehicleRaters = 0, vehicleTotalRatings = 0;
                double vehicleRating = 0;
                string rateStatus = "";

                //read current values from the database
                if (reader.Read())
                {
                    userRating = Convert.ToDouble(reader[0]);
                    userRaters = Convert.ToInt32(reader[1]);
                    userTotalRatings = Convert.ToInt32(reader[2]);
                    vehicleRating = Convert.ToDouble(reader[3]);
                    vehicleRaters = Convert.ToInt32(reader[4]);
                    vehicleTotalRatings = Convert.ToInt32(reader[5]);
                    rateStatus = reader[6].ToString();
                }
                reader.Close();

                if (rateStatus == "Yes")
                {
                    MessageBox.Show("You have already rated this vehicle.", "Rating Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connection.Close();
                    return;
                }
                int userGivenRating = UserRating;
                int vehicleGivenRating = VehicleRating;

                userRaters += 1;
                userTotalRatings += userGivenRating;
                userRating = (double)userTotalRatings / userRaters;

                vehicleRaters += 1;
                vehicleTotalRatings += vehicleGivenRating;
                vehicleRating = (double)vehicleTotalRatings / vehicleRaters;

                string updateQuery = "UPDATE RatingQuery SET UserRating = @userRating, UserRaters = @userRaters, UserTotalRatings = @userTotalRatings, " +
                                     "VehicleRating = @vehicleRating, VehicleRaters = @vehicleRaters, VehicleTotalRatings = @vehicleTotalRatings, RateStatus = 'Yes' " +
                                     "WHERE OwnerID = @ownerID AND VehicleID = @vehicleID";

                using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, connection))
                {
                    updateCmd.Parameters.AddWithValue("@userRating", userRating);
                    updateCmd.Parameters.AddWithValue("@userRaters", userRaters);
                    updateCmd.Parameters.AddWithValue("@userTotalRatings", userTotalRatings);
                    updateCmd.Parameters.AddWithValue("@vehicleRating", vehicleRating);
                    updateCmd.Parameters.AddWithValue("@vehicleRaters", vehicleRaters);
                    updateCmd.Parameters.AddWithValue("@vehicleTotalRatings", vehicleTotalRatings);
                    updateCmd.Parameters.AddWithValue("@ownerID", OwnerID);
                    updateCmd.Parameters.AddWithValue("@vehicleID", VehicleID);

                    updateCmd.ExecuteNonQuery();
                }

                try
                {
                    connection.Close();
                    MessageBox.Show("Rating submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRate.Enabled = false;
                    DisableStarSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while submitting the rating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        //SUPPORTING EVENTS
        private void AssignEventHandlers() //SUPPORTING EVENT: Attach events to the stars (for rating)
        {
            //assigning existing PictureBoxes to arrays
            userStars = new PictureBox[] { picUR1, picUR2, picUR3, picUR4, picUR5 };
            vehicleStars = new PictureBox[] { picVR1, picVR2, picVR3, picVR4, picVR5 };

            //attach event handlers for user rating stars
            for (int i = 0; i < userStars.Length; i++)
            {
                userStars[i].Tag = i + 1; // Set tag for rating value
                userStars[i].MouseEnter += UserStar_MouseEnter;
                userStars[i].MouseLeave += UserStar_MouseLeave;
                userStars[i].Click += UserStar_Click;
            }

            //attach event handlers for vehicle rating stars
            for (int i = 0; i < vehicleStars.Length; i++)
            {
                vehicleStars[i].Tag = i + 1;
                vehicleStars[i].MouseEnter += VehicleStar_MouseEnter;
                vehicleStars[i].MouseLeave += VehicleStar_MouseLeave;
                vehicleStars[i].Click += VehicleStar_Click;
            }
        }

        private void UserStar_MouseEnter(object sender, EventArgs e) //SUPPORTING EVENT: User star
        {
            int hoverIndex = (int)((PictureBox)sender).Tag;
            HighlightStars(userStars, hoverIndex);
        }

        private void UserStar_MouseLeave(object sender, EventArgs e) //SUPPORTING EVENT: User star
        {
            HighlightStars(userStars, UserRating);
        }

        private void UserStar_Click(object sender, EventArgs e) //SUPPORTING EVENT: User star
        {
            UserRating = (int)((PictureBox)sender).Tag;
            HighlightStars(userStars, UserRating);
        }

        private void VehicleStar_MouseEnter(object sender, EventArgs e) //SUPPORTING EVENT: Vehicle star
        {
            int hoverIndex = (int)((PictureBox)sender).Tag;
            HighlightStars(vehicleStars, hoverIndex);
        }

        private void VehicleStar_MouseLeave(object sender, EventArgs e) //SUPPORTING EVENT: Vehicle star
        {
            HighlightStars(vehicleStars, VehicleRating);
        }

        private void VehicleStar_Click(object sender, EventArgs e) //SUPPORTING EVENT: Vehicle star
        {
            VehicleRating = (int)((PictureBox)sender).Tag;
            HighlightStars(vehicleStars, VehicleRating);
        }

        private void HighlightStars(PictureBox[] stars, int count) //SUPPORTING EVENT: Color the stars
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Image = (i < count) ? starFilled : starEmpty;
            }
        }
        private void DisableStarSelection() //SUPPORTING EVENT: Disable Stars (if manag rate)
        {
            picUR1.Enabled = false;
            picUR2.Enabled = false;
            picUR3.Enabled = false;
            picUR4.Enabled = false;
            picUR5.Enabled = false;
            picVR1.Enabled = false;
            picVR2.Enabled = false;
            picVR3.Enabled = false;
            picVR4.Enabled = false;
            picVR5.Enabled = false;
        }

        private void HideStarSelection() //SUPPORTING EVENT: Hide stars (if manag rate)
        {
            btnRate.Visible = false;
            picUR1.Visible = false;
            picUR2.Visible = false;
            picUR3.Visible = false;
            picUR4.Visible = false;
            picUR5.Visible = false;
            picVR1.Visible = false;
            picVR2.Visible = false;
            picVR3.Visible = false;
            picVR4.Visible = false;
            picVR5.Visible = false;
        }
    }
}