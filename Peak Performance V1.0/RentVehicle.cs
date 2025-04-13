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
    public partial class RentVehicle : Form, IRentVehicle
    {
        private OleDbConnection connection;
        double PriceDaily = 0;
        double PriceHourly = 0;
        public int OwnerUserID = 0;
        double Price = 0;
        public RentVehicle()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicleDetails();
            tmrFadeIn.Start();
        }
        public void LoadVehicleDetails() //MAIN METHOD
        {
            string displayQuery = $"SELECT UserID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage, VehicleRating, Username, Fullname, Address, Birthday, Email, DriversLicenseID, ContactNumber, UserRating, ProfilePicture FROM UserVehicleQuery WHERE VehicleID = {SystemManager.currentFullDetailsVehicleID}";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //VEHICLE
                    OwnerUserID = Convert.ToInt32(reader["UserID"]);
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
                    double priceDaily = Convert.ToDouble(reader["PriceDaily"]);
                    double priceHourly = Convert.ToDouble(reader["PriceHourly"]);

                    //store globally
                    PriceDaily = priceDaily;
                    PriceHourly = priceHourly;

                    //lblType.Text = $"Type:{generalType} ({specificType})";
                    //lblMake.Text = $"{make}";
                    //lblModel.Text = $"{model} ({vehicleYear})";
                    //lblTransmission.Text = $"Transmission: {transmission}";
                    //lblDrivetrain.Text = $"Drivetrain: {drivetrain}";
                    //lblLicensePlate.Text = $"License Plate No: {licensePlate}";
                    //lblColor.Text = $"Color: {color}";
                    //lblFuelType.Text = $"Fuel Type: {fuelType}";
                    //lblSeats.Text = $"Seats: {seats}";
                    //lblMileage.Text = $"Mileage: {mileage} km";
                    lblDailyPrice.Text = $"Php {priceDaily}/day";
                    lblHourlyPrice.Text = $"Php {priceHourly}/hr";

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

                    string? driversLicenseID = reader["DriversLicenseID"].ToString();
                    string? contactNumber = reader["ContactNumber"].ToString();
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

                    //lblUsername.Text = $"Username: {username}";
                    //lblUserRating.Text = $"Rating: {userRating.ToString()}";

                    //lblFullname.Text = $"Fullname: {fullName}";
                    //lblAddress.Text = $"Address: {address}";
                    //lblBirthday.Text = $"Birthday: {birthday}";
                    //lblLicenseID.Text = $"Drivers License ID: {driversLicenseID.ToString()}";
                    //lblEmail.Text = $"Email: {email}";
                    //lblNumber.Text = $"Contact Number: {contactNumber}";

                    if (profilePicture != null)
                        picProfilePicture.Image = profilePicture;
                    else
                        picProfilePicture.Image = Properties.Resources.Avatar;
                }

                connection.Close();
            }
        }
        public void btnFinalize_Click(object sender, EventArgs e) //MAIN EVENT: Rent
        {
            string rentalQuery = "INSERT INTO RentalDetails (VehicleID, ClientID, OwnerID, RentType, Duration, PaymentType, ChildSeat, SoundSystem, Powerbank, WiFi, Notes, Price, Status, RateStatus) " +
                   "VALUES (@VehicleID, @ClientID, @OwnerID, @RentType, @Duration, @PaymentType, @ChildSeat, @SoundSystem, @Powerbank, @WiFi, @Notes, @Price, @Status, @RateStatus)";

            double estimate = 0;
            double multiplier = 0;

            if (cbxRent.Text == "Days")
                multiplier = PriceDaily;
            else if (cbxRent.Text == "Hours")
                multiplier = PriceHourly;

            estimate += multiplier * double.Parse(cbxDuration.Text);

            if (cbxChildSeat.Text == "Infant")
                estimate += 30;
            if (cbxChildSeat.Text == "Toddler")
                estimate += 50;
            if (cbxSound.Text == "Premium")
                estimate += 300;
            if (cbxPowerbank.Text == "3,000 maH")
                estimate += 100;
            if (cbxPowerbank.Text == "5,000 maH")
                estimate += 120;
            if (cbxPowerbank.Text == "10,000 maH")
                estimate += 150;
            if (cbxWifi.Text == "Pocket WiFi")
                estimate += 100;

            Price = estimate;

            using (OleDbCommand cmd = new OleDbCommand(rentalQuery, connection))
            {
                cmd.Parameters.AddWithValue("@VehicleID", SystemManager.currentFullDetailsVehicleID);
                cmd.Parameters.AddWithValue("@ClientID", SystemManager.currentUserID);
                cmd.Parameters.AddWithValue("@OwnerID", OwnerUserID);
                cmd.Parameters.AddWithValue("@RentType", cbxRent.Text.ToString());
                cmd.Parameters.AddWithValue("@Duration", int.Parse(cbxDuration.Text));
                cmd.Parameters.AddWithValue("@PaymentType", cbxPaymentType.Text);
                cmd.Parameters.AddWithValue("@ChildSeat", cbxChildSeat.Text);
                cmd.Parameters.AddWithValue("@SoundSystem", cbxSound.Text);
                cmd.Parameters.AddWithValue("@Powerbank", cbxPowerbank.Text);
                cmd.Parameters.AddWithValue("@WiFi", cbxWifi.Text);
                cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                cmd.Parameters.AddWithValue("@Price", Math.Round(Price, 2));
                cmd.Parameters.AddWithValue("@Status", "Unpaid");
                cmd.Parameters.AddWithValue("@RateStatus", "No");

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    SystemManager.refresh = true;
                    using (ErrorMessage errorForm = new ErrorMessage($"Rental finalized successfully! Please proceed to payment."))
                    {
                        errorForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    using (ErrorMessage errorForm = new ErrorMessage($"Error: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                }
            }

            string rentedByQuery = "UPDATE Vehicles SET RentedBy = @rentedBy WHERE VehicleID = @vehicleID";
            using (OleDbCommand cmd = new OleDbCommand(rentedByQuery, connection))
            {
                cmd.Parameters.AddWithValue("@rentedBy", SystemManager.currentUserID);
                cmd.Parameters.AddWithValue("@vehicleID", SystemManager.currentFullDetailsVehicleID);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    using (ErrorMessage errorForm = new ErrorMessage($"Error: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                }
            }

            this.DialogResult = DialogResult.Cancel; // Optional: Handle closing action
            this.Close();
        }
        private void tmrFadeIn_Tick(object sender, EventArgs e) //SUPPORTING EVENT: Fade-in animation
        {
            Opacity += 0.1;
            if (Opacity >= 1)
                tmrFadeIn.Stop();
        }

        private void picBack_Click(object sender, EventArgs e) //NAVIGATION EVENT: Exit
        {
            SystemManager.refresh = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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

        private void btnEstimate_Click(object sender, EventArgs e) //SUPPORTING EVENT: Estimate price
        {
            double estimate = 0;
            double multiplier = 0;

            if (cbxRent.Text == "Days")
                multiplier = PriceDaily;
            else if (cbxRent.Text == "Hours")
                multiplier = PriceHourly;

            estimate += multiplier * double.Parse(cbxDuration.Text);

            if (cbxChildSeat.Text == "Infant")
                estimate += 30;
            if (cbxChildSeat.Text == "Toddler")
                estimate += 50;
            if (cbxSound.Text == "Premium")
                estimate += 300;
            if (cbxPowerbank.Text == "3,000 maH")
                estimate += 100;
            if (cbxPowerbank.Text == "5,000 maH")
                estimate += 120;
            if (cbxPowerbank.Text == "10,000 maH")
                estimate += 150;
            if (cbxWifi.Text == "Pocket WiFi")
                estimate += 100;

            lblEstimatedPrice.Text = $"Estimated price: Php {Math.Round(estimate, 2).ToString()}";

            Price = estimate;
        }
    }
}
