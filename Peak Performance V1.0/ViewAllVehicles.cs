using System;
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

        private void LoadVehicles()
        {
            flowLayoutPanel1.Controls.Clear();

            string displayQuery = "SELECT GeneralType, SpecificType, Make, Model, VehicleYear, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage FROM Vehicles";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string generalType = reader["GeneralType"].ToString();
                    string specificType = reader["SpecificType"].ToString();
                    string make = reader["Make"].ToString();

                    string model = reader["Model"].ToString();
                    int vehicleYear = Convert.ToInt32(reader["VehicleYear"]);

                    string licensePlate = reader["LicensePlate"].ToString();
                    string color = reader["Color"].ToString();
                    string fuelType = reader["FuelType"].ToString();

                    int seats = Convert.ToInt32(reader["Seats"]);
                    double mileage = Convert.ToDouble(reader["Mileage"]);
                    double priceDaily = Convert.ToDouble(reader["PriceDaily"]);
                    double priceHourly = Convert.ToDouble(reader["PriceHourly"]);


                    //onvert image from database to PictureBox
                    Image vehicleImage = null;
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
                           color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage);
                    flowLayoutPanel1.Controls.Add(card);
                }

                connection.Close();
            }
        }


    }
}
