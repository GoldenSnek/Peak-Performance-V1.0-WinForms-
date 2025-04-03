namespace Peak_Performance_V1._0
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            tmrClock = new System.Windows.Forms.Timer(components);
            lblGreetings = new Label();
            lblAnalytics = new Label();
            pnlForm = new Panel();
            panel18 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel19 = new Panel();
            label3 = new Label();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            panel13 = new Panel();
            pictureBox2 = new PictureBox();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            flpDisplayUsers = new FlowLayoutPanel();
            label1 = new Label();
            panel7 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label16 = new Label();
            label15 = new Label();
            pnlLeft = new Panel();
            pnlDown = new Panel();
            pnlRight = new Panel();
            panel2 = new Panel();
            parrotClock1 = new ReaLTaiizor.Controls.ParrotClock();
            label14 = new Label();
            parrotGauge1 = new ReaLTaiizor.Controls.ParrotGauge();
            panel8 = new Panel();
            flpDisplayVehicles = new FlowLayoutPanel();
            picNight = new PictureBox();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            tmrFadeIn = new System.Windows.Forms.Timer(components);
            pnlSideMenu = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            picHide = new PictureBox();
            btnExit = new Button();
            btnLogout = new Button();
            btnManageAccount = new Button();
            btnAccount = new Button();
            btnUpdateVehicles = new Button();
            btnAddVehicles = new Button();
            btnVehicles = new Button();
            btnRentalDetails = new Button();
            btnAllVehicles = new Button();
            btnRentals = new Button();
            btnAdminAllUsers = new Button();
            btnAdminAllVehicles = new Button();
            btnHome = new Button();
            pnlTitle = new Panel();
            lblRole = new Label();
            lblUsername = new Label();
            picPFP = new PictureBox();
            pnlTop = new Panel();
            lblDay = new Label();
            picMin = new PictureBox();
            lblTime = new Label();
            lblDate = new Label();
            picMax = new PictureBox();
            pnlForm.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNight).BeginInit();
            pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPFP).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMax).BeginInit();
            SuspendLayout();
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // lblGreetings
            // 
            lblGreetings.BackColor = Color.Black;
            lblGreetings.Dock = DockStyle.Top;
            lblGreetings.Font = new Font("Copperplate Gothic Bold", 14.25F);
            lblGreetings.ForeColor = Color.Transparent;
            lblGreetings.Location = new Point(3, 3);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(244, 20);
            lblGreetings.TabIndex = 5;
            lblGreetings.Text = "Hello {user}!";
            lblGreetings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnalytics
            // 
            lblAnalytics.BackColor = Color.Black;
            lblAnalytics.Dock = DockStyle.Top;
            lblAnalytics.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnalytics.ForeColor = Color.White;
            lblAnalytics.Location = new Point(3, 3);
            lblAnalytics.Name = "lblAnalytics";
            lblAnalytics.Size = new Size(519, 20);
            lblAnalytics.TabIndex = 6;
            lblAnalytics.Text = "Top Rated Vehicles";
            // 
            // pnlForm
            // 
            pnlForm.AutoScroll = true;
            pnlForm.BackColor = Color.FromArgb(35, 40, 50);
            pnlForm.BackgroundImageLayout = ImageLayout.Stretch;
            pnlForm.Controls.Add(panel18);
            pnlForm.Controls.Add(panel13);
            pnlForm.Controls.Add(panel3);
            pnlForm.Controls.Add(panel1);
            pnlForm.Controls.Add(panel8);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(220, 30);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(964, 704);
            pnlForm.TabIndex = 12;
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel18.BackColor = Color.FromArgb(35, 40, 60);
            panel18.Controls.Add(label4);
            panel18.Controls.Add(pictureBox1);
            panel18.Controls.Add(panel19);
            panel18.Controls.Add(label3);
            panel18.Controls.Add(panel20);
            panel18.Controls.Add(panel21);
            panel18.Controls.Add(panel22);
            panel18.Location = new Point(580, 159);
            panel18.Name = "panel18";
            panel18.Size = new Size(350, 530);
            panel18.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 114);
            label4.Name = "label4";
            label4.Size = new Size(243, 196);
            label4.TabIndex = 25;
            label4.Text = "Looking for the perfect ride?\r\nWhether it's a luxury car,\r\na rugged SUV,\r\nor a fuel-efficient sedan.\r\n✔ Wide Selection\r\n✔ Best Value Deals\r\n✔ Seamless Rental Process";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.FType;
            pictureBox1.Location = new Point(29, 329);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(255, 128, 0);
            panel19.Dock = DockStyle.Left;
            panel19.ForeColor = Color.Coral;
            panel19.Location = new Point(0, 3);
            panel19.Name = "panel19";
            panel19.Size = new Size(3, 524);
            panel19.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Copperplate Gothic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(43, 23);
            label3.Name = "label3";
            label3.Size = new Size(269, 30);
            label3.TabIndex = 24;
            label3.Text = "Rent ride repeat";
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(255, 128, 0);
            panel20.Dock = DockStyle.Bottom;
            panel20.ForeColor = Color.Coral;
            panel20.Location = new Point(0, 527);
            panel20.Name = "panel20";
            panel20.Size = new Size(347, 3);
            panel20.TabIndex = 18;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(255, 128, 0);
            panel21.Dock = DockStyle.Right;
            panel21.ForeColor = Color.Coral;
            panel21.Location = new Point(347, 3);
            panel21.Name = "panel21";
            panel21.Size = new Size(3, 527);
            panel21.TabIndex = 16;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(255, 128, 0);
            panel22.Dock = DockStyle.Top;
            panel22.ForeColor = Color.Coral;
            panel22.Location = new Point(0, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(350, 3);
            panel22.TabIndex = 15;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel13.BackColor = Color.Black;
            panel13.Controls.Add(pictureBox2);
            panel13.Controls.Add(lblGreetings);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel15);
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel17);
            panel13.Location = new Point(305, 159);
            panel13.Name = "panel13";
            panel13.Size = new Size(250, 250);
            panel13.TabIndex = 21;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.SlowDrive;
            pictureBox2.Location = new Point(3, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(244, 224);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(255, 128, 0);
            panel14.Dock = DockStyle.Left;
            panel14.ForeColor = Color.Coral;
            panel14.Location = new Point(0, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(3, 244);
            panel14.TabIndex = 17;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(255, 128, 0);
            panel15.Dock = DockStyle.Bottom;
            panel15.ForeColor = Color.Coral;
            panel15.Location = new Point(0, 247);
            panel15.Name = "panel15";
            panel15.Size = new Size(247, 3);
            panel15.TabIndex = 18;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(255, 128, 0);
            panel16.Dock = DockStyle.Right;
            panel16.ForeColor = Color.Coral;
            panel16.Location = new Point(247, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(3, 247);
            panel16.TabIndex = 16;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(255, 128, 0);
            panel17.Dock = DockStyle.Top;
            panel17.ForeColor = Color.Coral;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(250, 3);
            panel17.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.FromArgb(35, 40, 60);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(flpDisplayUsers);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(30, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 250);
            panel3.TabIndex = 19;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 0);
            panel5.Dock = DockStyle.Bottom;
            panel5.ForeColor = Color.Coral;
            panel5.Location = new Point(3, 247);
            panel5.Name = "panel5";
            panel5.Size = new Size(244, 3);
            panel5.TabIndex = 18;
            // 
            // flpDisplayUsers
            // 
            flpDisplayUsers.AutoScroll = true;
            flpDisplayUsers.BackColor = Color.FromArgb(45, 60, 75);
            flpDisplayUsers.Dock = DockStyle.Fill;
            flpDisplayUsers.Location = new Point(3, 23);
            flpDisplayUsers.Name = "flpDisplayUsers";
            flpDisplayUsers.Size = new Size(244, 227);
            flpDisplayUsers.TabIndex = 22;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(244, 20);
            label1.TabIndex = 21;
            label1.Text = "Top rated providers";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 128, 0);
            panel7.Dock = DockStyle.Top;
            panel7.ForeColor = Color.Coral;
            panel7.Location = new Point(3, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(244, 3);
            panel7.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 128, 0);
            panel4.Dock = DockStyle.Left;
            panel4.ForeColor = Color.Coral;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 250);
            panel4.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 128, 0);
            panel6.Dock = DockStyle.Right;
            panel6.ForeColor = Color.Coral;
            panel6.Location = new Point(247, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(3, 250);
            panel6.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(35, 40, 60);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(pnlLeft);
            panel1.Controls.Add(pnlDown);
            panel1.Controls.Add(pnlRight);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(parrotClock1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(parrotGauge1);
            panel1.Location = new Point(30, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 100);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(367, 61);
            label5.Name = "label5";
            label5.Size = new Size(152, 18);
            label5.TabIndex = 45;
            label5.Text = "main dashboard";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(247, 21);
            label2.Name = "label2";
            label2.Size = new Size(409, 35);
            label2.TabIndex = 44;
            label2.Text = "PEAK PERFORMANCE";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Right;
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Silver;
            label16.Location = new Point(854, 61);
            label16.Name = "label16";
            label16.Size = new Size(28, 14);
            label16.TabIndex = 43;
            label16.Text = "100";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Silver;
            label15.Location = new Point(689, 61);
            label15.Name = "label15";
            label15.Size = new Size(14, 14);
            label15.TabIndex = 42;
            label15.Text = "0";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(255, 128, 0);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.ForeColor = Color.Coral;
            pnlLeft.Location = new Point(0, 3);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(3, 94);
            pnlLeft.TabIndex = 17;
            // 
            // pnlDown
            // 
            pnlDown.BackColor = Color.FromArgb(255, 128, 0);
            pnlDown.Dock = DockStyle.Bottom;
            pnlDown.ForeColor = Color.Coral;
            pnlDown.Location = new Point(0, 97);
            pnlDown.Name = "pnlDown";
            pnlDown.Size = new Size(897, 3);
            pnlDown.TabIndex = 18;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(255, 128, 0);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.ForeColor = Color.Coral;
            pnlRight.Location = new Point(897, 3);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(3, 97);
            pnlRight.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.Coral;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 3);
            panel2.TabIndex = 15;
            // 
            // parrotClock1
            // 
            parrotClock1.Anchor = AnchorStyles.Left;
            parrotClock1.CircleThickness = 3;
            parrotClock1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotClock1.DisplayFormat = ReaLTaiizor.Controls.ParrotClock.HourFormat.TwelveHour;
            parrotClock1.FilledHourColor = Color.FromArgb(255, 128, 0);
            parrotClock1.FilledMinuteColor = Color.Empty;
            parrotClock1.FilledSecondColor = Color.Blue;
            parrotClock1.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotClock1.HexagonColor = Color.Black;
            parrotClock1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotClock1.Location = new Point(71, 0);
            parrotClock1.Name = "parrotClock1";
            parrotClock1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotClock1.ShowAmPm = true;
            parrotClock1.ShowHexagon = false;
            parrotClock1.ShowMinutesCircle = true;
            parrotClock1.ShowSecondsCircle = true;
            parrotClock1.Size = new Size(95, 100);
            parrotClock1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotClock1.TabIndex = 19;
            parrotClock1.Text = "parrotClock1";
            parrotClock1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotClock1.TimeAMFormat = "hh:mm:ss";
            parrotClock1.TimeColor = Color.Gray;
            parrotClock1.TimePMFormat = "HH:mm:ss";
            parrotClock1.UnfilledHourColor = Color.Empty;
            parrotClock1.UnfilledMinuteColor = Color.Empty;
            parrotClock1.UnfilledSecondColor = Color.Empty;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Right;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(682, 70);
            label14.Name = "label14";
            label14.Size = new Size(198, 27);
            label14.TabIndex = 36;
            label14.Text = "Vehicles currently being rented";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parrotGauge1
            // 
            parrotGauge1.Anchor = AnchorStyles.Right;
            parrotGauge1.BackColor = Color.Transparent;
            parrotGauge1.BarColor = (List<Color>)resources.GetObject("parrotGauge1.BarColor");
            parrotGauge1.ConsumptionColor = Color.Black;
            parrotGauge1.DialColor = Color.Gray;
            parrotGauge1.DialThickness = 5;
            parrotGauge1.FilledColor = Color.FromArgb(0, 162, 250);
            parrotGauge1.GaugeStyle = ReaLTaiizor.Controls.ParrotGauge.Style.Standard;
            parrotGauge1.Location = new Point(709, 9);
            parrotGauge1.Name = "parrotGauge1";
            parrotGauge1.Percentage = 75;
            parrotGauge1.Size = new Size(140, 70);
            parrotGauge1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGauge1.TabIndex = 19;
            parrotGauge1.Text = "parrotGauge1";
            parrotGauge1.Thickness = 8;
            parrotGauge1.UnfilledColor = Color.Gray;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(35, 40, 60);
            panel8.Controls.Add(flpDisplayVehicles);
            panel8.Controls.Add(lblAnalytics);
            panel8.Controls.Add(picNight);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(panel12);
            panel8.Location = new Point(30, 439);
            panel8.Name = "panel8";
            panel8.Size = new Size(525, 250);
            panel8.TabIndex = 20;
            // 
            // flpDisplayVehicles
            // 
            flpDisplayVehicles.AutoScroll = true;
            flpDisplayVehicles.BackColor = Color.FromArgb(45, 60, 75);
            flpDisplayVehicles.Dock = DockStyle.Fill;
            flpDisplayVehicles.FlowDirection = FlowDirection.TopDown;
            flpDisplayVehicles.Location = new Point(3, 23);
            flpDisplayVehicles.Name = "flpDisplayVehicles";
            flpDisplayVehicles.Size = new Size(519, 224);
            flpDisplayVehicles.TabIndex = 27;
            // 
            // picNight
            // 
            picNight.Anchor = AnchorStyles.None;
            picNight.Image = Properties.Resources.Home___Car_Night;
            picNight.Location = new Point(531, -219);
            picNight.Name = "picNight";
            picNight.Size = new Size(50, 50);
            picNight.SizeMode = PictureBoxSizeMode.StretchImage;
            picNight.TabIndex = 9;
            picNight.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(255, 128, 0);
            panel9.Dock = DockStyle.Left;
            panel9.ForeColor = Color.Coral;
            panel9.Location = new Point(0, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(3, 244);
            panel9.TabIndex = 17;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(255, 128, 0);
            panel10.Dock = DockStyle.Bottom;
            panel10.ForeColor = Color.Coral;
            panel10.Location = new Point(0, 247);
            panel10.Name = "panel10";
            panel10.Size = new Size(522, 3);
            panel10.TabIndex = 18;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(255, 128, 0);
            panel11.Dock = DockStyle.Right;
            panel11.ForeColor = Color.Coral;
            panel11.Location = new Point(522, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(3, 247);
            panel11.TabIndex = 16;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(255, 128, 0);
            panel12.Dock = DockStyle.Top;
            panel12.ForeColor = Color.Coral;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(525, 3);
            panel12.TabIndex = 15;
            // 
            // tmrFadeIn
            // 
            tmrFadeIn.Interval = 10;
            tmrFadeIn.Tick += tmrFadeIn_Tick;
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.AutoScroll = true;
            pnlSideMenu.BottomLeft = Color.FromArgb(45, 60, 75);
            pnlSideMenu.BottomRight = Color.FromArgb(45, 60, 75);
            pnlSideMenu.CollapseControl = picHide;
            pnlSideMenu.Collapsed = false;
            pnlSideMenu.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            pnlSideMenu.Controls.Add(btnExit);
            pnlSideMenu.Controls.Add(btnLogout);
            pnlSideMenu.Controls.Add(btnManageAccount);
            pnlSideMenu.Controls.Add(btnAccount);
            pnlSideMenu.Controls.Add(btnUpdateVehicles);
            pnlSideMenu.Controls.Add(btnAddVehicles);
            pnlSideMenu.Controls.Add(btnVehicles);
            pnlSideMenu.Controls.Add(btnRentalDetails);
            pnlSideMenu.Controls.Add(btnAllVehicles);
            pnlSideMenu.Controls.Add(btnRentals);
            pnlSideMenu.Controls.Add(btnAdminAllUsers);
            pnlSideMenu.Controls.Add(btnAdminAllVehicles);
            pnlSideMenu.Controls.Add(btnHome);
            pnlSideMenu.Controls.Add(pnlTitle);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.HideControls = false;
            pnlSideMenu.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.Low;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.PanelWidthCollapsed = 0;
            pnlSideMenu.PanelWidthExpanded = 220;
            pnlSideMenu.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            pnlSideMenu.PrimerColor = Color.FromArgb(45, 60, 75);
            pnlSideMenu.RightToLeft = RightToLeft.Yes;
            pnlSideMenu.Size = new Size(220, 734);
            pnlSideMenu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            pnlSideMenu.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            pnlSideMenu.TabIndex = 13;
            pnlSideMenu.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            pnlSideMenu.TopLeft = Color.FromArgb(45, 60, 75);
            pnlSideMenu.TopRight = Color.FromArgb(45, 60, 75);
            // 
            // picHide
            // 
            picHide.BackColor = Color.Transparent;
            picHide.BackgroundImage = Properties.Resources.HideShowMenu;
            picHide.BackgroundImageLayout = ImageLayout.Stretch;
            picHide.Cursor = Cursors.Hand;
            picHide.Location = new Point(9, 3);
            picHide.Name = "picHide";
            picHide.Size = new Size(25, 25);
            picHide.TabIndex = 41;
            picHide.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(45, 60, 75);
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial Rounded MT Bold", 12F);
            btnExit.ForeColor = Color.White;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 730);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.No;
            btnExit.Size = new Size(203, 60);
            btnExit.TabIndex = 47;
            btnExit.Text = "  EXIT";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(45, 60, 75);
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 12F);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 670);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(203, 60);
            btnLogout.TabIndex = 46;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageAccount
            // 
            btnManageAccount.BackColor = Color.FromArgb(45, 60, 75);
            btnManageAccount.Dock = DockStyle.Top;
            btnManageAccount.FlatAppearance.BorderSize = 0;
            btnManageAccount.FlatStyle = FlatStyle.Flat;
            btnManageAccount.Font = new Font("Arial Rounded MT Bold", 12F);
            btnManageAccount.ForeColor = Color.White;
            btnManageAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageAccount.Location = new Point(0, 610);
            btnManageAccount.Name = "btnManageAccount";
            btnManageAccount.RightToLeft = RightToLeft.No;
            btnManageAccount.Size = new Size(203, 60);
            btnManageAccount.TabIndex = 45;
            btnManageAccount.Text = "  Profile";
            btnManageAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnManageAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageAccount.UseVisualStyleBackColor = false;
            btnManageAccount.Click += btnManageAccount_Click;
            // 
            // btnAccount
            // 
            btnAccount.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccount.BackColor = Color.FromArgb(35, 40, 60);
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAccount.ForeColor = Color.FromArgb(255, 128, 0);
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 580);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(10, 0, 0, 0);
            btnAccount.RightToLeft = RightToLeft.No;
            btnAccount.Size = new Size(203, 30);
            btnAccount.TabIndex = 28;
            btnAccount.Text = "  ACCOUNT";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnUpdateVehicles
            // 
            btnUpdateVehicles.BackColor = Color.FromArgb(45, 60, 75);
            btnUpdateVehicles.Dock = DockStyle.Top;
            btnUpdateVehicles.FlatAppearance.BorderSize = 0;
            btnUpdateVehicles.FlatStyle = FlatStyle.Flat;
            btnUpdateVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnUpdateVehicles.ForeColor = Color.White;
            btnUpdateVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateVehicles.Location = new Point(0, 520);
            btnUpdateVehicles.Name = "btnUpdateVehicles";
            btnUpdateVehicles.RightToLeft = RightToLeft.No;
            btnUpdateVehicles.Size = new Size(203, 60);
            btnUpdateVehicles.TabIndex = 44;
            btnUpdateVehicles.Text = "  Update Vehicles";
            btnUpdateVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateVehicles.UseVisualStyleBackColor = false;
            btnUpdateVehicles.Click += btnUpdateVehicles_Click;
            // 
            // btnAddVehicles
            // 
            btnAddVehicles.BackColor = Color.FromArgb(45, 60, 75);
            btnAddVehicles.Dock = DockStyle.Top;
            btnAddVehicles.FlatAppearance.BorderSize = 0;
            btnAddVehicles.FlatStyle = FlatStyle.Flat;
            btnAddVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAddVehicles.ForeColor = Color.White;
            btnAddVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddVehicles.Location = new Point(0, 460);
            btnAddVehicles.Name = "btnAddVehicles";
            btnAddVehicles.RightToLeft = RightToLeft.No;
            btnAddVehicles.Size = new Size(203, 60);
            btnAddVehicles.TabIndex = 43;
            btnAddVehicles.Text = "  Add Vehicles";
            btnAddVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnAddVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddVehicles.UseVisualStyleBackColor = false;
            btnAddVehicles.Click += btnAddVehicles_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVehicles.BackColor = Color.FromArgb(35, 40, 60);
            btnVehicles.Cursor = Cursors.Hand;
            btnVehicles.Dock = DockStyle.Top;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnVehicles.ForeColor = Color.FromArgb(255, 128, 0);
            btnVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicles.Location = new Point(0, 430);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Padding = new Padding(10, 0, 0, 0);
            btnVehicles.RightToLeft = RightToLeft.No;
            btnVehicles.Size = new Size(203, 30);
            btnVehicles.TabIndex = 27;
            btnVehicles.Text = "  VEHICLES";
            btnVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehicles.UseVisualStyleBackColor = false;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnRentalDetails
            // 
            btnRentalDetails.BackColor = Color.FromArgb(45, 60, 75);
            btnRentalDetails.Dock = DockStyle.Top;
            btnRentalDetails.FlatAppearance.BorderSize = 0;
            btnRentalDetails.FlatStyle = FlatStyle.Flat;
            btnRentalDetails.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRentalDetails.ForeColor = Color.White;
            btnRentalDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentalDetails.Location = new Point(0, 370);
            btnRentalDetails.Name = "btnRentalDetails";
            btnRentalDetails.RightToLeft = RightToLeft.No;
            btnRentalDetails.Size = new Size(203, 60);
            btnRentalDetails.TabIndex = 42;
            btnRentalDetails.Text = "  Rental Details";
            btnRentalDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnRentalDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRentalDetails.UseVisualStyleBackColor = false;
            btnRentalDetails.Click += btnRentalDetails_Click;
            // 
            // btnAllVehicles
            // 
            btnAllVehicles.BackColor = Color.FromArgb(45, 60, 75);
            btnAllVehicles.Dock = DockStyle.Top;
            btnAllVehicles.FlatAppearance.BorderSize = 0;
            btnAllVehicles.FlatStyle = FlatStyle.Flat;
            btnAllVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAllVehicles.ForeColor = Color.White;
            btnAllVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnAllVehicles.Location = new Point(0, 310);
            btnAllVehicles.Name = "btnAllVehicles";
            btnAllVehicles.RightToLeft = RightToLeft.No;
            btnAllVehicles.Size = new Size(203, 60);
            btnAllVehicles.TabIndex = 41;
            btnAllVehicles.Text = "  All Vehicles";
            btnAllVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnAllVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAllVehicles.UseVisualStyleBackColor = false;
            btnAllVehicles.Click += btnAllVehicles_Click;
            // 
            // btnRentals
            // 
            btnRentals.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRentals.BackColor = Color.FromArgb(35, 40, 60);
            btnRentals.Cursor = Cursors.Hand;
            btnRentals.Dock = DockStyle.Top;
            btnRentals.FlatAppearance.BorderSize = 0;
            btnRentals.FlatStyle = FlatStyle.Flat;
            btnRentals.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRentals.ForeColor = Color.FromArgb(255, 128, 0);
            btnRentals.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentals.Location = new Point(0, 280);
            btnRentals.Name = "btnRentals";
            btnRentals.Padding = new Padding(10, 0, 0, 0);
            btnRentals.RightToLeft = RightToLeft.No;
            btnRentals.Size = new Size(203, 30);
            btnRentals.TabIndex = 25;
            btnRentals.Text = "  RENTALS";
            btnRentals.TextAlign = ContentAlignment.MiddleLeft;
            btnRentals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRentals.UseVisualStyleBackColor = false;
            btnRentals.Click += btnRentals_Click;
            // 
            // btnAdminAllUsers
            // 
            btnAdminAllUsers.BackColor = Color.FromArgb(45, 60, 75);
            btnAdminAllUsers.Dock = DockStyle.Top;
            btnAdminAllUsers.FlatAppearance.BorderSize = 0;
            btnAdminAllUsers.FlatStyle = FlatStyle.Flat;
            btnAdminAllUsers.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAdminAllUsers.ForeColor = Color.White;
            btnAdminAllUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdminAllUsers.Location = new Point(0, 220);
            btnAdminAllUsers.Name = "btnAdminAllUsers";
            btnAdminAllUsers.RightToLeft = RightToLeft.No;
            btnAdminAllUsers.Size = new Size(203, 60);
            btnAdminAllUsers.TabIndex = 40;
            btnAdminAllUsers.Text = "  Users";
            btnAdminAllUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnAdminAllUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdminAllUsers.UseVisualStyleBackColor = false;
            btnAdminAllUsers.Click += btnAdminAllUsers_Click;
            // 
            // btnAdminAllVehicles
            // 
            btnAdminAllVehicles.BackColor = Color.FromArgb(45, 60, 75);
            btnAdminAllVehicles.Dock = DockStyle.Top;
            btnAdminAllVehicles.FlatAppearance.BorderSize = 0;
            btnAdminAllVehicles.FlatStyle = FlatStyle.Flat;
            btnAdminAllVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAdminAllVehicles.ForeColor = Color.White;
            btnAdminAllVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdminAllVehicles.Location = new Point(0, 160);
            btnAdminAllVehicles.Name = "btnAdminAllVehicles";
            btnAdminAllVehicles.RightToLeft = RightToLeft.No;
            btnAdminAllVehicles.Size = new Size(203, 60);
            btnAdminAllVehicles.TabIndex = 39;
            btnAdminAllVehicles.Text = "  Vehicles";
            btnAdminAllVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnAdminAllVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdminAllVehicles.UseVisualStyleBackColor = false;
            btnAdminAllVehicles.Click += btnAdminAllVehicles_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(45, 60, 75);
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial Rounded MT Bold", 12F);
            btnHome.ForeColor = Color.White;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 100);
            btnHome.Name = "btnHome";
            btnHome.RightToLeft = RightToLeft.No;
            btnHome.Size = new Size(203, 60);
            btnHome.TabIndex = 38;
            btnHome.Text = "  Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(35, 40, 60);
            pnlTitle.Controls.Add(lblRole);
            pnlTitle.Controls.Add(lblUsername);
            pnlTitle.Controls.Add(picPFP);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(203, 100);
            pnlTitle.TabIndex = 26;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Copperplate Gothic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(12, 73);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(42, 15);
            lblRole.TabIndex = 25;
            lblRole.Text = "Role";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Copperplate Gothic Bold", 14.25F);
            lblUsername.ForeColor = Color.FromArgb(255, 128, 0);
            lblUsername.Location = new Point(68, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 21);
            lblUsername.TabIndex = 24;
            lblUsername.Text = "User";
            // 
            // picPFP
            // 
            picPFP.Image = Properties.Resources.Username;
            picPFP.Location = new Point(12, 12);
            picPFP.Name = "picPFP";
            picPFP.Size = new Size(50, 50);
            picPFP.SizeMode = PictureBoxSizeMode.StretchImage;
            picPFP.TabIndex = 23;
            picPFP.TabStop = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 128, 0);
            pnlTop.Controls.Add(lblDay);
            pnlTop.Controls.Add(picHide);
            pnlTop.Controls.Add(picMin);
            pnlTop.Controls.Add(lblTime);
            pnlTop.Controls.Add(lblDate);
            pnlTop.Controls.Add(picMax);
            pnlTop.Cursor = Cursors.Hand;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(220, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(964, 30);
            pnlTop.TabIndex = 22;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblDay
            // 
            lblDay.Anchor = AnchorStyles.Left;
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.Transparent;
            lblDay.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblDay.ForeColor = Color.Black;
            lblDay.Location = new Point(246, 4);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(87, 23);
            lblDay.TabIndex = 38;
            lblDay.Text = "Placeholder";
            lblDay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMin
            // 
            picMin.Anchor = AnchorStyles.Right;
            picMin.BackColor = Color.Transparent;
            picMin.BackgroundImage = Properties.Resources.Minimize;
            picMin.BackgroundImageLayout = ImageLayout.Stretch;
            picMin.Cursor = Cursors.Hand;
            picMin.Location = new Point(890, 3);
            picMin.Name = "picMin";
            picMin.Size = new Size(25, 25);
            picMin.TabIndex = 40;
            picMin.TabStop = false;
            picMin.Click += picMin_Click;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(39, 4);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(72, 23);
            lblTime.TabIndex = 36;
            lblTime.Text = "00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(118, 4);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(87, 23);
            lblDate.TabIndex = 37;
            lblDate.Text = "Placeholder";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMax
            // 
            picMax.Anchor = AnchorStyles.Right;
            picMax.BackColor = Color.Transparent;
            picMax.BackgroundImage = Properties.Resources.Maximize;
            picMax.BackgroundImageLayout = ImageLayout.Stretch;
            picMax.Cursor = Cursors.Hand;
            picMax.Location = new Point(930, 3);
            picMax.Name = "picMax";
            picMax.Size = new Size(25, 25);
            picMax.TabIndex = 39;
            picMax.TabStop = false;
            picMax.Click += picMax_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(45, 60, 75);
            ClientSize = new Size(1184, 734);
            ControlBox = false;
            Controls.Add(pnlForm);
            Controls.Add(pnlTop);
            Controls.Add(pnlSideMenu);
            MinimumSize = new Size(236, 0);
            Name = "Home";
            Opacity = 0D;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainMenu_Load;
            pnlForm.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picNight).EndInit();
            pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPFP).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMax).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrClock;
        private Panel pnlTitle;
        private Label lblGreetings;
        private Label lblAnalytics;
        private Panel pnlForm;
        private Button btnRentals;
        private Button btnAccount;
        private Button btnVehicles;
        private PictureBox picNight;
        private System.Windows.Forms.Timer tmrFadeIn;
        private ReaLTaiizor.Controls.ParrotSlidingPanel pnlSideMenu;
        private Panel panel1;
        private Panel pnlRight;
        private Panel panel2;
        private Panel pnlLeft;
        private Panel pnlDown;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private ReaLTaiizor.Controls.ParrotClock parrotClock1;
        private ReaLTaiizor.Controls.ParrotGauge parrotGauge1;
        private PictureBox pictureBox2;
        private PictureBox picPFP;
        private Label lblRole;
        private Label lblUsername;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label14;
        private Label label16;
        private Label label15;
        private Button btnHome;
        private Button btnManageAccount;
        private Button btnUpdateVehicles;
        private Button btnAddVehicles;
        private Button btnRentalDetails;
        private Button btnAllVehicles;
        private Button btnAdminAllUsers;
        private Button btnAdminAllVehicles;
        private Button btnLogout;
        private Button btnExit;
        private Panel pnlTop;
        private Label lblDay;
        private PictureBox picHide;
        private PictureBox picMin;
        private Label lblTime;
        private Label lblDate;
        private PictureBox picMax;
        private FlowLayoutPanel flpDisplayUsers;
        private FlowLayoutPanel flpDisplayVehicles;
        private Label label2;
        private Label label5;
    }
}