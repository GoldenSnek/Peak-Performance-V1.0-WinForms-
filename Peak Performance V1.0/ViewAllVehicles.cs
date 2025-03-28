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

        //EVENTS
        private void LoadVehicles() //INITIAL EVENT: Load the vehicle cards
        {
            flpDisplay.Controls.Clear();

            string displayQuery = "SELECT VehicleID, UserID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage FROM Vehicles";

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


                    //create a VehicleCard and add it to the FlowLayoutPanel
                    if (SystemManager.currentRole == "Vehicle Provider")
                    {
                        VehicleCard card = new VehicleCard(vehicleID, generalType, specificType, make, model, vehicleYear, transmission, drivetrain, licensePlate,
                                                           color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "");
                        card.FullDetailsClicked += Card_FullDetailsClicked;
                        flpDisplay.Controls.Add(card);
                    }
                    else if (SystemManager.currentRole == "Client")
                    {
                        VehicleCard card = new VehicleCard(vehicleID, generalType, specificType, make, model, vehicleYear, transmission, drivetrain, licensePlate,
                                   color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "Rent");
                        card.FullDetailsClicked += Card_FullDetailsClicked;
                        card.RentClicked += Card_RentClicked;
                        flpDisplay.Controls.Add(card);
                    }
                }

                connection.Close();
            }
        }
        private void Card_FullDetailsClicked(int vehicleID)
        {
            SystemManager.currentFullDetailsVehicleID = vehicleID;
            Form formBackground = new Form();
            using (FullVehicleDetails detailsForm = new FullVehicleDetails())
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
        private void Card_RentClicked(int vehicleID)
        {
            SystemManager.currentFullDetailsVehicleID = vehicleID;
            Form formBackground = new Form();
            using (RentVehicle rentForm = new RentVehicle())
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

                rentForm.StartPosition = FormStartPosition.CenterParent;
                rentForm.ShowDialog();

                formBackground.Dispose();
            }
        }
        private void btnClear_Click(object sender, EventArgs e) //EVENT: Clear
        {

        }
        private void btnApply_Click(object sender, EventArgs e) //EVENT: Apply
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            //slower version
            foreach (Control control in flpDisplay.Controls)
            {
                if (control is VehicleCard vehicleCard)
                {
                    // Search across multiple fields
                    bool isVisible = vehicleCard.GeneralType.ToLower().Contains(searchText) ||
                                     vehicleCard.SpecificType.ToLower().Contains(searchText) ||
                                     vehicleCard.Make.ToLower().Contains(searchText) ||
                                     vehicleCard.Model.ToLower().Contains(searchText) ||
                                     vehicleCard.VehicleYear.ToString().ToLower().Contains(searchText) ||
                                     vehicleCard.Transmission.ToLower().Contains(searchText) ||
                                     vehicleCard.Drivetrain.ToLower().Contains(searchText) ||
                                     vehicleCard.LicensePlate.ToLower().Contains(searchText) ||
                                     vehicleCard.VehicleColor.ToLower().Contains(searchText) ||
                                     vehicleCard.Seats.ToString().ToLower().Contains(searchText) ||
                                     vehicleCard.Mileage.ToString().ToLower().Contains(searchText) ||
                                     vehicleCard.PriceDaily.ToString().ToLower().Contains(searchText) ||
                                     vehicleCard.PriceHourly.ToString().ToLower().Contains(searchText) ||
                                     vehicleCard.Transmission.ToLower().Contains(searchText);

                    //animate smooth hiding/showing (optional)
                    if (isVisible && !vehicleCard.Visible)
                        vehicleCard.Show();
                    else if (!isVisible && vehicleCard.Visible)
                        vehicleCard.Hide();
                }
            }


            ////faster version
            //foreach (Control control in flpDisplay.Controls)
            //{
            //    if (control is VehicleCard vehicleCard)
            //    {
            //        //check if VehicleCard contains the search text
            //        bool isVisible = vehicleCard.Make.ToLower().Contains(searchText) ||
            //                         vehicleCard.Model.ToLower().Contains(searchText);

            //        //animate smooth hiding/showing (optional)
            //        if (isVisible && !vehicleCard.Visible)
            //            vehicleCard.Show();
            //        else if (!isVisible && vehicleCard.Visible)
            //            vehicleCard.Hide();
            //    }
            //}
        }
    }
}
