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


namespace Peak_Performance_V1._0
{
    public partial class ViewAllVehicles : Form
    {
        private OleDbConnection connection;
        public ViewAllVehicles()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicles();
        }

        //EVENTS
        private void LoadVehicles() //INITIAL EVENT: Load the vehicle cards
        {
            flpDisplay.Controls.Clear();

            string displayQuery = "SELECT VehicleID, GeneralType, SpecificType, Make, Model, VehicleYear, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage FROM Vehicles";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int vehicleID = Convert.ToInt32(reader["VehicleID"]);
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
                        using (MemoryStream? ms = new MemoryStream(imageData))
                        {
                            vehicleImage = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        //set a default placeholder image
                    }


                    //create a VehicleCard and add it to the FlowLayoutPanel
                    if (SystemManager.currentRole == "Vehicle Provider")
                    {
                        VehicleCard card = new VehicleCard(vehicleID, generalType, specificType, make, model, vehicleYear, licensePlate,
                                                           color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "");
                        flpDisplay.Controls.Add(card);
                    }
                    else if (SystemManager.currentRole == "Client")
                    {
                        VehicleCard card = new VehicleCard(vehicleID, generalType, specificType, make, model, vehicleYear, licensePlate,
                                   color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "Rent");
                        flpDisplay.Controls.Add(card);
                    }
                }

                connection.Close();
            }
        }
        private void btnClear_Click(object sender, EventArgs e) //EVENT: Clear
        {

        }
        private void btnApply_Click(object sender, EventArgs e) //EVENT: Apply
        {

        }
    }
}
