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
    public partial class FullVehicleDetails : Form, IFullVehicleDetails
    {
        private OleDbConnection connection;
        public string? GeneralType { get; set; }
        public string? SpecificType { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int VehicleYear { get; set; }
        public string? Transmission { get; set; }
        public string? Drivetrain { get; set; }
        public string? LicensePlate { get; set; }
        public string? VehicleColor { get; set; }
        public string? FuelType { get; set; }
        public int Seats { get; set; }
        public double Mileage { get; set; }
        public double PriceDaily { get; set; }
        public double PriceHourly { get; set; }
        public Image VehicleImage { get; set; }

        public string? Username { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? Birthday { get; set; }
        public string? Email { get; set; }
        public string? DriversLicenseID { get; set; }
        public string? ContactNumber { get; set; }
        public double UserRating { get; set; }
        public Image ProfilePicture { get; set; }

        public string? RentType { get; set; }
        public int Duration { get; set; }
        public string? PaymentType { get; set; }
        public string? ChildSeat { get; set; }
        public string? SoundSystem { get; set; }
        public string? Powerbank { get; set; }
        public string? WiFi { get; set; }
        public string? Notes { get; set; }
        public double TotalPrice { get; set; }
        public double VehicleRating { get; set; }

        public FullVehicleDetails(string type)
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicleDetails(type);
            tmrFadeIn.Start();
        }

        void LoadVehicleDetails(string type) //MAIN EVENT
        {
            if (type == "Owner")
            {
                lblDuration.Visible = false;
                lblPayment.Visible = false;
                lblExtras.Visible = false;
                lblNotes.Visible = false;
                lblTotalPrice.Visible = false;
                lblUserRating.Visible = false;
                string displayQuery = $"SELECT GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage, VehicleRating, Username, Fullname, Address, Birthday, Email, DriversLicenseID, ContactNumber, UserRating, ProfilePicture FROM UserVehicleQuery WHERE VehicleID = {SystemManager.currentFullDetailsVehicleID}";

                using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
                {
                    connection.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //VEHICLE
                        GeneralType = reader["GeneralType"].ToString();
                        SpecificType = reader["SpecificType"].ToString();
                        Make = reader["Make"].ToString();

                        Model = reader["Model"].ToString();
                        VehicleYear = Convert.ToInt32(reader["VehicleYear"]);
                        Transmission = reader["Transmission"].ToString();
                        Drivetrain = reader["Drivetrain"].ToString();

                        LicensePlate = reader["LicensePlate"].ToString();
                        VehicleColor = reader["Color"].ToString();
                        FuelType = reader["FuelType"].ToString();

                        Seats = Convert.ToInt32(reader["Seats"]);
                        Mileage = Convert.ToDouble(reader["Mileage"]);
                        PriceDaily = Convert.ToDouble(reader["PriceDaily"]);
                        PriceHourly = Convert.ToDouble(reader["PriceHourly"]);

                        lblType.Text = $"Type: {GeneralType} ({SpecificType})";
                        lblMake.Text = $"Make: {Make}";
                        lblModel.Text = $"Model: {Model} ({VehicleYear})";
                        lblTransmission.Text = $"Transmission: {Transmission}";
                        lblDrivetrain.Text = $"Drivetrain: {Drivetrain}";
                        lblLicensePlate.Text = $"License Plate No: {LicensePlate}";
                        lblColor.Text = $"Color: {VehicleColor}";
                        lblFuelType.Text = $"Fuel Type: {FuelType}";
                        lblSeats.Text = $"Seats: {Seats}";
                        lblMileage.Text = $"Mileage: {Mileage} km";
                        lblDailyPrice.Text = $"Php {PriceDaily}/day";
                        lblHourlyPrice.Text = $"Php {PriceHourly}/hr";

                        //convert image from database to PictureBox
                        VehicleImage = null;
                        if (!Convert.IsDBNull(reader["VehicleImage"])) //check if image is not NULL
                        {
                            byte[] imageData = (byte[])reader["VehicleImage"];
                            using (MemoryStream? ms = new MemoryStream(imageData))
                            {
                                VehicleImage = Image.FromStream(ms);
                            }
                        }

                        double vehicleRating = Convert.ToDouble(reader["VehicleRating"]);
                        lblVehicleRating.Text = $"Rating: {vehicleRating.ToString()}";

                        if (VehicleImage != null)
                            picVehicleImage.Image = VehicleImage;
                        else
                            picVehicleImage.Image = Properties.Resources.Car___MainLR;

                        //OWNER
                        Username = reader["Username"].ToString();

                        FullName = reader["Fullname"].ToString();
                        Address = reader["Address"].ToString();
                        Birthday = reader["Birthday"].ToString();
                        Email = reader["Email"].ToString();

                        DriversLicenseID = reader["DriversLicenseID"].ToString();
                        ContactNumber = reader["ContactNumber"].ToString();
                        UserRating = Convert.ToDouble(reader["UserRating"]);

                        //convert image from database to PictureBox
                        ProfilePicture = null;
                        if (!Convert.IsDBNull(reader["ProfilePicture"])) //check if image is not NULL
                        {
                            byte[] imageData = (byte[])reader["ProfilePicture"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                ProfilePicture = Image.FromStream(ms);
                            }
                        }

                        lblUsername.Text = $"Username: {Username}";
                        lblUserRating.Text = $"Rating: {UserRating.ToString()}";

                        lblFullname.Text = $"Fullname: {FullName}";
                        lblAddress.Text = $"Address: {Address}";
                        lblBirthday.Text = $"Birthday: {Birthday}";
                        lblLicenseID.Text = $"Drivers License ID: {DriversLicenseID.ToString()}";
                        lblEmail.Text = $"Email: {Email}";
                        lblNumber.Text = $"Contact Number: {ContactNumber}";
                        lblOC.Text = "Owner";

                        if (ProfilePicture != null)
                            picProfilePicture.Image = ProfilePicture;
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
                lblUserRating.Visible = true;

                string displayQuery = $"SELECT GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage, VehicleRating, Username, Fullname, Address, Birthday, Email, DriversLicenseID, ContactNumber, UserRating, ProfilePicture, RentType, Duration, PaymentType, ChildSeat, SoundSystem, Powerbank, WiFi, Notes, Price FROM ClientVehicleQuery WHERE VehicleID = {SystemManager.currentFullDetailsVehicleID}";

                using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
                {
                    connection.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //VEHICLE
                        GeneralType = reader["GeneralType"].ToString();
                        SpecificType = reader["SpecificType"].ToString();
                        Make = reader["Make"].ToString();

                        Model = reader["Model"].ToString();
                        VehicleYear = Convert.ToInt32(reader["VehicleYear"]);
                        Transmission = reader["Transmission"].ToString();
                        Drivetrain = reader["Drivetrain"].ToString();

                        LicensePlate = reader["LicensePlate"].ToString();
                        VehicleColor = reader["Color"].ToString();
                        FuelType = reader["FuelType"].ToString();

                        Seats = Convert.ToInt32(reader["Seats"]);
                        Mileage = Convert.ToDouble(reader["Mileage"]);
                        PriceDaily = Convert.ToDouble(reader["PriceDaily"]);
                        PriceHourly = Convert.ToDouble(reader["PriceHourly"]);

                        RentType = reader["RentType"].ToString();
                        Duration = Convert.ToInt32(reader["Duration"]);
                        PaymentType = reader["PaymentType"].ToString();
                        ChildSeat = reader["ChildSeat"].ToString();
                        SoundSystem = reader["SoundSystem"].ToString();
                        Powerbank = reader["Powerbank"].ToString();
                        WiFi = reader["WiFi"].ToString();
                        Notes = reader["Notes"].ToString();
                        TotalPrice = Convert.ToDouble(reader["Price"]);

                        lblType.Text = $"Type: {GeneralType} ({SpecificType})";
                        lblMake.Text = $"Make: {Make}";
                        lblModel.Text = $"Model: {Model} ({VehicleYear})";
                        lblTransmission.Text = $"Transmission: {Transmission}";
                        lblDrivetrain.Text = $"Drivetrain: {Drivetrain}";
                        lblLicensePlate.Text = $"License Plate No: {LicensePlate}";
                        lblColor.Text = $"Color: {VehicleColor}";
                        lblFuelType.Text = $"Fuel Type: {FuelType}";
                        lblSeats.Text = $"Seats: {Seats}";
                        lblMileage.Text = $"Mileage: {Mileage} km";
                        lblDailyPrice.Text = $"Php {PriceDaily}/day";
                        lblHourlyPrice.Text = $"Php {PriceHourly}/hr";
                        lblOC.Text = "Client";

                        lblDuration.Text = $"Duration: {Duration} {RentType}";
                        lblPayment.Text = $"Payment Type: {PaymentType}";
                        lblExtras.Text = $"Extras: ";
                        if (ChildSeat != "None")
                            lblExtras.Text += $"{ChildSeat} ";
                        if (SoundSystem != "Basic")
                            lblExtras.Text += $"{SoundSystem} ";
                        if (Powerbank != "None")
                            lblExtras.Text += $"{Powerbank} ";
                        if (WiFi != "None")
                            lblExtras.Text += $"{WiFi}";
                        lblNotes.Text = $"Additional notes: {Notes}";
                        lblTotalPrice.Text = $"Php {TotalPrice}";

                        //convert image from database to PictureBox
                        VehicleImage = null;
                        if (!Convert.IsDBNull(reader["VehicleImage"])) //check if image is not NULL
                        {
                            byte[] imageData = (byte[])reader["VehicleImage"];
                            using (MemoryStream? ms = new MemoryStream(imageData))
                            {
                                VehicleImage = Image.FromStream(ms);
                            }
                        }

                        VehicleRating = Convert.ToDouble(reader["VehicleRating"]);
                        lblVehicleRating.Text = $"Rating: {VehicleRating.ToString()}";

                        if (VehicleImage != null)
                            picVehicleImage.Image = VehicleImage;
                        else
                            picVehicleImage.Image = Properties.Resources.Car___MainLR;

                        //OWNER
                        Username = reader["Username"].ToString();

                        FullName = reader["Fullname"].ToString();
                        Address = reader["Address"].ToString();
                        Birthday = reader["Birthday"].ToString();
                        Email = reader["Email"].ToString();

                        DriversLicenseID = reader["DriversLicenseID"].ToString();
                        ContactNumber = reader["ContactNumber"].ToString();
                        UserRating = Convert.ToDouble(reader["UserRating"]);

                        //convert image from database to PictureBox
                        ProfilePicture = null;
                        if (!Convert.IsDBNull(reader["ProfilePicture"])) //check if image is not NULL
                        {
                            byte[] imageData = (byte[])reader["ProfilePicture"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                ProfilePicture = Image.FromStream(ms);
                            }
                        }

                        lblUsername.Text = $"Username: {Username}";
                        lblUserRating.Text = $"Rating: {UserRating.ToString()}";

                        lblFullname.Text = $"Fullname: {FullName}";
                        lblAddress.Text = $"Address: {Address}";
                        lblBirthday.Text = $"Birthday: {Birthday}";
                        lblLicenseID.Text = $"Drivers License ID: {DriversLicenseID.ToString()}";
                        lblEmail.Text = $"Email: {Email}";
                        lblNumber.Text = $"Contact Number: {ContactNumber}";

                        if (ProfilePicture != null)
                            picProfilePicture.Image = ProfilePicture;
                        else
                            picProfilePicture.Image = Properties.Resources.Avatar;
                    }

                    connection.Close();
                }
            }
        }

        private void picBack_Click(object sender, EventArgs e) //NAVIGATION EVENT: Exit
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e) //SUPPORTING EVENT: Fade-in animation
        {
            Opacity += 0.1;
            if (Opacity >= 1)
                tmrFadeIn.Stop();
        }

        /*
        //singleton
        //nvm useless mas chuy if dialog
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