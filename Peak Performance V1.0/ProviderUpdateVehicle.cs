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
