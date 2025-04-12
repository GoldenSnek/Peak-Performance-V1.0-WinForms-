using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics.Metrics;


namespace Peak_Performance_V1._0
{
    public partial class Analytics : Form
    {
        private OleDbConnection connection;
        int TotalUsers = 0;
        int TotalProviders = 0;
        int TotalClients = 0;
        int TotalVehicles = 0;
        public Analytics()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();

            GetTotalUserCount();
            GetTotalVehicleCount();

            ShowUserChart();
            ShowVehicleChart();
            ShowRevenueChart();
        }

        public void GetTotalUserCount()
        {

            string query = "SELECT Role, COUNT(*) AS RoleCount FROM Users GROUP BY Role";

            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string role = reader["Role"].ToString();
                            int count = Convert.ToInt32(reader["RoleCount"]);

                            TotalUsers += count;

                            if (role == "Vehicle Provider")
                                TotalProviders = count;
                            else if (role == "Client")
                                TotalClients = count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public (int[], int[]) GetTotalVehicleCount()
        {
            // Initializing arrays with a large enough size, 
            // you can dynamically adjust this based on actual data if needed
            int[] ownerIds = new int[100];
            int[] vehicleCounts = new int[100];
            int index = 0;
            string query = "SELECT OwnerID, COUNT(*) AS VehicleCount FROM Vehicles WHERE OwnerID <> 0 GROUP BY OwnerID";

            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (index >= ownerIds.Length) // Expand array if needed (optional)
                            {
                                Array.Resize(ref ownerIds, ownerIds.Length * 2);
                                Array.Resize(ref vehicleCounts, vehicleCounts.Length * 2);
                            }

                            ownerIds[index] = Convert.ToInt32(reader["OwnerID"]);
                            vehicleCounts[index] = Convert.ToInt32(reader["VehicleCount"]);
                            index++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            // Return only the populated portion of the arrays
            return (ownerIds.Take(index).ToArray(), vehicleCounts.Take(index).ToArray());
        }

        public void ShowUserChart()
        {
            var model = new PlotModel { Title = "User Roles", TitleFontSize = 14 };

            // Y-Axis (Categories: All Users, Vehicle Providers, Clients)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "CategoryAxis",
                ItemsSource = new[] { "All Users", "Vehicle Providers", "Clients" }
            };
            model.Axes.Add(categoryAxis);

            // X-Axis (Count)
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "Count"
            };
            model.Axes.Add(valueAxis);

            // BarSeries with custom bar colors
            var barSeries = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };

            // Add bars with individual colors
            barSeries.Items.Add(new BarItem { Value = TotalUsers, Color = OxyColors.SteelBlue });         // All Users
            barSeries.Items.Add(new BarItem { Value = TotalProviders, Color = OxyColors.Teal });          // Providers
            barSeries.Items.Add(new BarItem { Value = TotalClients, Color = OxyColors.MediumPurple });    // Clients

            model.Series.Add(barSeries);

            // Assign model to PlotView
            plotView1.Model = model;
        }

        public void ShowVehicleChart()
        {
            var (ownerIds, vehicleCounts) = GetTotalVehicleCount();

            var model = new PlotModel { Title = "Vehicles Owned per User", TitleFontSize = 14 };

            // Y-Axis (Owner IDs)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "OwnerAxis",
                ItemsSource = ownerIds.Select(id => $"User {id}").ToList(),
                Title = "Users"
            };
            model.Axes.Add(categoryAxis);

            // X-Axis (Vehicle Count)
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "Vehicles Owned"
            };
            model.Axes.Add(valueAxis);

            // BarSeries
            var barSeries = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };

            int counter = 0;
            foreach (var count in vehicleCounts)
            {
                var barItem = new BarItem { Value = count };
                if (counter == 0)
                    barItem.Color = OxyColors.Red;
                else if (counter == 1)
                    barItem.Color = OxyColors.Green;
                else if (counter == 2)
                    barItem.Color = OxyColors.Blue;
                else if (counter == 3)
                    barItem.Color = OxyColors.Yellow;
                else if (counter == 4)
                    barItem.Color = OxyColors.Purple;

                // Add the BarItem to the BarSeries
                barSeries.Items.Add(barItem);

                // Increment the counter and wrap it back to 0 after 5
                counter = (counter + 1) % 5;
            }

            model.Series.Add(barSeries);

            // Assign to PlotView2
            plotView2.Model = model;
        }

        public (int[], double[]) GetTotalRevenuePerUser()
        {
            // Arrays to store UserID and corresponding total revenue
            int[] userIds = new int[100];
            double[] totalRevenue = new double[100];
            int index = 0;

            // Query to get the total revenue for each user from the Users table
            string query = "SELECT UserID, TotalRevenue FROM Users WHERE UserID <> 0";

            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (index >= userIds.Length) // Expand array if needed (optional)
                            {
                                Array.Resize(ref userIds, userIds.Length * 2);
                                Array.Resize(ref totalRevenue, totalRevenue.Length * 2);
                            }

                            userIds[index] = Convert.ToInt32(reader["UserID"]);
                            totalRevenue[index] = Convert.ToDouble(reader["TotalRevenue"]);
                            index++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            // Return only the populated portion of the arrays
            return (userIds.Take(index).ToArray(), totalRevenue.Take(index).ToArray());
        }

        public void ShowRevenueChart()
        {
            var (userIds, totalRevenue) = GetTotalRevenuePerUser();

            var model = new PlotModel { Title = "Total Revenue per User", TitleFontSize = 14 };

            // X-Axis (Revenue)
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "Total Revenue"
            };
            model.Axes.Add(valueAxis);

            // Y-Axis (User IDs - Category Axis)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "UserAxis",
                ItemsSource = userIds.Select(id => $"User {id}").ToList(),
                Title = "Users"
            };
            model.Axes.Add(categoryAxis);

            // BarSeries (Vertical)
            var barSeries = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "₱{0:N2}",  // Format as PHP (Philippine Peso)
            };

            // Define an array of colors to cycle through
            var colors = new[] { OxyColors.Red, OxyColors.Green, OxyColors.Blue, OxyColors.Yellow, OxyColors.Purple };
            int counter = 0;  // Counter to cycle through the colors

            // Add bar items based on total revenue for each user
            for (int i = 0; i < totalRevenue.Length; i++)
            {
                // Create a BarItem and set the color based on the counter
                var barItem = new BarItem { Value = totalRevenue[i] };

                // Assign color based on counter value
                barItem.Color = colors[counter];

                // Increment counter and cycle back after 5 colors
                counter = (counter + 1) % colors.Length;

                // Add the barItem to the BarSeries
                barSeries.Items.Add(barItem);
            }

            model.Series.Add(barSeries);

            // Assign to PlotView3
            plotView3.Model = model;
        }
    }
}
