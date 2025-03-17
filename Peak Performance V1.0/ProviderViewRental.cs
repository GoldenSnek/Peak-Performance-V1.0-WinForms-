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
    public partial class ProviderViewRental : Form
    {
        private OleDbConnection connection;
        public ProviderViewRental()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicles();
        }

        //EVENTS
        private void LoadVehicles() //INITIAL EVENT: Load the vehicle cards
        {
            flpWaitingApproval.Controls.Clear();
            flpCurrentlyRented.Controls.Clear();

            string displayQuery = "SELECT GeneralType, SpecificType, Make, Model, VehicleYear, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage FROM Vehicles";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
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

                    VehicleCard card1 = new VehicleCard(generalType, specificType, make, model, vehicleYear, licensePlate,
                                                        color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "Approve");
                    flpWaitingApproval.Controls.Add(card1);
                    VehicleCard card2 = new VehicleCard(generalType, specificType, make, model, vehicleYear, licensePlate,
                                                        color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "Approve");
                    flpCurrentlyRented.Controls.Add(card2);

                }

                connection.Close();
            }
        }
    }
}
