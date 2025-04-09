using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Tagutils;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.StyledXmlParser.Jsoup.Nodes;
using OxyPlot;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Peak_Performance_V1._0
{
    public partial class ClientViewRental : Form, IClientViewRental
    {
        OleDbConnection connection;

        private PictureBox[] userStars;
        private PictureBox[] vehicleStars;
        private System.Drawing.Image starFilled = Properties.Resources.RateYes;
        private System.Drawing.Image starEmpty = Properties.Resources.RateNo;

        public int VehicleID { get; set; }
        public int OwnerID { get; set; }
        public double UserRating { get; set; }
        public double VehicleRating { get; set; }
        public bool CurrentRent { get; set; }

        string? ClientEmail;

        string? GeneralType;
        string? SpecificType;
        string? Make;
        string? Model;
        int VehicleYear;
        string? Transmission;
        string? Drivetrain;
        string? LicensePlate;
        string? VehicleColor;
        string? FuelType;
        int Seats;
        double Mileage;
        string? RentType;
        int Duration;
        string? PaymentType;
        string? ChildSeat;
        string? SoundSystem;
        string? Powerbank;
        string? Wifi;
        string? Notes;
        double TotalPrice;
        string? Username;
        string? FullName;
        string? Address;
        string? Birthday;
        string? Email;
        string? DriversLicenseID;
        string? ContactNumber;

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
            string rentQuery = "SELECT RentedBy, Email, Status FROM ClientVehicleQuery";

            using (OleDbCommand cmd = new OleDbCommand(rentQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rentedBy = Convert.ToInt32(reader["RentedBy"]);
                    ClientEmail = reader["Email"].ToString();
                    string? status = reader["Status"].ToString();

                    if (rentedBy == SystemManager.currentUserID)
                    {
                        if (status == "Unpaid")
                        {
                            lblNoRent.Text = "Your vehicle rental process is currently pending.";
                            connection.Close();
                            CurrentRent = false;
                            break;
                        }
                        else
                        {
                            connection.Close();
                            CurrentRent = true;
                            break;
                        }
                    }
                }
                connection.Close();
            }
            if (CurrentRent == false)
            {
                SetAllControlsInvisible(this);
                panel6.Visible = true;
                panel4.Visible = true;
                panel3.Visible = true;
                panel5.Visible = true;
                picNoRent.Visible = true;
                pnlNoRent.Visible = true;
                lblNoRent.Visible = true;
                pnlNoRent.Location = new Point(44, 98);
            }
            else
            {
                pnlNoRent.Visible = false;
                lblNoRent.Visible = false;
            }
        }
        private void SetAllControlsInvisible(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control == pnlNoRent || control == picNoRent)
                    continue;

                control.Visible = false;

                if (control.HasChildren)
                    SetAllControlsInvisible(control);
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

                    RentType = reader["RentType"].ToString();
                    Duration = Convert.ToInt32(reader["Duration"]);
                    PaymentType = reader["PaymentType"].ToString();
                    ChildSeat = reader["ChildSeat"].ToString();
                    SoundSystem = reader["SoundSystem"].ToString();
                    Powerbank = reader["Powerbank"].ToString();
                    Wifi = reader["WiFi"].ToString();
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

                    lblDuration.Text = $"Duration: {Duration} {RentType}";
                    lblPayment.Text = $"Payment Type: {PaymentType}";
                    lblExtras.Text = $"Extras: ";
                    if (ChildSeat != "None")
                        lblExtras.Text += $"{ChildSeat} ";
                    if (SoundSystem != "Basic")
                        lblExtras.Text += $"{SoundSystem} ";
                    if (Powerbank != "None")
                        lblExtras.Text += $"{Powerbank} ";
                    if (Wifi != "None")
                        lblExtras.Text += $"{Wifi}";
                    lblNotes.Text = $"Additional notes: {Notes}";
                    lblTotalPrice.Text = $"Php {TotalPrice}";

                    //convert image from database to PictureBox
                    System.Drawing.Image? vehicleImage = null;
                    if (!Convert.IsDBNull(reader["VehicleImage"])) //check if image is not NULL
                    {
                        byte[] imageData = (byte[])reader["VehicleImage"];
                        using (MemoryStream? ms = new MemoryStream(imageData))
                        {
                            vehicleImage = System.Drawing.Image.FromStream(ms);
                        }
                    }

                    double vehicleRating = Convert.ToDouble(reader["VehicleRating"]);
                    lblVehicleRating.Text = $"Rating: {vehicleRating.ToString()}";

                    if (vehicleImage != null)
                        picVehicleImage.Image = vehicleImage;
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
                    System.Drawing.Image? profilePicture = null;
                    if (!Convert.IsDBNull(reader["ProfilePicture"])) //check if image is not NULL
                    {
                        byte[] imageData = (byte[])reader["ProfilePicture"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            profilePicture = System.Drawing.Image.FromStream(ms);
                        }
                    }

                    lblUsername.Text = $"Username: {Username}";
                    lblUserRating.Text = $"Rating: {UserRating.ToString()}";

                    lblFullname.Text = $"Fullname: {FullName}";
                    lblAddress.Text = $"Address: {Address}";
                    lblBirthday.Text = $"Birthday: {Birthday}";
                    lblLicenseID.Text = $"Drivers License ID: {DriversLicenseID}";
                    lblEmail.Text = $"Email: {Email}";
                    lblNumber.Text = $"Contact Number: {ContactNumber}";

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
                double userGivenRating = UserRating;
                double vehicleGivenRating = VehicleRating;

                userRaters += 1;
                userTotalRatings += (int)userGivenRating;
                userRating = Math.Round((double)userTotalRatings / userRaters, 2);

                vehicleRaters += 1;
                vehicleTotalRatings += (int)vehicleGivenRating;
                vehicleRating = Math.Round((double)vehicleTotalRatings / vehicleRaters, 2);

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

        private void HighlightStars(PictureBox[] stars, double count) //SUPPORTING EVENT: Color the stars
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

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                //check for internet connectivity first
                if (!CheckForInternetConnection())
                {
                    MessageBox.Show("No internet connection detected. Please connect to the internet and try again.",
                        "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //validate email address
                string recipientEmail = ClientEmail;
                if (!IsValidEmail(recipientEmail))
                {
                    MessageBox.Show("The recipient email address appears to be invalid. Please check and try again.",
                        "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //create the PDF and store it in a byte array
                byte[] pdfBytes;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (PdfWriter writer = new PdfWriter(memoryStream))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (iText.Layout.Document doc = new iText.Layout.Document(pdf))
                    {
                        PdfFont font = PdfFontFactory.CreateFont(@"C:\Windows\Fonts\arial.ttf", PdfEncodings.WINANSI);
                        PdfFont boldFont = PdfFontFactory.CreateFont(@"C:\Windows\Fonts\arialbd.ttf", PdfEncodings.WINANSI);

                        doc.Add(new Paragraph("PEAK PERFORMANCE | VEHICLE RENTAL")
                            .SetFont(boldFont)
                            .SetFontSize(20)
                            .SetTextAlignment(TextAlignment.CENTER));

                        doc.Add(new Paragraph("Receipt")
                            .SetFont(boldFont)
                            .SetFontSize(16)
                            .SetTextAlignment(TextAlignment.CENTER));

                        doc.Add(new Paragraph($"Date: {DateTime.Now:MMMM dd, yyyy}").SetFont(font));

                        doc.Add(new Paragraph("Vehicle Details").SetFont(boldFont).SetUnderline());
                        doc.Add(new Paragraph($"Make: {Make}").SetFont(font));
                        doc.Add(new Paragraph($"Model: {Model} ({VehicleYear})").SetFont(font));
                        doc.Add(new Paragraph($"Color: {VehicleColor}").SetFont(font));
                        doc.Add(new Paragraph($"Transmission: {Transmission}").SetFont(font));
                        doc.Add(new Paragraph($"Fuel Type: {FuelType}").SetFont(font));
                        doc.Add(new Paragraph($"Seats: {Seats}").SetFont(font));
                        doc.Add(new Paragraph($"Duration: {Duration} {RentType}").SetFont(font));
                        doc.Add(new Paragraph($"Payment Type: {PaymentType}").SetFont(font));
                        doc.Add(new Paragraph($"Extras: {ChildSeat}, {SoundSystem}, {Powerbank}, {Wifi}").SetFont(font));
                        doc.Add(new Paragraph($"Notes: {Notes}").SetFont(font));
                        doc.Add(new Paragraph($"Total Price: Php {TotalPrice:N2}").SetFont(boldFont));

                        doc.Add(new Paragraph("Owner Details").SetFont(boldFont).SetUnderline());
                        doc.Add(new Paragraph($"Full Name: {FullName}").SetFont(font));
                        doc.Add(new Paragraph($"Email: {Email}").SetFont(font));
                        doc.Add(new Paragraph($"Contact: {ContactNumber}").SetFont(font));
                        doc.Add(new Paragraph($"Username: {Username}").SetFont(font));

                        doc.Close();
                    }

                    pdfBytes = memoryStream.ToArray();
                }

                this.Cursor = Cursors.WaitCursor;
                btnReceipt.Enabled = false;

                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress("PeakPerformanceNave@gmail.com");
                    message.To.Add(recipientEmail);
                    message.Subject = "Your Vehicle Rental Receipt";
                    message.Body = "Hello! Please find your receipt attached.\n\nThank you for renting with Peak Performance.";

                    using (MemoryStream attachmentStream = new MemoryStream(pdfBytes))
                    {
                        System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType("application/pdf");
                        contentType.Name = $"Receipt_{DateTime.Today:yyyy-MM-dd}.pdf";
                        Attachment attachment = new Attachment(attachmentStream, contentType);
                        message.Attachments.Add(attachment);

                        //send the email with timeout
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.EnableSsl = true;
                            smtp.Credentials = new NetworkCredential("PeakPerformanceNave@gmail.com", "reyy zptm tebv tghw");

                            //set timeout (10 seconds)
                            smtp.Timeout = 10000;

                            smtp.Send(message);
                        }
                    }
                }

                MessageBox.Show("Receipt sent successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                //handle specific SMTP exceptions
                if (ex.StatusCode == SmtpStatusCode.MailboxBusy ||
                    ex.StatusCode == SmtpStatusCode.MailboxUnavailable)
                {
                    MessageBox.Show("The recipient's mailbox is unavailable or busy. Please try again later.",
                        "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Timeout"))
                {
                    MessageBox.Show("The email server took too long to respond. Please check your internet connection and try again.",
                        "Timeout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Email sending failed: {ex.Message}",
                        "SMTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send receipt: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnReceipt.Enabled = true;
            }
        }

        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}