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
    public partial class ClientViewRental : Form
    {
        OleDbConnection connection;
        public ClientViewRental()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadDetails();
        }
        private void LoadDetails()
        {
            string displayQuery = $"SELECT GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, VehicleImage, VehicleRating, Username, Fullname, Address, Birthday, Email, DriversLicenseID, ContactNumber, UserRating, ProfilePicture, RentType, Duration, PaymentType, ChildSeat, SoundSystem, Powerbank, WiFi, Notes, Price FROM OwnerVehicleRentalQuery WHERE ClientID = {SystemManager.currentUserID}";

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
}
