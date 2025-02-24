using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peak_Performance_V1._0
{
    public partial class VehicleCard : UserControl
    {
        public VehicleCard(string generalType, string specificType, string make, string model, int vehicleYear, string licensePlate,
                           string color, string fuelType, int seats, double mileage, double priceDaily, double priceHourly, Image vehicleImage, string prompt)
        {
            InitializeComponent();

            lblType.Text = $"Type: {generalType} ({specificType})";
            lblMake.Text = $"Make: {make}";
            lblModel.Text = $"Model: {model} {vehicleYear}";
            lblLicense.Text = $"License Plate No: {licensePlate}";
            lblColor.Text = $"Color: {color}";
            lblFuelType.Text = $"Fuel Type: {fuelType}";
            lblSeats.Text = $"Seats: {seats}";
            lblMileage.Text = $"Mileage: {mileage} km";
            lblDailyPrice.Text = $"Daily Price: {priceDaily}";
            lblHourlyPrice.Text = $"Hourly Price: {priceHourly}";
            picVehicle.Image = vehicleImage;

            if (prompt != "")
            {
                btnProceed.Visible = true;
                btnProceed.Text = prompt;
            }
            else
                btnProceed.Visible = false;

        }
    }
}
