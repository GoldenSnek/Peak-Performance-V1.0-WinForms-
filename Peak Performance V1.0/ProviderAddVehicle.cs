﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; //for database connection
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Peak_Performance_V1._0
{
    public partial class ProviderAddVehicle : Form
    {

        private OleDbConnection connection;

        public ProviderAddVehicle()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicles();
        }

        //EVENTS
        private void LoadVehicles() //INITIAL EVENT: Load the vehicle cards
        {
            flpDisplay.Controls.Clear();

            string displayQuery = "SELECT UserID, GeneralType, SpecificType, Make, Model, VehicleYear, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage FROM Vehicles";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //pang butngan og ? pero walay warnings
                    if (SystemManager.currentUserID == Convert.ToInt32(reader["UserID"]))
                    { //only display if user owns the vehicle
                        string? generalType = reader["GeneralType"].ToString();
                        string? specificType = reader["SpecificType"].ToString();
                        string? make = reader["Make"].ToString();

                        string? model = reader["Model"].ToString();
                        int vehicleYear = Convert.ToInt32(reader["VehicleYear"]);

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
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                vehicleImage = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            //set a default placeholder image
                        }

                        //create a VehicleCard and add it to the FlowLayoutPanel
                        VehicleCard card = new VehicleCard(generalType, specificType, make, model, vehicleYear, licensePlate,
                               color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "");
                        flpDisplay.Controls.Add(card);
                    }
                }

                connection.Close();
            }
        }
        private void btnAddVehicle_Click(object sender, EventArgs e) //MAIN EVENT: Add a vehicle
        {
            string generalType = cbxGeneralType.Text;
            string specificType = cbxSpecificType.Text;
            string make = txtMake.Text;
            string model = txtModel.Text;
            string tempYear = cbxYear.Text;
            string licensePlate = txtLicense.Text;
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

            if (string.IsNullOrWhiteSpace(generalType) || string.IsNullOrWhiteSpace(specificType) || string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model) ||
                string.IsNullOrWhiteSpace(tempYear) || string.IsNullOrWhiteSpace(licensePlate) || string.IsNullOrWhiteSpace(color) || string.IsNullOrWhiteSpace(fuelType) ||
                string.IsNullOrWhiteSpace(tempSeats) || string.IsNullOrWhiteSpace(tempMileage) || string.IsNullOrWhiteSpace(tempPriceDaily) || string.IsNullOrWhiteSpace(tempPriceDaily)) //step 1: check if fields are empty
            {
                MessageBox.Show("Please fill in all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(imagePath)) //step 2: check if image is uploaded
            {
                MessageBox.Show("Please upload an image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            byte[] imageBytes = File.ReadAllBytes(imagePath); //convert image to byte array

            string addVehicleQuery = "INSERT INTO Vehicles (UserID, GeneralType, SpecificType, Make, Model, VehicleYear, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage) " +
                                     "VALUES (@userID, @generalType, @specificType, @make, @model, @year, @licensePlate, @color, @fuelType, @seats, @mileage, @priceDaily, @priceHourly, @imagePath)";

            using (OleDbCommand cmd = new OleDbCommand(addVehicleQuery, connection))
            {
                cmd.Parameters.AddWithValue("@userID", SystemManager.currentUserID);
                cmd.Parameters.AddWithValue("@generalType", generalType);
                cmd.Parameters.AddWithValue("@specificType", specificType);
                cmd.Parameters.AddWithValue("@make", make);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@year", year);
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
                    LoadVehicles();
                    MessageBox.Show("Vehicle added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting vehicle: " + ex.Message);
                    return;
                }
            }
        }

        //SUPPORTING EVENTS
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
            picPreview.Image = null;
            lblImagePath.Text = null;
        }
        private void btnClearPicture_Click(object sender, EventArgs e) //SUPPORTING EVENT: Clear picture
        {
            picPreview.Image = null;
            lblImagePath.Text = null;
        }
    }
}