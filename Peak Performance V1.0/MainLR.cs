//NuGet UI packages
using ReaLTaiizor;          // Core namespace
using ReaLTaiizor.Manager;
using ReaLTaiizor.Controls; // For custom controls like buttons, labels, etc.
using ReaLTaiizor.Forms;    // For using Taiizor-styled forms
using ReaLTaiizor.Enum;     // For enumerations (e.g., themes, styles)

namespace Peak_Performance_V1._0
{
    public partial class MainLR : Form
    {
        public MainLR()
        {
            InitializeComponent();
        }

        private void lblGoToL_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lblGoToR_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void MainLR_Load(object sender, EventArgs e)
        {
            //set realtaiizor materialskin theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ReaLTaiizor.Colors.MaterialColorScheme(ReaLTaiizor.Colors.MaterialPrimary.Orange700, ReaLTaiizor.Colors.MaterialPrimary.Orange800, ReaLTaiizor.Colors.MaterialPrimary.Orange900, ReaLTaiizor.Colors.MaterialAccent.Orange700, ReaLTaiizor.Util.MaterialTextShade.WHITE);

            //hide vehicles
            picVan.Location = new Point(x, 300);
            picCar.Location = new Point(x, 315);
            picMotor.Location = new Point(x, 315);
            picF1.Location = new Point(x, 315);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }

        int x = -150;
        int car = 1;
        private void tmrMove_Tick(object sender, EventArgs e)
        {
            if (car == 1)
            {
                picVan.Location = new Point(x, 320);
                x += 2;

                if (x > 600)
                {
                    x = -130;
                    car++;
                }
            }
            else if (car == 2)
            {
                picCar.Location = new Point(x, 340);
                x += 3;

                if (x > 600)
                {
                    x = -100;
                    car++;
                }
            }
            else if (car == 3)
            {
                picMotor.Location = new Point(x, 350);
                x += 4;

                if (x > 600)
                {
                    x = -125;
                    car++;
                }
            }
            else if (car == 4)
            {
                picF1.Location = new Point(x, 350);
                x += 10;

                if (x > 610)
                {
                    x = -150;
                    car = 1;
                }
            }
        }

        private void tmrGauge_Tick(object sender, EventArgs e)
        {
            if (Gauge.Percentage == 100)
                Gauge.Percentage = 10;
            Gauge.Percentage++;
        }
    }
}