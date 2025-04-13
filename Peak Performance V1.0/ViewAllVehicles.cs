﻿using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; //for database connection
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Peak_Performance_V1._0
{
    public partial class ViewAllVehicles : Form, IViewAllVehicles
    {
        private OleDbConnection connection;
        public ViewAllVehicles()
        {
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

        public void LoadVehicles(string? filterQuery = null) //INITIAL METHOD: Load the vehicle cards
        {
            flpDisplay.Controls.Clear();
            int vehicleCount = 0;

            //default query (loads all vehicles)
            string baseQuery = "SELECT VehicleID, OwnerID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, [Color], FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage, RentedBy, VehicleRating FROM Vehicles";

            string displayQuery = null;

            if (string.IsNullOrEmpty(filterQuery))
                displayQuery = baseQuery;
            else
                displayQuery = filterQuery;

            //MessageBox.Show(baseQuery);
            //MessageBox.Show(displayQuery);

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

                    // Convert image from database to PictureBox
                    Image? vehicleImage = null;
                    if (!Convert.IsDBNull(reader["VehicleImage"]))
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
                        // Create VehicleCard and add it to FlowLayoutPanel
                        if (SystemManager.currentRole == "Vehicle Provider")
                        {
                            VehicleCard card = new VehicleCard(this, vehicleID, generalType, specificType, make, model, vehicleYear, transmission, drivetrain, licensePlate,
                                                               color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, rating, "");
                            card.FullDetailsClicked += Card_FullDetailsClicked;
                            flpDisplay.Controls.Add(card);
                            vehicleCount++;
                        }
                        else if (SystemManager.currentRole == "Client")
                        {
                            VehicleCard card = new VehicleCard(this, vehicleID, generalType, specificType, make, model, vehicleYear, transmission, drivetrain, licensePlate,
                                       color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, rating, "Rent");
                            card.FullDetailsClicked += Card_FullDetailsClicked;
                            card.RentClicked += Card_RentClicked;
                            flpDisplay.Controls.Add(card);
                            vehicleCount++;
                        }
                    }
                }

                if (vehicleCount == 0)
                {
                    lblTotal.ForeColor = Color.Red;
                    lblTotal.Text = $"No vehicles available";
                }
                else if (vehicleCount == 1)
                {
                    lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
                    lblTotal.Text = $"Showing {vehicleCount} vehicle";
                }
                else
                {
                    lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
                    lblTotal.Text = $"Showing {vehicleCount} vehicles";
                }

                connection.Close();
            }
        }

        public void Card_RentClicked(int vehicleID) //MAIN METHOD/EVENT: Rent
        {
            SystemManager.currentFullDetailsVehicleID = vehicleID;

            string rentQuery = "SELECT RentedBy FROM Vehicles";

            using (OleDbCommand cmd = new OleDbCommand(rentQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int rentedBy = Convert.ToInt32(reader["RentedBy"]);

                    if (rentedBy == SystemManager.currentUserID)
                    {
                        connection.Close();
                        using (ErrorMessage errorForm = new ErrorMessage($"Sorry, you can only rent 1 vehicle at a time."))
                        {
                            errorForm.ShowDialog();
                        }
                        return;
                    }
                }
                connection.Close();
            }

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
            if (SystemManager.refresh)
                LoadVehicles();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e) //MAIN EVENT: Searching
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            //slower version
            foreach (Control control in flpDisplay.Controls)
            {
                if (control is VehicleCard vehicleCard)
                {
                    //Super OP search pero basin lag if daghan vehicles?
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

                    if (isVisible && !vehicleCard.Visible)
                        vehicleCard.Show();
                    else if (!isVisible && vehicleCard.Visible)
                        vehicleCard.Hide();
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e) //MAIN EVENT: Filtering
        {
            List<string> filters = new List<string>();

            List<string> generalTypeFilters = new List<string>();
            if (btnCar.Tag?.ToString() == "selected")
                generalTypeFilters.Add("GeneralType = 'Car'");
            if (btnMotorcycle.Tag?.ToString() == "selected")
                generalTypeFilters.Add("GeneralType = 'Motorcycle'");
            if (generalTypeFilters.Count > 0)
                filters.Add($"({string.Join(" OR ", generalTypeFilters)})");

            if (btnY1.Tag?.ToString() == "selected")
                filters.Add("VehicleYear BETWEEN 1900 AND 1949");
            if (btnY2.Tag?.ToString() == "selected")
                filters.Add("VehicleYear BETWEEN 1950 AND 1999");
            if (btnY3.Tag?.ToString() == "selected")
                filters.Add("VehicleYear BETWEEN 2000 AND 2019");
            if (btnY4.Tag?.ToString() == "selected")
                filters.Add("VehicleYear BETWEEN 2020 AND 2025");

            List<string> transmissionFilters = new List<string>();
            if (btnManual.Tag?.ToString() == "selected")
                transmissionFilters.Add("Transmission = 'Manual'");
            if (btnAutomatic.Tag?.ToString() == "selected")
                transmissionFilters.Add("Transmission = 'Automatic'");
            if (transmissionFilters.Count > 0)
                filters.Add($"({string.Join(" OR ", transmissionFilters)})");

            List<string> drivetrainFilters = new List<string>();
            if (btnFWD.Tag?.ToString() == "selected")
                drivetrainFilters.Add("Drivetrain = 'Front-wheel drive'");
            if (btnRWD.Tag?.ToString() == "selected")
                drivetrainFilters.Add("Drivetrain = 'Rear-wheel drive'");
            if (btn4WD.Tag?.ToString() == "selected")
                drivetrainFilters.Add("Drivetrain = '4-wheel drive'");
            if (btnAWD.Tag?.ToString() == "selected")
                drivetrainFilters.Add("Drivetrain = 'All-wheel drive'");
            if (drivetrainFilters.Count > 0)
                filters.Add($"({string.Join(" OR ", drivetrainFilters)})");

            if (btnS1.Tag?.ToString() == "selected")
                filters.Add("Seats BETWEEN 1 AND 2");
            if (btnS2.Tag?.ToString() == "selected")
                filters.Add("Seats BETWEEN 3 AND 5");
            if (btnS3.Tag?.ToString() == "selected")
                filters.Add("Seats BETWEEN 6 AND 9");
            if (btnS4.Tag?.ToString() == "selected")
                filters.Add("Seats BETWEEN 10 AND 50");

            string sortOrder = toggleSort.Checked ? "DESC" : "ASC";
            string sortBy = null;
            if (cbxSort.Text == "Make")
                sortBy = "Make";
            else if (cbxSort.Text == "Model")
                sortBy = "Model";
            else if (cbxSort.Text == "Vehicle Year")
                sortBy = "VehicleYear";
            else if (cbxSort.Text == "Seats")
                sortBy = "Seats";
            else if (cbxSort.Text == "Mileage")
                sortBy = "Mileage";
            else if (cbxSort.Text == "Daily Price")
                sortBy = "PriceDaily";
            else if (cbxSort.Text == "Hourly Price")
                sortBy = "PriceHourly";
            else if (cbxSort.Text == "Rating")
                sortBy = "VehicleRating";

            string query = "SELECT VehicleID, OwnerID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, [Color], FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage, RentedBy, VehicleRating FROM Vehicles";
            if (filters.Count > 0)
                query += " WHERE " + string.Join(" AND ", filters);
            if (sortBy != null && sortBy != "Default")
                query += $" ORDER BY {sortBy} {sortOrder}";

            LoadVehicles(query);
        }

        public void Card_FullDetailsClicked(int vehicleID) //SUPPORTING METHOD/EVENT: Full Details
        {
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

        private void btnClear_Click(object sender, EventArgs e) //SUPPORTING EVENT: Clear Filters
        {
            cbxSort.Text = "Default";

            btnCar.ForeColor = Color.Lavender;
            btnCar.Tag = null;

            btnMotorcycle.ForeColor = Color.Lavender;
            btnMotorcycle.Tag = null;

            btnY1.ForeColor = Color.Lavender;
            btnY1.Tag = null;

            btnY2.ForeColor = Color.Lavender;
            btnY2.Tag = null;

            btnY3.ForeColor = Color.Lavender;
            btnY3.Tag = null;

            btnY4.ForeColor = Color.Lavender;
            btnY4.Tag = null;

            btnManual.ForeColor = Color.Lavender;
            btnManual.Tag = null;

            btnAutomatic.ForeColor = Color.Lavender;
            btnAutomatic.Tag = null;

            btnFWD.ForeColor = Color.Lavender;
            btnFWD.Tag = null;

            btnRWD.ForeColor = Color.Lavender;
            btnRWD.Tag = null;

            btn4WD.ForeColor = Color.Lavender;
            btn4WD.Tag = null;

            btnAWD.ForeColor = Color.Lavender;
            btnAWD.Tag = null;

            btnS1.ForeColor = Color.Lavender;
            btnS1.Tag = null;

            btnS2.ForeColor = Color.Lavender;
            btnS2.Tag = null;

            btnS3.ForeColor = Color.Lavender;
            btnS3.Tag = null;

            btnS4.ForeColor = Color.Lavender;
            btnS4.Tag = null;
            LoadVehicles();
        }

        //METHODS
        private void GlowButton_Click(object sender, EventArgs e) //SUPPORTING METHOD: Change state of buttons
        {
            CyberButton button = (CyberButton)sender;
            if (button.TextButton == "1900-1949")
            {
                btnY2.ForeColor = Color.Lavender;
                btnY2.Tag = null;
                btnY3.ForeColor = Color.Lavender;
                btnY3.Tag = null;
                btnY4.ForeColor = Color.Lavender;
                btnY4.Tag = null;
            }
            else if (button.TextButton == "1950-1999")
            {
                btnY1.ForeColor = Color.Lavender;
                btnY1.Tag = null;
                btnY3.ForeColor = Color.Lavender;
                btnY3.Tag = null;
                btnY4.ForeColor = Color.Lavender;
                btnY4.Tag = null;
            }
            else if (button.TextButton == "2000-2019")
            {
                btnY2.ForeColor = Color.Lavender;
                btnY2.Tag = null;
                btnY1.ForeColor = Color.Lavender;
                btnY1.Tag = null;
                btnY4.ForeColor = Color.Lavender;
                btnY4.Tag = null;
            }
            else if (button.TextButton == "2020-2025")
            {
                btnY2.ForeColor = Color.Lavender;
                btnY2.Tag = null;
                btnY3.ForeColor = Color.Lavender;
                btnY3.Tag = null;
                btnY1.ForeColor = Color.Lavender;
                btnY1.Tag = null;
            }

            if (button.TextButton == "1-2")
            {
                btnS2.ForeColor = Color.Lavender;
                btnS2.Tag = null;
                btnS3.ForeColor = Color.Lavender;
                btnS3.Tag = null;
                btnS4.ForeColor = Color.Lavender;
                btnS4.Tag = null;
            }
            else if (button.TextButton == "3-5")
            {
                btnS1.ForeColor = Color.Lavender;
                btnS1.Tag = null;
                btnS3.ForeColor = Color.Lavender;
                btnS3.Tag = null;
                btnS4.ForeColor = Color.Lavender;
                btnS4.Tag = null;
            }
            else if (button.TextButton == "6-9")
            {
                btnS2.ForeColor = Color.Lavender;
                btnS2.Tag = null;
                btnS1.ForeColor = Color.Lavender;
                btnS1.Tag = null;
                btnS4.ForeColor = Color.Lavender;
                btnS4.Tag = null;
            }
            else if (button.TextButton == "10-50")
            {
                btnS2.ForeColor = Color.Lavender;
                btnS2.Tag = null;
                btnS3.ForeColor = Color.Lavender;
                btnS3.Tag = null;
                btnS1.ForeColor = Color.Lavender;
                btnS1.Tag = null;
            }

            if (button.Tag != null && button.Tag.ToString() == "selected")
            {
                button.Tag = "unselected";
                button.ForeColor = Color.Lavender;
            }
            else
            {
                button.Tag = "selected";
                button.ForeColor = Color.FromArgb(255, 128, 0);
            }
        }
    }
}