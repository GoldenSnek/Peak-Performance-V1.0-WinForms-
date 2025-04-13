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
        }
        private void Analytics_Load(object sender, EventArgs e)
        {
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
                    using (ErrorMessage errorForm = new ErrorMessage($"Error: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public (int[], int[]) GetTotalVehicleCount()
        {
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
                            if (index >= ownerIds.Length)
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
                    using (ErrorMessage errorForm = new ErrorMessage($"Error: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
            return (ownerIds.Take(index).ToArray(), vehicleCounts.Take(index).ToArray());
        }

        public void ShowUserChart()
        {
            var model = new PlotModel { Title = "User Roles", TitleFontSize = 14 };
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "CategoryAxis",
                ItemsSource = new[] { "All Users", "Vehicle Providers", "Clients" }
            };
            model.Axes.Add(categoryAxis);
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "Count"
            };
            model.Axes.Add(valueAxis);
            var barSeries = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };

            barSeries.Items.Add(new BarItem { Value = TotalUsers, Color = OxyColors.SteelBlue });
            barSeries.Items.Add(new BarItem { Value = TotalProviders, Color = OxyColors.Teal });
            barSeries.Items.Add(new BarItem { Value = TotalClients, Color = OxyColors.MediumPurple });

            model.Series.Add(barSeries);
            plotView1.Model = model;
        }

        public void ShowVehicleChart()
        {
            var (ownerIds, vehicleCounts) = GetTotalVehicleCount();

            var model = new PlotModel { Title = "Vehicles Owned per User", TitleFontSize = 14 };

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "OwnerAxis",
                ItemsSource = ownerIds.Select(id => $"User {id}").ToList(),
                Title = "Users"
            };
            model.Axes.Add(categoryAxis);
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "Vehicles Owned"
            };
            model.Axes.Add(valueAxis);
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

                barSeries.Items.Add(barItem);

                counter = (counter + 1) % 5;
            }

            model.Series.Add(barSeries);
            plotView2.Model = model;
        }

        public (int[], double[]) GetTotalRevenuePerUser()
        {
            int[] userIds = new int[100];
            double[] totalRevenue = new double[100];
            int index = 0;

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
                            if (index >= userIds.Length)
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
                    using (ErrorMessage errorForm = new ErrorMessage($"Error: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
            return (userIds.Take(index).ToArray(), totalRevenue.Take(index).ToArray());
        }

        public void ShowRevenueChart()
        {
            var (userIds, totalRevenue) = GetTotalRevenuePerUser();

            var model = new PlotModel { Title = "Total Revenue per User", TitleFontSize = 14 };

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "Total Revenue"
            };
            model.Axes.Add(valueAxis);
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "UserAxis",
                ItemsSource = userIds.Select(id => $"User {id}").ToList(),
                Title = "Users"
            };
            model.Axes.Add(categoryAxis);
            var barSeries = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "₱{0:N2}",
            };
            var colors = new[] { OxyColors.Red, OxyColors.Green, OxyColors.Blue, OxyColors.Yellow, OxyColors.Purple };
            int counter = 0;

            for (int i = 0; i < totalRevenue.Length; i++)
            {
                var barItem = new BarItem { Value = totalRevenue[i] };

                barItem.Color = colors[counter];

                counter = (counter + 1) % colors.Length;

                barSeries.Items.Add(barItem);
            }

            model.Series.Add(barSeries);
            plotView3.Model = model;
        }
    }
}
