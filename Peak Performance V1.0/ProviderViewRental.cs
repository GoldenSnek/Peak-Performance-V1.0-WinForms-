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
using OxyPlot;
using OxyPlot.Series;

namespace Peak_Performance_V1._0
{
    public partial class ProviderViewRental : Form, IProviderViewRental
    {
        private OleDbConnection connection;
        public ProviderViewRental()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadVehicles();
        }

        public void LoadVehicles() //INITIAL METHOD: Load the vehicle cards
        {
            flpWaitingApproval.Controls.Clear();
            flpCurrentlyRented.Controls.Clear();
            string displayQuery = "SELECT Status, VehicleID, OwnerID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, Color, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage, VehicleRating FROM VehicleRentalQuery";

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

                    double rating = Convert.ToDouble(reader["VehicleRating"]);

                    if (ownerID == SystemManager.currentUserID && status == "Unpaid")
                    {
                        VehicleCard card1 = new VehicleCard(this, vehicleID, generalType, specificType, make, model, vehicleYear, transmission, drivetrain, licensePlate,
                                                            color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, rating, "Approve");

                        card1.FullDetailsClickedRent += Card_FullDetailsClickedRent;
                        card1.ApproveClicked += Card_ApproveClicked;
                        card1.RejectClicked += Card_RejectClicked;
                        flpWaitingApproval.Controls.Add(card1);

                    }
                    else if (ownerID == SystemManager.currentUserID && status == "Ongoing")
                    {
                        VehicleCard card2 = new VehicleCard(this, vehicleID, generalType, specificType, make, model, vehicleYear, transmission, drivetrain, licensePlate,
                                                            color, fuelType, seats, mileage, priceDaily, priceHourly, vehicleImage, rating, "Finish Rental");

                        card2.FullDetailsClickedRent += Card_FullDetailsClickedRent;
                        card2.FinishRentalClicked += Card_FinishRentalClicked;
                        flpCurrentlyRented.Controls.Add(card2);
                    }

                }

                connection.Close();
            }
        }

        private void Card_RejectClicked(int vehicleID)
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
                    MessageBox.Show("Rejected rental request", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //MessageBox.Show("test");
                }
            }
        }

        public void Card_FullDetailsClickedRent(int vehicleID) { //SUPPROTING METHOD: View full details
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
        public void Card_ApproveClicked(int vehicleID) //MAIN METHOD: Approve pending vehicle
        {
            SystemManager.currentFullDetailsVehicleID = vehicleID;

            string updateClientQuery = "UPDATE ClientVehicleQuery SET Status = @status, TotalRentals = TotalRentals + 1, UserTotalRentals = UserTotalRentals + 1, RentDate = @rentDate WHERE VehicleID = @vehicleID";
            string getPriceQuery = "SELECT Price FROM ClientVehicleQuery WHERE VehicleID = @vehicleID";
            string updateRevenueQuery = "UPDATE UserVehicleQuery SET TotalRevenue = TotalRevenue + @price WHERE VehicleID = @vehicleID";

            try
            {
                connection.Open();

                // 1. Update ClientVehicleQuery
                using (OleDbCommand cmd = new OleDbCommand(updateClientQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@status", "Ongoing");
                    cmd.Parameters.AddWithValue("@rentDate", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@vehicleID", SystemManager.currentFullDetailsVehicleID);
                    cmd.ExecuteNonQuery();
                }

                // 2. Get Price from ClientVehicleQuery
                decimal price = 0;
                using (OleDbCommand cmd = new OleDbCommand(getPriceQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@vehicleID", SystemManager.currentFullDetailsVehicleID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        price = Convert.ToDecimal(result);
                }

                // 3. Update TotalRevenue in UserVehicleQuery
                using (OleDbCommand cmd = new OleDbCommand(updateRevenueQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@vehicleID", SystemManager.currentFullDetailsVehicleID);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Rental request accepted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
                LoadVehicles();
            }
        }

        public void Card_FinishRentalClicked(int vehicleID) //MAIN METHOD: Finish rental process
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
                    //MessageBox.Show("test");
                }
            }
        }
    }
}
