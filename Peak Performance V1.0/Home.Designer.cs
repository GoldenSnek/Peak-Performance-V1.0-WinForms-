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
            pnlSideMenu = new Panel();
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
            picHide = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlTop = new Panel();
            picShow = new PictureBox();
            picMin = new PictureBox();
            picMax = new PictureBox();
            lblDate = new Label();
            lblDay = new Label();
            lblTime = new Label();
            lblGreetings = new Label();
            lblNotifications = new Label();
            lblAnalytics = new Label();
            picDay = new PictureBox();
            pnlForm = new Panel();
            foreverNotification1 = new ReaLTaiizor.Controls.ForeverNotification();
            parrotPieGraph1 = new ReaLTaiizor.Controls.ParrotPieGraph();
            picNight = new PictureBox();
            tmrFadeIn = new System.Windows.Forms.Timer(components);
            pnlSideMenu.SuspendLayout();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDay).BeginInit();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNight).BeginInit();
            SuspendLayout();
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.AutoScroll = true;
            pnlSideMenu.BackColor = Color.FromArgb(45, 60, 75);
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
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.RightToLeft = RightToLeft.Yes;
            pnlSideMenu.Size = new Size(220, 734);
            pnlSideMenu.TabIndex = 10;
            // 
            // btnExit
            // 
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
            btnExit.TabIndex = 8;
            btnExit.Text = "  EXIT";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
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
            btnLogout.TabIndex = 9;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageAccount
            // 
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
            btnManageAccount.TabIndex = 7;
            btnManageAccount.Text = "  Manage Account";
            btnManageAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnManageAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageAccount.UseVisualStyleBackColor = true;
            btnManageAccount.Click += btnManageAccount_Click;
            // 
            // btnAccount
            // 
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
            btnAccount.TabIndex = 14;
            btnAccount.Text = "  ACCOUNT";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnUpdateVehicles
            // 
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
            btnUpdateVehicles.TabIndex = 6;
            btnUpdateVehicles.Text = "  Update Vehicles";
            btnUpdateVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateVehicles.UseVisualStyleBackColor = true;
            btnUpdateVehicles.Click += btnUpdateVehicles_Click;
            // 
            // btnAddVehicles
            // 
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
            btnAddVehicles.TabIndex = 5;
            btnAddVehicles.Text = "  Add Vehicles";
            btnAddVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnAddVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddVehicles.UseVisualStyleBackColor = true;
            btnAddVehicles.Click += btnAddVehicles_Click;
            // 
            // btnVehicles
            // 
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
            btnVehicles.TabIndex = 13;
            btnVehicles.Text = "  VEHICLES";
            btnVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehicles.UseVisualStyleBackColor = false;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnRentalDetails
            // 
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
            btnRentalDetails.TabIndex = 4;
            btnRentalDetails.Text = "  Rental Details";
            btnRentalDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnRentalDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRentalDetails.UseVisualStyleBackColor = true;
            btnRentalDetails.Click += btnRentalDetails_Click;
            // 
            // btnAllVehicles
            // 
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
            btnAllVehicles.TabIndex = 3;
            btnAllVehicles.Text = "  All Vehicles";
            btnAllVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnAllVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAllVehicles.UseVisualStyleBackColor = true;
            btnAllVehicles.Click += btnAllVehicles_Click;
            // 
            // btnRentals
            // 
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
            btnRentals.TabIndex = 10;
            btnRentals.Text = "  RENTALS";
            btnRentals.TextAlign = ContentAlignment.MiddleLeft;
            btnRentals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRentals.UseVisualStyleBackColor = false;
            btnRentals.Click += btnRentals_Click;
            // 
            // btnAdminAllUsers
            // 
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
            btnAdminAllUsers.TabIndex = 16;
            btnAdminAllUsers.Text = "  Users";
            btnAdminAllUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnAdminAllUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdminAllUsers.UseVisualStyleBackColor = true;
            btnAdminAllUsers.Click += btnAdminAllUsers_Click;
            // 
            // btnAdminAllVehicles
            // 
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
            btnAdminAllVehicles.TabIndex = 15;
            btnAdminAllVehicles.Text = "  Vehicles";
            btnAdminAllVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnAdminAllVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdminAllVehicles.UseVisualStyleBackColor = true;
            btnAdminAllVehicles.Click += btnAdminAllVehicles_Click;
            // 
            // btnHome
            // 
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
            btnHome.TabIndex = 2;
            btnHome.Text = "  Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(35, 40, 60);
            pnlTitle.Controls.Add(picHide);
            pnlTitle.Controls.Add(pictureBox1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(203, 100);
            pnlTitle.TabIndex = 12;
            // 
            // picHide
            // 
            picHide.BackColor = Color.Transparent;
            picHide.BackgroundImage = Properties.Resources.HideShowMenu;
            picHide.BackgroundImageLayout = ImageLayout.Stretch;
            picHide.Cursor = Cursors.Hand;
            picHide.Location = new Point(3, 2);
            picHide.Name = "picHide";
            picHide.Size = new Size(25, 25);
            picHide.TabIndex = 31;
            picHide.TabStop = false;
            picHide.Click += picHide_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.MainLogo;
            pictureBox1.Location = new Point(-24, -73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 128, 0);
            pnlTop.Controls.Add(picShow);
            pnlTop.Controls.Add(picMin);
            pnlTop.Controls.Add(picMax);
            pnlTop.Cursor = Cursors.Hand;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(220, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(964, 30);
            pnlTop.TabIndex = 11;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // picShow
            // 
            picShow.Anchor = AnchorStyles.Left;
            picShow.BackColor = Color.Transparent;
            picShow.BackgroundImage = Properties.Resources.HideShowMenu;
            picShow.BackgroundImageLayout = ImageLayout.Stretch;
            picShow.Cursor = Cursors.Hand;
            picShow.Location = new Point(3, 2);
            picShow.Name = "picShow";
            picShow.Size = new Size(25, 25);
            picShow.TabIndex = 32;
            picShow.TabStop = false;
            picShow.Visible = false;
            picShow.Click += picShow_Click;
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
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(387, 246);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(177, 47);
            lblDate.TabIndex = 3;
            lblDate.Text = "Placeholder";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDay
            // 
            lblDay.Anchor = AnchorStyles.None;
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.Transparent;
            lblDay.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(387, 293);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(177, 47);
            lblDay.TabIndex = 4;
            lblDay.Text = "Placeholder";
            lblDay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.None;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe Print", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.FromArgb(255, 128, 0);
            lblTime.Location = new Point(224, 103);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(548, 170);
            lblTime.TabIndex = 2;
            lblTime.Text = "00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreetings
            // 
            lblGreetings.Anchor = AnchorStyles.None;
            lblGreetings.AutoSize = true;
            lblGreetings.BackColor = Color.Transparent;
            lblGreetings.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold);
            lblGreetings.ForeColor = Color.White;
            lblGreetings.Location = new Point(159, 83);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(658, 47);
            lblGreetings.TabIndex = 5;
            lblGreetings.Text = "Hello {user}! what would you like to do today?";
            lblGreetings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotifications
            // 
            lblNotifications.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNotifications.AutoSize = true;
            lblNotifications.ForeColor = Color.White;
            lblNotifications.Location = new Point(720, 434);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new Size(85, 19);
            lblNotifications.TabIndex = 7;
            lblNotifications.Text = "Notifications";
            lblNotifications.Visible = false;
            // 
            // lblAnalytics
            // 
            lblAnalytics.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAnalytics.AutoSize = true;
            lblAnalytics.ForeColor = Color.White;
            lblAnalytics.Location = new Point(110, 434);
            lblAnalytics.Name = "lblAnalytics";
            lblAnalytics.Size = new Size(63, 19);
            lblAnalytics.TabIndex = 6;
            lblAnalytics.Text = "Analytics";
            lblAnalytics.Visible = false;
            // 
            // picDay
            // 
            picDay.Anchor = AnchorStyles.None;
            picDay.Image = Properties.Resources.Home___Car_Day;
            picDay.Location = new Point(399, 372);
            picDay.Name = "picDay";
            picDay.Size = new Size(150, 150);
            picDay.SizeMode = PictureBoxSizeMode.StretchImage;
            picDay.TabIndex = 8;
            picDay.TabStop = false;
            // 
            // pnlForm
            // 
            pnlForm.AutoScroll = true;
            pnlForm.BackColor = Color.FromArgb(35, 40, 50);
            pnlForm.BackgroundImageLayout = ImageLayout.Stretch;
            pnlForm.Controls.Add(foreverNotification1);
            pnlForm.Controls.Add(parrotPieGraph1);
            pnlForm.Controls.Add(picDay);
            pnlForm.Controls.Add(picNight);
            pnlForm.Controls.Add(lblAnalytics);
            pnlForm.Controls.Add(lblNotifications);
            pnlForm.Controls.Add(lblGreetings);
            pnlForm.Controls.Add(lblDay);
            pnlForm.Controls.Add(lblDate);
            pnlForm.Controls.Add(lblTime);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(220, 30);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(964, 704);
            pnlForm.TabIndex = 12;
            // 
            // foreverNotification1
            // 
            foreverNotification1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            foreverNotification1.BackColor = Color.FromArgb(60, 70, 73);
            foreverNotification1.Close = true;
            foreverNotification1.Font = new Font("Segoe UI", 10F);
            foreverNotification1.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            foreverNotification1.Location = new Point(657, 548);
            foreverNotification1.Name = "foreverNotification1";
            foreverNotification1.Size = new Size(215, 42);
            foreverNotification1.TabIndex = 13;
            foreverNotification1.Text = "foreverNotification1";
            foreverNotification1.Visible = false;
            // 
            // parrotPieGraph1
            // 
            parrotPieGraph1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            parrotPieGraph1.BackColor = Color.FromArgb(40, 40, 40);
            parrotPieGraph1.Colors = (List<Color>)resources.GetObject("parrotPieGraph1.Colors");
            parrotPieGraph1.Location = new Point(95, 490);
            parrotPieGraph1.Name = "parrotPieGraph1";
            parrotPieGraph1.Numbers = (List<int>)resources.GetObject("parrotPieGraph1.Numbers");
            parrotPieGraph1.Size = new Size(100, 100);
            parrotPieGraph1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPieGraph1.TabIndex = 12;
            parrotPieGraph1.Text = "parrotPieGraph1";
            parrotPieGraph1.Visible = false;
            // 
            // picNight
            // 
            picNight.Anchor = AnchorStyles.None;
            picNight.Image = Properties.Resources.Home___Car_Night;
            picNight.Location = new Point(399, 372);
            picNight.Name = "picNight";
            picNight.Size = new Size(150, 150);
            picNight.SizeMode = PictureBoxSizeMode.StretchImage;
            picNight.TabIndex = 9;
            picNight.TabStop = false;
            // 
            // tmrFadeIn
            // 
            tmrFadeIn.Interval = 10;
            tmrFadeIn.Tick += tmrFadeIn_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1184, 734);
            ControlBox = false;
            Controls.Add(pnlForm);
            Controls.Add(pnlTop);
            Controls.Add(pnlSideMenu);
            MinimumSize = new Size(236, 0);
            Name = "Home";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainMenu_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDay).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNight).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrClock;
        private Panel pnlSideMenu;
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
        private Label lblNotifications;
        private Label lblAnalytics;
        private PictureBox picDay;
        private Panel pnlForm;
        private PictureBox picHide;
        private PictureBox picShow;
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
    }
}