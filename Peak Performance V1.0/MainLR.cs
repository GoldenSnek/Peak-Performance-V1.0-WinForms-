namespace Peak_Performance_V1._0
{
    public partial class MainLR: Form
    {
        public MainLR()
        {
            InitializeComponent();
        }

        public Register Register
        {
            get => default;
            set
            {
            }
        }

        public About About
        {
            get => default;
            set
            {
            }
        }

        public Login Login
        {
            get => default;
            set
            {
            }
        }

        private void MainLR_Load(object sender, EventArgs e)
        {
            SystemManager.splash++;
            tmrFadeIn.Start();
        }

        //EVENTS: Form navigation
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
        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Close();
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //SUPPORTING EVENTS
        private void tmrGauge_Tick(object sender, EventArgs e) //SUPPORTING EVENT: Gauge animation
        {
            if (Gauge.Percentage == 90)
                Gauge.Percentage = 10;
            Gauge.Percentage++;
        }
        private void tmrFadeIn_Tick(object sender, EventArgs e) //SUPPORTING EVENT: Fade in animation
        {
            Opacity += 0.02;
            if (Opacity >= 1)
                tmrFadeIn.Stop();
        }
    }
}