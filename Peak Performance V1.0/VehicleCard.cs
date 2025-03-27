using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Peak_Performance_V1._0
{
    public partial class VehicleCard : UserControl
    {
        //private int _cornerRadius = 50; // Adjust the radius for more/less rounding
        //private int _borderThickness = 5; // Adjust border thickness
        //private Color _borderColor = Color.Orange; // Change border color as needed

        private int VehicleID = 0;
        private string? GeneralType = null;
        private string? SpecificType = null;
        private string? Make = null;
        private string? Model = null;
        private int? VehicleYear = 0;
        private string? Transmission = null;
        private string? Drivetrain = null;
        private string? LicensePlate = null;
        private string? VehicleColor = null;
        private string? FuelType = null;
        private int? Seats = 0;
        private double? Mileage = 0;
        private double? PriceDaily = 0;
        private double? PriceHourly = 0;
        private Image? VehicleImage = null;
        private string? Prompt = null;

        public event Action<int, string, string, string, string, int?, string, string, string, string, string, int?, double?, double?, double?, Image> EditClicked; //event for vehicle editing
        public event Action<int> FullDetailsClicked;
        public event Action<int> RentClicked;




        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (Prompt == "Edit")
            {
                EditClicked?.Invoke(VehicleID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, VehicleColor, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage);
            }
            else if (Prompt == "Rent")
            {
                RentClicked?.Invoke(VehicleID);
            }
        }

        private void btnFullDetails_Click(object sender, EventArgs e)
        {
            FullDetailsClicked?.Invoke(VehicleID);
        }

        public VehicleCard(int vehicleID, string generalType, string specificType, string make, string model, int vehicleYear, string transmission, string drivetrain, string licensePlate,
                           string color, string fuelType, int seats, double mileage, double priceDaily, double priceHourly, Image vehicleImage, string prompt)
        {
            InitializeComponent();

            VehicleID = vehicleID;
            GeneralType = generalType;
            SpecificType = specificType;
            Make = make;
            Model = model;
            VehicleYear = vehicleYear;
            Transmission = transmission;
            Drivetrain = drivetrain;
            LicensePlate = licensePlate;
            VehicleColor = color;
            FuelType = fuelType;
            Seats = seats;
            Mileage = mileage;
            PriceDaily = priceDaily;
            PriceHourly = priceHourly;

            VehicleImage = vehicleImage;

            Prompt = prompt;

            //this.DoubleBuffered = true; // Prevent flickering
            //this.Paint += new PaintEventHandler(RoundedUserControl_Paint); // Apply immediately

            lblType.Text = $"{generalType} ({specificType})";
            lblMake.Text = $"{make}";
            lblModel.Text = $"{model}" +
                            $" {vehicleYear}";
            //lblLicense.Text = $"License Plate No: {licensePlate}";
            //lblColor.Text = $"Color: {color}";
            lblFuelType.Text = $"Fuel Type: {fuelType}";
            lblSeats.Text = $"Seats: {seats}";
            //lblMileage.Text = $"Mileage: {mileage} km";
            lblDailyPrice.Text = $"Php {priceDaily}/day";
            lblHourlyPrice.Text = $"Php {priceHourly}/hr";
            if (vehicleImage != null)
                picVehicle.Image = vehicleImage;
            else
                picVehicle.Image = Properties.Resources.Car___MainLR;


            if (prompt != "")
            {
                btnProceed.Visible = true;
                btnProceed.Text = prompt;
            }
            else
                btnProceed.Visible = false;
        }

    /*
    private void RoundedUserControl_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        using (GraphicsPath path = GetRoundedRectanglePath(new Rectangle(0, 0, this.Width, this.Height), _cornerRadius))
        {
            // Apply the rounded region
            this.Region = new Region(path);

            // Fill Background Smoothly
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Draw Border
            using (Pen borderPen = new Pen(_borderColor, _borderThickness))
            {
                e.Graphics.DrawPath(borderPen, path);
            }
        }
    }

    private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
    {
        int diameter = radius * 2;
        GraphicsPath path = new GraphicsPath();

        path.StartFigure();
        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Top-Left
        path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // Top-Right
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-Right
        path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-Left
        path.CloseFigure();

        return path;
    }
    */
    }
}
