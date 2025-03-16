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
            //hide vehicles
            picVan.Location = new Point(x, 300);
            picCar.Location = new Point(x, 315);
            picMotor.Location = new Point(x, 315);
            picF1.Location = new Point(x, 315);
            tmrFadeIn.Start();
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

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            Opacity += 0.02;
            if (Opacity >= 1) // Fully visible
            {
                tmrFadeIn.Stop(); // Stop the timer
            }
        }
    }
}