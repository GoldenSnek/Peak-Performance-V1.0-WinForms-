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
using ReaLTaiizor.Forms;

namespace Peak_Performance_V1._0
{
    public partial class VehicleCard : UserControl
    {
        //private int _cornerRadius = 50; // Adjust the radius for more/less rounding
        //private int _borderThickness = 5; // Adjust border thickness
        //private Color _borderColor = Color.Orange; // Change border color as needed

        public int VehicleID = 0;
        public string? GeneralType = null;
        public string? SpecificType = null;
        public string? Make = null;
        public string? Model = null;
        public int? VehicleYear = 0;
        public string? Transmission = null;
        public string? Drivetrain = null;
        public string? LicensePlate = null;
        public string? VehicleColor = null;
        public string? FuelType = null;
        public int? Seats = 0;
        public double? Mileage = 0;
        public double? PriceDaily = 0;
        public double? PriceHourly = 0;
        public Image? VehicleImage = null;
        public string? Prompt = null;
        Form ParentForm;

        public event Action<int, string, string, string, string, int?, string, string, string, string, string, int?, double?, double?, double?, Image> EditClicked; //event for vehicle editing
        public event Action<int> DeleteClicked;
        public event Action<int> FullDetailsClicked;
        public event Action<int> FullDetailsClickedRent;
        public event Action<int> RentClicked;
        public event Action<int> ApproveClicked;
        public event Action<int> RejectClicked;
        public event Action<int> FinishRentalClicked;

        public FullVehicleDetails FullVehicleDetails
        {
            get => default;
            set
            {
            }
        }

        public RentVehicle RentVehicle
        {
            get => default;
            set
            {
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (Prompt == "Rent")
            {
                RentClicked?.Invoke(VehicleID);
            }
            else if (Prompt == "Finish Rental")
            {
                FinishRentalClicked?.Invoke(VehicleID);
            }

        }

        public VehicleCard(Form form, int vehicleID, string generalType, string specificType, string make, string model, int vehicleYear, string transmission, string drivetrain, string licensePlate,
                           string color, string fuelType, int seats, double mileage, double priceDaily, double priceHourly, Image vehicleImage, double rating, string prompt)
        {
            InitializeComponent();

            ParentForm = form;

            if (ParentForm is ProviderUpdateVehicle)
            {
                btnProceed.Visible = false;
                btnAccept.Visible = false;
                btnReject.Visible = false;
                picEdit.Visible = true;
                picDelete.Visible = true;
            }
            else if ((ParentForm is ProviderViewRental || ParentForm is AdminViewRental) && prompt == "Finish Rental")
            {
                btnProceed.Visible = true;
                btnAccept.Visible = false;
                btnReject.Visible = false;
                picEdit.Visible = false;
                picDelete.Visible = false;
            }
            else if (ParentForm is ProviderViewRental || ParentForm is AdminViewRental)
            {
                btnProceed.Visible = false;
                btnAccept.Visible = true;
                btnReject.Visible = true;
                picEdit.Visible = false;
                picDelete.Visible = false;
            }
            else
            {
                btnProceed.Visible = true;
                btnAccept.Visible = false;
                btnReject.Visible = false;
                picEdit.Visible = false;
                picDelete.Visible = false;
            }


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

            if (GeneralType == "Car")
                this.BackgroundImage = Properties.Resources.MultiCar;
            else if (GeneralType == "Motorcycle")
                this.BackgroundImage = Properties.Resources.MultiMotor;

            lblType.Text = $"{generalType} ({specificType})";
            lblMake.Text = $"{make}";
            lblModel.Text = $"{model}" +
                            $" {vehicleYear}";
            lblTransmission.Text = $"Transmission: {transmission}";
            //lblLicense.Text = $"License Plate No: {licensePlate}";
            //lblColor.Text = $"Color: {color}";
            lblFuelType.Text = $"Fuel Type: {fuelType}";
            lblSeats.Text = $"Seats: {seats}";
            lblMileage.Text = $"Mileage: {mileage} km";
            lblDailyPrice.Text = $"Php {priceDaily}/day";
            lblHourlyPrice.Text = $"Php {priceHourly}/hr";
            if (vehicleImage != null)
                picVehicle.Image = vehicleImage;
            else
                picVehicle.Image = Properties.Resources.Car___MainLR;

            lblRating.Text = rating.ToString();


            if (prompt != "")
            {
                btnProceed.Text = prompt;
            }
            else
                btnProceed.Visible = false;
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(VehicleID, GeneralType, SpecificType, Make, Model, VehicleYear, Transmission, Drivetrain, LicensePlate, VehicleColor, FuelType, Seats, Mileage, PriceDaily, PriceHourly, VehicleImage);
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(VehicleID);
        }

        private void btnFullDetails_Click(object sender, EventArgs e)
        {
            if (Prompt == "Approve" || Prompt == "Finish Rental")
            {
                FullDetailsClickedRent?.Invoke(VehicleID);
            }
            else
                FullDetailsClicked?.Invoke(VehicleID);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ApproveClicked?.Invoke(VehicleID);
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            RejectClicked?.Invoke(VehicleID);
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
