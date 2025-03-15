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
    public partial class ProviderUpdateVehicle : Form
    {
        private OleDbConnection connection;

        public ProviderUpdateVehicle()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicles();
        }
        private void LoadVehicles()
        {
            flpDisplay.Controls.Clear();

            string displayQuery = "SELECT UserID, GeneralType, SpecificType, Make, Model, VehicleYear, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage FROM Vehicles";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
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
                        VehicleCard card = new VehicleCard(generalType, specificType, make, model, vehicleYear, licensePlate,
                               color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "Edit");
                        flpDisplay.Controls.Add(card);
                    }
                }

                connection.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
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
            lblImagePath.Text = "Path";
        }
    }
}
