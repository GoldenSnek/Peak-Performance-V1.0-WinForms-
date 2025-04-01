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
    public partial class TopVehicleCard : UserControl
    {
        public TopVehicleCard(string generalType, string specificType, string make, string model, int vehicleYear, Image vehicleImage, double vehicleRating)
        {
            InitializeComponent();

            lblType.Text = $"{generalType} ({specificType})";
            lblMake.Text = $"{make}";
            lblModel.Text = $"{model}" +
                            $" {vehicleYear}";

            if (vehicleImage != null)
                picVehicle.Image = vehicleImage;
            else
                picVehicle.Image = Properties.Resources.Car___MainLR;

            lblRating.Text = vehicleRating.ToString();
        }
    }
}
