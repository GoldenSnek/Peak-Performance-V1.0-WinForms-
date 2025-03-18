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
            pnlTop = new Panel();
            picHide = new PictureBox();
            picMin = new PictureBox();
            lblTime = new Label();
            picMax = new PictureBox();
            lblDate = new Label();
            lblDay = new Label();
            lblGreetings = new Label();
            lblAnalytics = new Label();
            picDay = new PictureBox();
            pnlForm = new Panel();
            panel18 = new Panel();
            parrotGauge1 = new ReaLTaiizor.Controls.ParrotGauge();
            label3 = new Label();
            parrotLineGraph1 = new ReaLTaiizor.Controls.ParrotLineGraph();
            parrotFlatProgressBar1 = new ReaLTaiizor.Controls.ParrotFlatProgressBar();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            parrotPieGraph1 = new ReaLTaiizor.Controls.ParrotPieGraph();
            panel13 = new Panel();
            foreverNotification2 = new ReaLTaiizor.Controls.ForeverNotification();
            label2 = new Label();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            foreverNotification1 = new ReaLTaiizor.Controls.ForeverNotification();
            panel8 = new Panel();
            parrotCircleProgressBar1 = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            parrotBarGraph1 = new ReaLTaiizor.Controls.ParrotBarGraph();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            picNight = new PictureBox();
            panel7 = new Panel();
            parrotClock1 = new ReaLTaiizor.Controls.ParrotClock();
            panel1 = new Panel();
            pnlLeft = new Panel();
            pnlDown = new Panel();
            pnlRight = new Panel();
            panel2 = new Panel();
            tmrFadeIn = new System.Windows.Forms.Timer(components);
            pnlSideMenu = new ReaLTaiizor.Controls.ParrotSlidingPanel();
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
            pictureBox1 = new PictureBox();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDay).BeginInit();
            pnlForm.SuspendLayout();
            panel18.SuspendLayout();
            panel13.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNight).BeginInit();
            panel1.SuspendLayout();
            pnlSideMenu.SuspendLayout();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 128, 0);
            pnlTop.Controls.Add(picHide);
            pnlTop.Controls.Add(picMin);
            pnlTop.Controls.Add(lblTime);
            pnlTop.Controls.Add(picMax);
            pnlTop.Controls.Add(lblDate);
            pnlTop.Controls.Add(lblDay);
            pnlTop.Cursor = Cursors.Hand;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(220, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(964, 30);
            pnlTop.TabIndex = 11;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // picHide
            // 
            picHide.BackColor = Color.Transparent;
            picHide.BackgroundImage = Properties.Resources.HideShowMenu;
            picHide.BackgroundImageLayout = ImageLayout.Stretch;
            picHide.Cursor = Cursors.Hand;
            picHide.Location = new Point(6, 2);
            picHide.Name = "picHide";
            picHide.Size = new Size(25, 25);
            picHide.TabIndex = 35;
            picHide.TabStop = false;
            // 
            // picMin
            // 
            picMin.Anchor = AnchorStyles.Right;
            picMin.BackColor = Color.Transparent;
            picMin.BackgroundImage = Properties.Resources.Minimize;
            picMin.BackgroundImageLayout = ImageLayout.Stretch;
            picMin.Cursor = Cursors.Hand;
            picMin.Location = new Point(887, 2);
            picMin.Name = "picMin";
            picMin.Size = new Size(25, 25);
            picMin.TabIndex = 30;
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
            lblTime.Location = new Point(36, 3);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(72, 23);
            lblTime.TabIndex = 2;
            lblTime.Text = "00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMax
            // 
            picMax.Anchor = AnchorStyles.Right;
            picMax.BackColor = Color.Transparent;
            picMax.BackgroundImage = Properties.Resources.Maximize;
            picMax.BackgroundImageLayout = ImageLayout.Stretch;
            picMax.Cursor = Cursors.Hand;
            picMax.Location = new Point(927, 2);
            picMax.Name = "picMax";
            picMax.Size = new Size(25, 25);
            picMax.TabIndex = 29;
            picMax.TabStop = false;
            picMax.Click += picMax_Click;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(149, 3);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(87, 23);
            lblDate.TabIndex = 3;
            lblDate.Text = "Placeholder";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay
            // 
            lblDay.Anchor = AnchorStyles.Left;
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.Transparent;
            lblDay.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblDay.ForeColor = Color.Black;
            lblDay.Location = new Point(276, 3);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(87, 23);
            lblDay.TabIndex = 4;
            lblDay.Text = "Placeholder";
            lblDay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreetings
            // 
            lblGreetings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblGreetings.AutoSize = true;
            lblGreetings.BackColor = Color.Transparent;
            lblGreetings.Font = new Font("Copperplate Gothic Bold", 14.25F);
            lblGreetings.ForeColor = Color.White;
            lblGreetings.Location = new Point(196, 40);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(511, 21);
            lblGreetings.TabIndex = 5;
            lblGreetings.Text = "Hello {user}! what would you like to do today?";
            lblGreetings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAnalytics
            // 
            lblAnalytics.AutoSize = true;
            lblAnalytics.BackColor = Color.Transparent;
            lblAnalytics.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnalytics.ForeColor = Color.White;
            lblAnalytics.Location = new Point(13, 6);
            lblAnalytics.Name = "lblAnalytics";
            lblAnalytics.Size = new Size(265, 18);
            lblAnalytics.TabIndex = 6;
            lblAnalytics.Text = "Most rented vehicles/users";
            // 
            // picDay
            // 
            picDay.Anchor = AnchorStyles.None;
            picDay.Image = Properties.Resources.Home___Car_Day;
            picDay.Location = new Point(28, 182);
            picDay.Name = "picDay";
            picDay.Size = new Size(50, 50);
            picDay.SizeMode = PictureBoxSizeMode.StretchImage;
            picDay.TabIndex = 8;
            picDay.TabStop = false;
            // 
            // pnlForm
            // 
            pnlForm.AutoScroll = true;
            pnlForm.BackColor = Color.FromArgb(35, 40, 50);
            pnlForm.BackgroundImageLayout = ImageLayout.Stretch;
            pnlForm.Controls.Add(panel18);
            pnlForm.Controls.Add(panel13);
            pnlForm.Controls.Add(panel8);
            pnlForm.Controls.Add(panel3);
            pnlForm.Controls.Add(panel1);
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
            panel18.Controls.Add(parrotGauge1);
            panel18.Controls.Add(label3);
            panel18.Controls.Add(parrotLineGraph1);
            panel18.Controls.Add(parrotFlatProgressBar1);
            panel18.Controls.Add(panel19);
            panel18.Controls.Add(panel20);
            panel18.Controls.Add(panel21);
            panel18.Controls.Add(panel22);
            panel18.Controls.Add(parrotPieGraph1);
            panel18.Location = new Point(580, 158);
            panel18.Name = "panel18";
            panel18.Size = new Size(350, 519);
            panel18.TabIndex = 21;
            // 
            // parrotGauge1
            // 
            parrotGauge1.Anchor = AnchorStyles.None;
            parrotGauge1.BarColor = (List<Color>)resources.GetObject("parrotGauge1.BarColor");
            parrotGauge1.ConsumptionColor = Color.Black;
            parrotGauge1.DialColor = Color.Gray;
            parrotGauge1.DialThickness = 5;
            parrotGauge1.FilledColor = Color.FromArgb(0, 162, 250);
            parrotGauge1.GaugeStyle = ReaLTaiizor.Controls.ParrotGauge.Style.Material;
            parrotGauge1.Location = new Point(112, 364);
            parrotGauge1.Name = "parrotGauge1";
            parrotGauge1.Percentage = 75;
            parrotGauge1.Size = new Size(140, 70);
            parrotGauge1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGauge1.TabIndex = 19;
            parrotGauge1.Text = "parrotGauge1";
            parrotGauge1.Thickness = 8;
            parrotGauge1.UnfilledColor = Color.Gray;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 6);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 20;
            label3.Text = "Analytics";
            // 
            // parrotLineGraph1
            // 
            parrotLineGraph1.Anchor = AnchorStyles.None;
            parrotLineGraph1.BackGroundColor = Color.FromArgb(102, 217, 174);
            parrotLineGraph1.BelowLineColor = Color.FromArgb(24, 202, 142);
            parrotLineGraph1.BorderColor = Color.White;
            parrotLineGraph1.GraphStyle = ReaLTaiizor.Controls.ParrotLineGraph.Style.Material;
            parrotLineGraph1.GraphTitle = "Parrot Line Graph";
            parrotLineGraph1.GraphTitleColor = Color.Gray;
            parrotLineGraph1.Items = (List<int>)resources.GetObject("parrotLineGraph1.Items");
            parrotLineGraph1.LineColor = Color.White;
            parrotLineGraph1.Location = new Point(88, 214);
            parrotLineGraph1.Name = "parrotLineGraph1";
            parrotLineGraph1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotLineGraph1.PointSize = 7;
            parrotLineGraph1.ShowBorder = false;
            parrotLineGraph1.ShowPoints = true;
            parrotLineGraph1.ShowTitle = false;
            parrotLineGraph1.ShowVerticalLines = false;
            parrotLineGraph1.Size = new Size(200, 100);
            parrotLineGraph1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotLineGraph1.TabIndex = 19;
            parrotLineGraph1.Text = "parrotLineGraph1";
            parrotLineGraph1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotLineGraph1.TitleAlignment = StringAlignment.Near;
            parrotLineGraph1.VerticalLineColor = Color.DimGray;
            // 
            // parrotFlatProgressBar1
            // 
            parrotFlatProgressBar1.Anchor = AnchorStyles.None;
            parrotFlatProgressBar1.BarStyle = ReaLTaiizor.Controls.ParrotFlatProgressBar.Style.Material;
            parrotFlatProgressBar1.BorderColor = Color.Black;
            parrotFlatProgressBar1.Colors = (List<Color>)resources.GetObject("parrotFlatProgressBar1.Colors");
            parrotFlatProgressBar1.CompleteBackColor = Color.FromArgb(0, 120, 250);
            parrotFlatProgressBar1.CompleteColor = Color.FromArgb(1, 119, 215);
            parrotFlatProgressBar1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotFlatProgressBar1.IncompletedBackColor = Color.FromArgb(180, 180, 180);
            parrotFlatProgressBar1.InocmpletedColor = Color.White;
            parrotFlatProgressBar1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotFlatProgressBar1.Location = new Point(32, 482);
            parrotFlatProgressBar1.MaxValue = 100;
            parrotFlatProgressBar1.Name = "parrotFlatProgressBar1";
            parrotFlatProgressBar1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotFlatProgressBar1.Positions = (List<float>)resources.GetObject("parrotFlatProgressBar1.Positions");
            parrotFlatProgressBar1.ShowBorder = true;
            parrotFlatProgressBar1.Size = new Size(300, 5);
            parrotFlatProgressBar1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotFlatProgressBar1.TabIndex = 19;
            parrotFlatProgressBar1.Text = "parrotFlatProgressBar1";
            parrotFlatProgressBar1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotFlatProgressBar1.Value = 50;
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(255, 128, 0);
            panel19.Dock = DockStyle.Left;
            panel19.ForeColor = Color.Coral;
            panel19.Location = new Point(0, 3);
            panel19.Name = "panel19";
            panel19.Size = new Size(3, 513);
            panel19.TabIndex = 17;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(255, 128, 0);
            panel20.Dock = DockStyle.Bottom;
            panel20.ForeColor = Color.Coral;
            panel20.Location = new Point(0, 516);
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
            panel21.Size = new Size(3, 516);
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
            // parrotPieGraph1
            // 
            parrotPieGraph1.Anchor = AnchorStyles.None;
            parrotPieGraph1.BackColor = Color.FromArgb(40, 40, 40);
            parrotPieGraph1.Colors = (List<Color>)resources.GetObject("parrotPieGraph1.Colors");
            parrotPieGraph1.Location = new Point(136, 82);
            parrotPieGraph1.Name = "parrotPieGraph1";
            parrotPieGraph1.Numbers = (List<int>)resources.GetObject("parrotPieGraph1.Numbers");
            parrotPieGraph1.Size = new Size(100, 100);
            parrotPieGraph1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPieGraph1.TabIndex = 12;
            parrotPieGraph1.Text = "parrotPieGraph1";
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel13.BackColor = Color.FromArgb(35, 40, 60);
            panel13.Controls.Add(foreverNotification2);
            panel13.Controls.Add(label2);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel15);
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel17);
            panel13.Controls.Add(foreverNotification1);
            panel13.Location = new Point(305, 158);
            panel13.Name = "panel13";
            panel13.Size = new Size(250, 250);
            panel13.TabIndex = 21;
            // 
            // foreverNotification2
            // 
            foreverNotification2.Anchor = AnchorStyles.None;
            foreverNotification2.BackColor = Color.FromArgb(60, 70, 73);
            foreverNotification2.Close = true;
            foreverNotification2.Font = new Font("Segoe UI", 10F);
            foreverNotification2.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            foreverNotification2.Location = new Point(30, 140);
            foreverNotification2.Name = "foreverNotification2";
            foreverNotification2.Size = new Size(185, 42);
            foreverNotification2.TabIndex = 22;
            foreverNotification2.Text = "foreverNotification2";
            foreverNotification2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 6);
            label2.Name = "label2";
            label2.Size = new Size(131, 18);
            label2.TabIndex = 21;
            label2.Text = "Notifications";
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
            // foreverNotification1
            // 
            foreverNotification1.Anchor = AnchorStyles.None;
            foreverNotification1.BackColor = Color.FromArgb(60, 70, 73);
            foreverNotification1.Close = true;
            foreverNotification1.Font = new Font("Segoe UI", 10F);
            foreverNotification1.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            foreverNotification1.Location = new Point(30, 80);
            foreverNotification1.Name = "foreverNotification1";
            foreverNotification1.Size = new Size(185, 42);
            foreverNotification1.TabIndex = 13;
            foreverNotification1.Text = "foreverNotification1";
            foreverNotification1.Visible = false;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(35, 40, 60);
            panel8.Controls.Add(lblAnalytics);
            panel8.Controls.Add(parrotCircleProgressBar1);
            panel8.Controls.Add(parrotBarGraph1);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel11);
            panel8.Controls.Add(panel12);
            panel8.Location = new Point(30, 430);
            panel8.Name = "panel8";
            panel8.Size = new Size(525, 250);
            panel8.TabIndex = 20;
            // 
            // parrotCircleProgressBar1
            // 
            parrotCircleProgressBar1.Anchor = AnchorStyles.None;
            parrotCircleProgressBar1.AnimationSpeed = 5;
            parrotCircleProgressBar1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotCircleProgressBar1.FilledColor = Color.FromArgb(60, 220, 210);
            parrotCircleProgressBar1.FilledColorAlpha = 130;
            parrotCircleProgressBar1.FilledThickness = 40;
            parrotCircleProgressBar1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotCircleProgressBar1.IsAnimated = false;
            parrotCircleProgressBar1.Location = new Point(314, 83);
            parrotCircleProgressBar1.Name = "parrotCircleProgressBar1";
            parrotCircleProgressBar1.Percentage = 50;
            parrotCircleProgressBar1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotCircleProgressBar1.ShowText = true;
            parrotCircleProgressBar1.Size = new Size(124, 117);
            parrotCircleProgressBar1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotCircleProgressBar1.TabIndex = 20;
            parrotCircleProgressBar1.TextColor = Color.Gray;
            parrotCircleProgressBar1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotCircleProgressBar1.TextSize = 25;
            parrotCircleProgressBar1.UnFilledColor = Color.FromArgb(114, 114, 114);
            parrotCircleProgressBar1.UnfilledThickness = 24;
            // 
            // parrotBarGraph1
            // 
            parrotBarGraph1.Anchor = AnchorStyles.None;
            parrotBarGraph1.FilledColor = Color.FromArgb(30, 33, 38);
            parrotBarGraph1.GraphOrientation = ReaLTaiizor.Controls.ParrotBarGraph.Orientation.Vertical;
            parrotBarGraph1.GraphStyle = ReaLTaiizor.Controls.ParrotBarGraph.Style.Material;
            parrotBarGraph1.Items = (List<int>)resources.GetObject("parrotBarGraph1.Items");
            parrotBarGraph1.Location = new Point(55, 66);
            parrotBarGraph1.Name = "parrotBarGraph1";
            parrotBarGraph1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotBarGraph1.ShowGrid = false;
            parrotBarGraph1.Size = new Size(219, 149);
            parrotBarGraph1.Sorting = ReaLTaiizor.Controls.ParrotBarGraph.SortStyle.Normal;
            parrotBarGraph1.SplitterColor = Color.FromArgb(59, 62, 71);
            parrotBarGraph1.TabIndex = 19;
            parrotBarGraph1.Text = "parrotBarGraph1";
            parrotBarGraph1.TextAlignment = ReaLTaiizor.Controls.ParrotBarGraph.Aligning.Far;
            parrotBarGraph1.TextColor = Color.FromArgb(120, 120, 120);
            parrotBarGraph1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotBarGraph1.UnfilledColor = Color.FromArgb(37, 40, 49);
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.FromArgb(35, 40, 60);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(picNight);
            panel3.Controls.Add(picDay);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(parrotClock1);
            panel3.Location = new Point(30, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 250);
            panel3.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(47, 18);
            label1.TabIndex = 20;
            label1.Text = "Time";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 128, 0);
            panel4.Dock = DockStyle.Left;
            panel4.ForeColor = Color.Coral;
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 244);
            panel4.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 0);
            panel5.Dock = DockStyle.Bottom;
            panel5.ForeColor = Color.Coral;
            panel5.Location = new Point(0, 247);
            panel5.Name = "panel5";
            panel5.Size = new Size(247, 3);
            panel5.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 128, 0);
            panel6.Dock = DockStyle.Right;
            panel6.ForeColor = Color.Coral;
            panel6.Location = new Point(247, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(3, 247);
            panel6.TabIndex = 16;
            // 
            // picNight
            // 
            picNight.Anchor = AnchorStyles.None;
            picNight.Image = Properties.Resources.Home___Car_Night;
            picNight.Location = new Point(171, 182);
            picNight.Name = "picNight";
            picNight.Size = new Size(50, 50);
            picNight.SizeMode = PictureBoxSizeMode.StretchImage;
            picNight.TabIndex = 9;
            picNight.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 128, 0);
            panel7.Dock = DockStyle.Top;
            panel7.ForeColor = Color.Coral;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 3);
            panel7.TabIndex = 15;
            // 
            // parrotClock1
            // 
            parrotClock1.Anchor = AnchorStyles.None;
            parrotClock1.CircleThickness = 3;
            parrotClock1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotClock1.DisplayFormat = ReaLTaiizor.Controls.ParrotClock.HourFormat.TwelveHour;
            parrotClock1.FilledHourColor = Color.FromArgb(255, 128, 0);
            parrotClock1.FilledMinuteColor = Color.Empty;
            parrotClock1.FilledSecondColor = Color.Blue;
            parrotClock1.Font = new Font("Impact", 15F);
            parrotClock1.HexagonColor = Color.Black;
            parrotClock1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotClock1.Location = new Point(31, 3);
            parrotClock1.Name = "parrotClock1";
            parrotClock1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotClock1.ShowAmPm = true;
            parrotClock1.ShowHexagon = false;
            parrotClock1.ShowMinutesCircle = true;
            parrotClock1.ShowSecondsCircle = true;
            parrotClock1.Size = new Size(190, 200);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(35, 40, 60);
            panel1.Controls.Add(pnlLeft);
            panel1.Controls.Add(pnlDown);
            panel1.Controls.Add(pnlRight);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblGreetings);
            panel1.Location = new Point(30, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 100);
            panel1.TabIndex = 14;
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
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial Rounded MT Bold", 12F);
            btnExit.ForeColor = Color.White;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 730);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.RightToLeft = RightToLeft.No;
            btnExit.Size = new Size(203, 60);
            btnExit.TabIndex = 23;
            btnExit.Text = "  EXIT";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 12F);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 670);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(203, 60);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageAccount
            // 
            btnManageAccount.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManageAccount.BackColor = Color.Transparent;
            btnManageAccount.Cursor = Cursors.Hand;
            btnManageAccount.Dock = DockStyle.Top;
            btnManageAccount.FlatAppearance.BorderSize = 0;
            btnManageAccount.FlatStyle = FlatStyle.Flat;
            btnManageAccount.Font = new Font("Arial Rounded MT Bold", 12F);
            btnManageAccount.ForeColor = Color.White;
            btnManageAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageAccount.Location = new Point(0, 610);
            btnManageAccount.Name = "btnManageAccount";
            btnManageAccount.Padding = new Padding(10, 0, 0, 0);
            btnManageAccount.RightToLeft = RightToLeft.No;
            btnManageAccount.Size = new Size(203, 60);
            btnManageAccount.TabIndex = 22;
            btnManageAccount.Text = "  Manage Account";
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
            btnUpdateVehicles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateVehicles.BackColor = Color.Transparent;
            btnUpdateVehicles.Cursor = Cursors.Hand;
            btnUpdateVehicles.Dock = DockStyle.Top;
            btnUpdateVehicles.FlatAppearance.BorderSize = 0;
            btnUpdateVehicles.FlatStyle = FlatStyle.Flat;
            btnUpdateVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnUpdateVehicles.ForeColor = Color.White;
            btnUpdateVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateVehicles.Location = new Point(0, 520);
            btnUpdateVehicles.Name = "btnUpdateVehicles";
            btnUpdateVehicles.Padding = new Padding(10, 0, 0, 0);
            btnUpdateVehicles.RightToLeft = RightToLeft.No;
            btnUpdateVehicles.Size = new Size(203, 60);
            btnUpdateVehicles.TabIndex = 21;
            btnUpdateVehicles.Text = "  Update Vehicles";
            btnUpdateVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateVehicles.UseVisualStyleBackColor = false;
            btnUpdateVehicles.Click += btnUpdateVehicles_Click;
            // 
            // btnAddVehicles
            // 
            btnAddVehicles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddVehicles.BackColor = Color.Transparent;
            btnAddVehicles.Cursor = Cursors.Hand;
            btnAddVehicles.Dock = DockStyle.Top;
            btnAddVehicles.FlatAppearance.BorderSize = 0;
            btnAddVehicles.FlatStyle = FlatStyle.Flat;
            btnAddVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAddVehicles.ForeColor = Color.White;
            btnAddVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddVehicles.Location = new Point(0, 460);
            btnAddVehicles.Name = "btnAddVehicles";
            btnAddVehicles.Padding = new Padding(10, 0, 0, 0);
            btnAddVehicles.RightToLeft = RightToLeft.No;
            btnAddVehicles.Size = new Size(203, 60);
            btnAddVehicles.TabIndex = 20;
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
            btnRentalDetails.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRentalDetails.BackColor = Color.Transparent;
            btnRentalDetails.Cursor = Cursors.Hand;
            btnRentalDetails.Dock = DockStyle.Top;
            btnRentalDetails.FlatAppearance.BorderSize = 0;
            btnRentalDetails.FlatStyle = FlatStyle.Flat;
            btnRentalDetails.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRentalDetails.ForeColor = Color.White;
            btnRentalDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentalDetails.Location = new Point(0, 370);
            btnRentalDetails.Name = "btnRentalDetails";
            btnRentalDetails.Padding = new Padding(10, 0, 0, 0);
            btnRentalDetails.RightToLeft = RightToLeft.No;
            btnRentalDetails.Size = new Size(203, 60);
            btnRentalDetails.TabIndex = 19;
            btnRentalDetails.Text = "  Rental Details";
            btnRentalDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnRentalDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRentalDetails.UseVisualStyleBackColor = false;
            btnRentalDetails.Click += btnRentalDetails_Click;
            // 
            // btnAllVehicles
            // 
            btnAllVehicles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAllVehicles.BackColor = Color.Transparent;
            btnAllVehicles.Cursor = Cursors.Hand;
            btnAllVehicles.Dock = DockStyle.Top;
            btnAllVehicles.FlatAppearance.BorderSize = 0;
            btnAllVehicles.FlatStyle = FlatStyle.Flat;
            btnAllVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAllVehicles.ForeColor = Color.White;
            btnAllVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnAllVehicles.Location = new Point(0, 310);
            btnAllVehicles.Name = "btnAllVehicles";
            btnAllVehicles.Padding = new Padding(10, 0, 0, 0);
            btnAllVehicles.RightToLeft = RightToLeft.No;
            btnAllVehicles.Size = new Size(203, 60);
            btnAllVehicles.TabIndex = 18;
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
            btnAdminAllUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdminAllUsers.BackColor = Color.Transparent;
            btnAdminAllUsers.Cursor = Cursors.Hand;
            btnAdminAllUsers.Dock = DockStyle.Top;
            btnAdminAllUsers.FlatAppearance.BorderSize = 0;
            btnAdminAllUsers.FlatStyle = FlatStyle.Flat;
            btnAdminAllUsers.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAdminAllUsers.ForeColor = Color.White;
            btnAdminAllUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdminAllUsers.Location = new Point(0, 220);
            btnAdminAllUsers.Name = "btnAdminAllUsers";
            btnAdminAllUsers.Padding = new Padding(10, 0, 0, 0);
            btnAdminAllUsers.RightToLeft = RightToLeft.No;
            btnAdminAllUsers.Size = new Size(203, 60);
            btnAdminAllUsers.TabIndex = 30;
            btnAdminAllUsers.Text = "  Users";
            btnAdminAllUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnAdminAllUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdminAllUsers.UseVisualStyleBackColor = false;
            btnAdminAllUsers.Click += btnAdminAllUsers_Click;
            // 
            // btnAdminAllVehicles
            // 
            btnAdminAllVehicles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdminAllVehicles.BackColor = Color.Transparent;
            btnAdminAllVehicles.Cursor = Cursors.Hand;
            btnAdminAllVehicles.Dock = DockStyle.Top;
            btnAdminAllVehicles.FlatAppearance.BorderSize = 0;
            btnAdminAllVehicles.FlatStyle = FlatStyle.Flat;
            btnAdminAllVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAdminAllVehicles.ForeColor = Color.White;
            btnAdminAllVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdminAllVehicles.Location = new Point(0, 160);
            btnAdminAllVehicles.Name = "btnAdminAllVehicles";
            btnAdminAllVehicles.Padding = new Padding(10, 0, 0, 0);
            btnAdminAllVehicles.RightToLeft = RightToLeft.No;
            btnAdminAllVehicles.Size = new Size(203, 60);
            btnAdminAllVehicles.TabIndex = 29;
            btnAdminAllVehicles.Text = "  Vehicles";
            btnAdminAllVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnAdminAllVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdminAllVehicles.UseVisualStyleBackColor = false;
            btnAdminAllVehicles.Click += btnAdminAllVehicles_Click;
            // 
            // btnHome
            // 
            btnHome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHome.BackColor = Color.Transparent;
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial Rounded MT Bold", 12F);
            btnHome.ForeColor = Color.White;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 100);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.RightToLeft = RightToLeft.No;
            btnHome.Size = new Size(203, 60);
            btnHome.TabIndex = 17;
            btnHome.Text = "  Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(35, 40, 60);
            pnlTitle.Controls.Add(pictureBox1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(203, 100);
            pnlTitle.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.MainLogo;
            pictureBox1.Location = new Point(-23, -78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDay).EndInit();
            pnlForm.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNight).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSideMenu.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrClock;
        private Button btnHome;
        private Button btnLogout;
        private Button btnExit;
        private Button btnManageAccount;
        private Button btnUpdateVehicles;
        private Button btnAddVehicles;
        private Button btnRentalDetails;
        private Button btnAllVehicles;
        private Panel pnlTop;
        private Panel pnlTitle;
        private PictureBox picMax;
        private PictureBox picMin;
        private Label lblDate;
        private Label lblDay;
        private Label lblTime;
        private Label lblGreetings;
        private Label lblAnalytics;
        private PictureBox picDay;
        private Panel pnlForm;
        private Button btnRentals;
        private Button btnAccount;
        private Button btnVehicles;
        private PictureBox picNight;
        private ReaLTaiizor.Controls.ForeverNotification foreverNotification1;
        private ReaLTaiizor.Controls.ParrotPieGraph parrotPieGraph1;
        private Button btnAdminAllUsers;
        private Button btnAdminAllVehicles;
        private System.Windows.Forms.Timer tmrFadeIn;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ParrotSlidingPanel pnlSideMenu;
        private PictureBox picHide;
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
        private ReaLTaiizor.Controls.ParrotLineGraph parrotLineGraph1;
        private ReaLTaiizor.Controls.ParrotBarGraph parrotBarGraph1;
        private ReaLTaiizor.Controls.ParrotCircleProgressBar parrotCircleProgressBar1;
        private ReaLTaiizor.Controls.ParrotFlatProgressBar parrotFlatProgressBar1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ReaLTaiizor.Controls.ForeverNotification foreverNotification2;
    }
}