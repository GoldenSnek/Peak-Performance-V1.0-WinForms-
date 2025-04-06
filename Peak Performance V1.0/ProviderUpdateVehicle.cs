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
    public partial class ProviderUpdateVehicle : Form, IProviderUpdateVehicle
    {
        private OleDbConnection connection;
        public ProviderUpdateVehicle()
        {
            SystemManager.currentEditVehicleID = 0;
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicles();
        }

        public VehicleCard VehicleCard
        {
            get => default;
            set
            {
            }
        }

        //EVENTS
        public void LoadVehicles() //INITIAL EVENT: Load the vehicle cards
        {
            flpDisplay.Controls.Clear();

            string displayQuery = "SELECT VehicleID, OwnerID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage, RentedBy, VehicleRating FROM Vehicles";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (SystemManager.currentUserID == Convert.ToInt32(reader["OwnerID"]))
                    { //only display if user owns the vehicle
                        int vehicleID = Convert.ToInt32(reader["VehicleID"]);
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

                        int rentedBy = Convert.ToInt32(reader["RentedBy"]);
                        double rating = Convert.ToDouble(reader["VehicleRating"]);

                        if (rentedBy == 0)
                        {
                            //create a VehicleCard and add it to the FlowLayoutPanel
                            VehicleCard card = new VehicleCard(this, vehicleID, generalType, specificType, make, model, vehicleYear, transmission, drivetrain, licensePlate,
                               color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, rating, "Edit");
                            card.EditClicked += Card_EditClicked;
                            card.FullDetailsClicked += Card_FullDetailsClicked;
                            card.DeleteClicked += Card_DeleteClicked;
                            flpDisplay.Controls.Add(card);
                        }
                    }
                }

                connection.Close();
            }
        }
        public void btnUpdate_Click(object sender, EventArgs e) //MAIN EVENT: Update details
        {
            string generalType = cbxGeneralType.Text;
            string specificType = cbxSpecificType.Text;
            string make = txtMake.Text;
            string model = txtModel.Text;
            string tempYear = cbxYear.Text;
            string licensePlate = txtLicense.Text;
            string transmission = cbxTransmission.Text;
            string drivetrain = cbxDrivetrain.Text;
            string color = cbxColor.Text;
            string fuelType = cbxFuel.Text;
            string tempSeats = cbxSeats.Text;
            string tempMileage = txtMileage.Text;
            string tempPriceDaily = txtPriceDaily.Text;
            string tempPriceHourly = txtPriceHourly.Text;
            string imagePath = lblImagePath.Text; //path of the selected image
            int year;
            int seats;
            double mileage;
            double priceDaily;
            double priceHourly;
            byte[] imageBytes = null;

            if (SystemManager.currentEditVehicleID == 0)
            {
                MessageBox.Show("Please choose a vehicle to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(generalType) || string.IsNullOrWhiteSpace(specificType) || string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(tempYear) || string.IsNullOrWhiteSpace(transmission) || string.IsNullOrWhiteSpace(drivetrain) || string.IsNullOrWhiteSpace(licensePlate) || string.IsNullOrWhiteSpace(color) ||
                string.IsNullOrWhiteSpace(fuelType) || string.IsNullOrWhiteSpace(tempSeats) || string.IsNullOrWhiteSpace(tempMileage) || string.IsNullOrWhiteSpace(tempPriceDaily) || string.IsNullOrWhiteSpace(tempPriceDaily)) //step 1: check if fields are empty
            {
                MessageBox.Show("Please fill in all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(tempYear, out year) || year < 1900 || year > 2025) //step 3: validate year
            {
                MessageBox.Show("Invalid year.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!int.TryParse(tempSeats, out seats) || seats < 1 || seats > 50) //step 4: validate seats
            {
                MessageBox.Show("Invalid number of seats.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!double.TryParse(tempMileage, out mileage) || mileage < 0 || mileage > 9999999999) //step 5: validate mileage
            {
                MessageBox.Show("Invalid mileage.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!double.TryParse(tempPriceDaily, out priceDaily) || priceDaily < 100 || priceDaily > 100000) //step 6: validate daily price
            {
                MessageBox.Show("Daily price must be between 100 Php and 100,000 Php.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!double.TryParse(tempPriceHourly, out priceHourly) || priceHourly < 10 || priceHourly > 10000) //step 7: validate hourly price
            {
                MessageBox.Show("Hourly price must be between 10 Php and 10,000 Php.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(imagePath)) //if a new image is selected
            {
                imageBytes = File.ReadAllBytes(imagePath);
            }
            else if (picPreview.Image == null) //if an image exists in the PictureBox
            {
                MessageBox.Show("Please upload an image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand cmdGetImage = new OleDbCommand("SELECT VehicleImage FROM Vehicles WHERE VehicleID = @vehicleID", connection))
                    {
                        cmdGetImage.Parameters.AddWithValue("@vehicleID", SystemManager.currentEditVehicleID);
                        object existingImage = cmdGetImage.ExecuteScalar();
                        if (existingImage != DBNull.Value)
                            imageBytes = (byte[])existingImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    connection.Close(); // Ensure connection is closed
                }
            }

            string updateQuery = $"UPDATE Vehicles SET GeneralType = @generalType, SpecificType = @specificType, Make = @make, Model = @model, VehicleYear = @year, Transmission = @transmission, Drivetrain = @drivetrain, LicensePlate = @licensePlate, [Color] = @color, FuelType = @fuelType, Seats = @seats, Mileage = @mileage, PriceDaily = @priceDaily, PriceHourly = @priceHourly, VehicleImage = @imagePath WHERE VehicleID = {SystemManager.currentEditVehicleID}";
            using (OleDbCommand cmd = new OleDbCommand(updateQuery, connection))
            {
                cmd.Parameters.AddWithValue("@generalType", generalType);
                cmd.Parameters.AddWithValue("@specificType", specificType);
                cmd.Parameters.AddWithValue("@make", make);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@transmission", transmission);
                cmd.Parameters.AddWithValue("@drivetrain", drivetrain);
                cmd.Parameters.AddWithValue("@licensePlate", licensePlate);
                cmd.Parameters.AddWithValue("@color", color);
                cmd.Parameters.AddWithValue("@fuelType", fuelType);
                cmd.Parameters.AddWithValue("@seats", seats);
                cmd.Parameters.AddWithValue("@mileage", mileage);
                cmd.Parameters.AddWithValue("@priceDaily", priceDaily);
                cmd.Parameters.AddWithValue("@priceHourly", priceHourly);
                cmd.Parameters.AddWithValue("@imagePath", imageBytes);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVehicles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating: " + ex.Message);
                    return;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void btnDelete_Click(object sender, EventArgs e) //MAIN EVENT: Delete vehicle
        {
        }

        //SUPPORTING EVENTS
        public void Card_EditClicked(int vehicleID, string generalType, string specificType, string make, string model, int? vehicleYear, string transmission, string drivetrain,
                                    string licensePlate, string color, string fuelType, int? seats, double? mileage, double? priceDaily, double? priceHourly, Image vehicleImage) { //SUPPORTING EVENT: Transfer details of card to the form 
            SystemManager.currentEditVehicleID = vehicleID;
            cbxGeneralType.Text = generalType;
            cbxSpecificType.Text = specificType;
            txtMake.Text = make;
            txtModel.Text = model;
            cbxYear.Text = vehicleYear.ToString();
            cbxTransmission.Text = transmission;
            cbxDrivetrain.Text = drivetrain;
            txtLicense.Text = licensePlate;
            cbxColor.Text = color;
            cbxFuel.Text = fuelType;
            cbxSeats.Text = seats.ToString();
            txtMileage.Text = mileage.ToString();
            txtPriceDaily.Text = priceDaily.ToString();
            txtPriceHourly.Text = priceHourly.ToString();
            picPreview.Image = vehicleImage;
        }



        public void Card_FullDetailsClicked(int vehicleID) { //SUPPORTING EVENT: Full Details
            SystemManager.currentFullDetailsVehicleID = vehicleID;
            Form formBackground = new Form();
            using (FullVehicleDetails detailsForm = new FullVehicleDetails("Owner"))
            {
                formBackground.StartPosition = FormStartPosition.Manual;
                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .70d;
                formBackground.BackColor = Color.Black;
                formBackground.WindowState = FormWindowState.Maximized;
                formBackground.TopMost = true;
                formBackground.Location = this.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();

                detailsForm.StartPosition = FormStartPosition.CenterParent;
                detailsForm.ShowDialog();

                formBackground.Dispose();
            }
        }

        public void Card_DeleteClicked(int vehicleID) //SUPPORTING EVENT: Delete
        {
            if (vehicleID == 0)
            {
                MessageBox.Show("Please choose a vehicle to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string deleteQuery = $"DELETE FROM Vehicles WHERE VehicleID = {vehicleID}";
            using (OleDbCommand cmd = new OleDbCommand(deleteQuery, connection))
            {
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("BYEBYE", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadVehicles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting" + ex.Message);
                    return;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e) //SUPPORTING EVENT: Browse and select an image
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picPreview.Image = Image.FromFile(openFileDialog.FileName);
                    lblImagePath.Text = openFileDialog.FileName; //store image path for later use
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e) //SUPPORTING EVENT: Clear all textboxes
        {
            cbxGeneralType.Text = string.Empty;
            cbxSpecificType.Text = string.Empty;
            txtMake.Text = string.Empty;
            txtModel.Text = string.Empty;
            cbxYear.Text = string.Empty;
            txtLicense.Text = string.Empty;
            cbxColor.Text = string.Empty;
            cbxFuel.Text = string.Empty;
            cbxSeats.Text = string.Empty;
            txtMileage.Text = string.Empty;
            txtPriceDaily.Text = string.Empty;
            txtPriceHourly.Text = string.Empty;
        }
        private void btnClearPicture_Click(object sender, EventArgs e) //SUPPORTING EVENT: Clear picture
        {
            picPreview.Image = null;
            lblImagePath.Text = null;
        }
    }
}
