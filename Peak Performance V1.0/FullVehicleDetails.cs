using Microsoft.VisualBasic.ApplicationServices;
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
using System.Runtime.InteropServices;

namespace Peak_Performance_V1._0
{
    public partial class FullVehicleDetails : Form
    {
        private OleDbConnection connection;

        public FullVehicleDetails(string type)
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicleDetails(type);
            tmrFadeIn.Start();
        }

        void LoadVehicleDetails(string type)
        {
            if (type == "Owner")
            {
                string displayQuery = $"SELECT GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage, VehicleRating, Username, Fullname, Address, Birthday, Email, DriversLicenseID, ContactNumber, UserRating, ProfilePicture FROM UserVehicleQuery WHERE VehicleID = {SystemManager.currentFullDetailsVehicleID}";

                using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
                {
                    connection.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
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
                        double priceDaily = Convert.ToDouble(reader["PriceDaily"]);
                        double priceHourly = Convert.ToDouble(reader["PriceHourly"]);

                        lblType.Text = $"Type:{generalType} ({specificType})";
                        lblMake.Text = $"{make}";
                        lblModel.Text = $"{model} ({vehicleYear})";
                        lblTransmission.Text = $"Transmission: {transmission}";
                        lblDrivetrain.Text = $"Drivetrain: {drivetrain}";
                        lblLicensePlate.Text = $"License Plate No: {licensePlate}";
                        lblColor.Text = $"Color: {color}";
                        lblFuelType.Text = $"Fuel Type: {fuelType}";
                        lblSeats.Text = $"Seats: {seats}";
                        lblMileage.Text = $"Mileage: {mileage} km";
                        lblDailyPrice.Text = $"Php {priceDaily}/day";
                        lblHourlyPrice.Text = $"Php {priceHourly}/hr";
                        lblDuration.Visible = false;
                        lblPayment.Visible = false;
                        lblExtras.Visible = false;
                        lblNotes.Visible = false;
                        lblTotalPrice.Visible = false;

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
                        lblOC.Text = "Owner";

                        if (profilePicture != null)
                            picProfilePicture.Image = profilePicture;
                        else
                            picProfilePicture.Image = Properties.Resources.Avatar;
                    }

                    connection.Close();
                }
            }
            else if (type == "Client")
            {
                lblDuration.Visible = true;
                lblPayment.Visible = true;
                lblExtras.Visible = true;
                lblNotes.Visible = true;
                lblTotalPrice.Visible = true;

                string displayQuery = $"SELECT GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage, VehicleRating, Username, Fullname, Address, Birthday, Email, DriversLicenseID, ContactNumber, UserRating, ProfilePicture, RentType, Duration, PaymentType, ChildSeat, SoundSystem, Powerbank, WiFi, Notes, Price FROM ClientVehicleQuery WHERE VehicleID = {SystemManager.currentFullDetailsVehicleID}";

                using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
                {
                    connection.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
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
                        double priceDaily = Convert.ToDouble(reader["PriceDaily"]);
                        double priceHourly = Convert.ToDouble(reader["PriceHourly"]);

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
                        lblDailyPrice.Text = $"Php {priceDaily}/day";
                        lblHourlyPrice.Text = $"Php {priceHourly}/hr";
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
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Optional: Handle closing action
            this.Close();
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity >= 1)
                tmrFadeIn.Stop();
        }

        /*
        //singleton
        private static FullVehicleDetails instance;
        public static FullVehicleDetails GetInstance(int vehicleID)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FullVehicleDetails();
            }
            return instance;
        }

        public static void CloseInstance()
        {
            if (instance != null)
            {
                instance.Close();
                instance.Dispose();
                instance = null;  // Reset singleton reference
            }
        }
        */

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
    }
}