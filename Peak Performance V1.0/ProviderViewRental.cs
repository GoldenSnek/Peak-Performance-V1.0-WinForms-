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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            string displayQuery = "SELECT Status, VehicleID, OwnerID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage FROM VehicleRentalQuery";

            using (OleDbCommand cmd = new OleDbCommand(displayQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string? status = reader["Status"].ToString();
                    int vehicleID = Convert.ToInt32(reader["VehicleID"]);
                    int ownerID = Convert.ToInt32(reader["OwnerID"]);
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
                    else
                    {
                        //set a default placeholder image
                    }

                    if (ownerID == SystemManager.currentUserID && status == "Unpaid")
                    {
                        VehicleCard card1 = new VehicleCard(vehicleID, generalType, specificType, make, model, vehicleYear, transmission, drivetrain, licensePlate,
                                                            color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "Approve");

                        card1.FullDetailsClickedRent += Card_FullDetailsClickedRent;
                        card1.ApproveClicked += Card_ApproveClicked;
                        flpWaitingApproval.Controls.Add(card1);

                    }
                    else if (ownerID == SystemManager.currentUserID && status == "Ongoing")
                    {
                        VehicleCard card2 = new VehicleCard(vehicleID, generalType, specificType, make, model, vehicleYear, transmission, drivetrain, licensePlate,
                                                            color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, "Finish Rental");

                        card2.FullDetailsClickedRent += Card_FullDetailsClickedRent;
                        card2.FinishRentalClicked += Card_FinishRentalClicked;
                        flpCurrentlyRented.Controls.Add(card2);
                    }

                }

                connection.Close();
            }
        }
        private void Card_FullDetailsClickedRent(int vehicleID) {
            SystemManager.currentFullDetailsVehicleID = vehicleID;
            Form formBackground = new Form();
            using (FullVehicleDetails detailsForm = new FullVehicleDetails("Client"))
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
        private void Card_ApproveClicked(int vehicleID)
        {
            SystemManager.currentFullDetailsVehicleID = vehicleID;
            string updateQuery = "UPDATE ClientVehicleQuery SET Status = @status, TotalRentals = TotalRentals + 1, UserTotalRentals = UserTotalRentals + 1, RentDate = @rentDate WHERE VehicleID = @vehicleID";
            string selectQuery = "SELECT TotalRentals, UserTotalRentals FROM ClientVehicleQuery WHERE VehicleID = @vehicleID";

            using (OleDbCommand cmd = new OleDbCommand(updateQuery, connection))
            {
                cmd.Parameters.AddWithValue("@status", "Ongoing");
                cmd.Parameters.AddWithValue("@rentDate", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@vehicleID", SystemManager.currentFullDetailsVehicleID);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental request accepted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    LoadVehicles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Card_FinishRentalClicked(int vehicleID)
        {
            SystemManager.currentFullDetailsVehicleID = vehicleID;
            string deleteQuery = $"DELETE FROM RentalDetails WHERE VehicleID = @vehicleID";
            using (OleDbCommand cmd = new OleDbCommand(deleteQuery, connection))
            {
                cmd.Parameters.AddWithValue("@vehicleID", SystemManager.currentFullDetailsVehicleID);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Finished rental!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string updateQuery = "UPDATE Vehicles SET RentedBy = @rentedBy WHERE VehicleID = @vehicleID";
            using (OleDbCommand cmd = new OleDbCommand(updateQuery, connection))
            {
                cmd.Parameters.AddWithValue("@rentedBy", 0);
                cmd.Parameters.AddWithValue("@vehicleID", SystemManager.currentFullDetailsVehicleID);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
                finally
                {
                    connection.Close();
                    LoadVehicles();
                    MessageBox.Show("test");
                }
            }
        }
    }
}
