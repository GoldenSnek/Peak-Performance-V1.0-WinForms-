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
            btnHome = new Button();
            pnlTitle = new Panel();
            picHide = new PictureBox();
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
            objectAnimator1 = new ReaLTaiizor.Animate.Parrot.ObjectAnimator();
            objectAnimator2 = new ReaLTaiizor.Animate.Parrot.ObjectAnimator();
            pnlSideMenu.SuspendLayout();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
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
            pnlSideMenu.Controls.Add(btnHome);
            pnlSideMenu.Controls.Add(pnlTitle);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.RightToLeft = RightToLeft.Yes;
            pnlSideMenu.Size = new Size(220, 784);
            pnlSideMenu.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial Rounded MT Bold", 12F);
            btnExit.ForeColor = Color.White;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 680);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.RightToLeft = RightToLeft.No;
            btnExit.Size = new Size(220, 70);
            btnExit.TabIndex = 8;
            btnExit.Text = "  EXIT";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 12F);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 610);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(220, 70);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageAccount
            // 
            btnManageAccount.Dock = DockStyle.Top;
            btnManageAccount.FlatAppearance.BorderSize = 0;
            btnManageAccount.FlatStyle = FlatStyle.Flat;
            btnManageAccount.Font = new Font("Arial Rounded MT Bold", 12F);
            btnManageAccount.ForeColor = Color.White;
            btnManageAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageAccount.Location = new Point(0, 540);
            btnManageAccount.Name = "btnManageAccount";
            btnManageAccount.Padding = new Padding(10, 0, 0, 0);
            btnManageAccount.RightToLeft = RightToLeft.No;
            btnManageAccount.Size = new Size(220, 70);
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
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAccount.ForeColor = Color.FromArgb(255, 128, 0);
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 510);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(10, 0, 0, 0);
            btnAccount.RightToLeft = RightToLeft.No;
            btnAccount.Size = new Size(220, 30);
            btnAccount.TabIndex = 14;
            btnAccount.Text = "  ACCOUNT";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnUpdateVehicles
            // 
            btnUpdateVehicles.Dock = DockStyle.Top;
            btnUpdateVehicles.FlatAppearance.BorderSize = 0;
            btnUpdateVehicles.FlatStyle = FlatStyle.Flat;
            btnUpdateVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnUpdateVehicles.ForeColor = Color.White;
            btnUpdateVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateVehicles.Location = new Point(0, 440);
            btnUpdateVehicles.Name = "btnUpdateVehicles";
            btnUpdateVehicles.Padding = new Padding(10, 0, 0, 0);
            btnUpdateVehicles.RightToLeft = RightToLeft.No;
            btnUpdateVehicles.Size = new Size(220, 70);
            btnUpdateVehicles.TabIndex = 6;
            btnUpdateVehicles.Text = "  Update Vehicles";
            btnUpdateVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateVehicles.UseVisualStyleBackColor = true;
            btnUpdateVehicles.Click += btnUpdateVehicles_Click;
            // 
            // btnAddVehicles
            // 
            btnAddVehicles.Dock = DockStyle.Top;
            btnAddVehicles.FlatAppearance.BorderSize = 0;
            btnAddVehicles.FlatStyle = FlatStyle.Flat;
            btnAddVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAddVehicles.ForeColor = Color.White;
            btnAddVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddVehicles.Location = new Point(0, 370);
            btnAddVehicles.Name = "btnAddVehicles";
            btnAddVehicles.Padding = new Padding(10, 0, 0, 0);
            btnAddVehicles.RightToLeft = RightToLeft.No;
            btnAddVehicles.Size = new Size(220, 70);
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
            btnVehicles.Dock = DockStyle.Top;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnVehicles.ForeColor = Color.FromArgb(255, 128, 0);
            btnVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicles.Location = new Point(0, 340);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Padding = new Padding(10, 0, 0, 0);
            btnVehicles.RightToLeft = RightToLeft.No;
            btnVehicles.Size = new Size(220, 30);
            btnVehicles.TabIndex = 13;
            btnVehicles.Text = "  VEHICLES";
            btnVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVehicles.UseVisualStyleBackColor = false;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnRentalDetails
            // 
            btnRentalDetails.Dock = DockStyle.Top;
            btnRentalDetails.FlatAppearance.BorderSize = 0;
            btnRentalDetails.FlatStyle = FlatStyle.Flat;
            btnRentalDetails.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRentalDetails.ForeColor = Color.White;
            btnRentalDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentalDetails.Location = new Point(0, 270);
            btnRentalDetails.Name = "btnRentalDetails";
            btnRentalDetails.Padding = new Padding(10, 0, 0, 0);
            btnRentalDetails.RightToLeft = RightToLeft.No;
            btnRentalDetails.Size = new Size(220, 70);
            btnRentalDetails.TabIndex = 4;
            btnRentalDetails.Text = "  Rental Details";
            btnRentalDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnRentalDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRentalDetails.UseVisualStyleBackColor = true;
            btnRentalDetails.Click += btnRentalDetails_Click;
            // 
            // btnAllVehicles
            // 
            btnAllVehicles.Dock = DockStyle.Top;
            btnAllVehicles.FlatAppearance.BorderSize = 0;
            btnAllVehicles.FlatStyle = FlatStyle.Flat;
            btnAllVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAllVehicles.ForeColor = Color.White;
            btnAllVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnAllVehicles.Location = new Point(0, 200);
            btnAllVehicles.Name = "btnAllVehicles";
            btnAllVehicles.Padding = new Padding(10, 0, 0, 0);
            btnAllVehicles.RightToLeft = RightToLeft.No;
            btnAllVehicles.Size = new Size(220, 70);
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
            btnRentals.Dock = DockStyle.Top;
            btnRentals.FlatAppearance.BorderSize = 0;
            btnRentals.FlatStyle = FlatStyle.Flat;
            btnRentals.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRentals.ForeColor = Color.FromArgb(255, 128, 0);
            btnRentals.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentals.Location = new Point(0, 170);
            btnRentals.Name = "btnRentals";
            btnRentals.Padding = new Padding(10, 0, 0, 0);
            btnRentals.RightToLeft = RightToLeft.No;
            btnRentals.Size = new Size(220, 30);
            btnRentals.TabIndex = 10;
            btnRentals.Text = "  RENTALS";
            btnRentals.TextAlign = ContentAlignment.MiddleLeft;
            btnRentals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRentals.UseVisualStyleBackColor = false;
            btnRentals.Click += btnRentals_Click;
            // 
            // btnHome
            // 
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
            btnHome.Size = new Size(220, 70);
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
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(220, 100);
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
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 128, 0);
            pnlTop.Controls.Add(picShow);
            pnlTop.Controls.Add(picMin);
            pnlTop.Controls.Add(picMax);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(220, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(964, 30);
            pnlTop.TabIndex = 11;
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
            lblDate.Location = new Point(394, 330);
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
            lblDay.Location = new Point(394, 387);
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
            lblTime.Location = new Point(231, 197);
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
            lblGreetings.Location = new Point(166, 177);
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
            lblNotifications.Location = new Point(727, 553);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new Size(85, 19);
            lblNotifications.TabIndex = 7;
            lblNotifications.Text = "Notifications";
            // 
            // lblAnalytics
            // 
            lblAnalytics.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAnalytics.AutoSize = true;
            lblAnalytics.ForeColor = Color.White;
            lblAnalytics.Location = new Point(117, 553);
            lblAnalytics.Name = "lblAnalytics";
            lblAnalytics.Size = new Size(63, 19);
            lblAnalytics.TabIndex = 6;
            lblAnalytics.Text = "Analytics";
            // 
            // picDay
            // 
            picDay.Anchor = AnchorStyles.None;
            picDay.Image = Properties.Resources.Home___Car_Day;
            picDay.Location = new Point(406, 20);
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
            pnlForm.Size = new Size(964, 754);
            pnlForm.TabIndex = 12;
            // 
            // foreverNotification1
            // 
            foreverNotification1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            foreverNotification1.BackColor = Color.FromArgb(60, 70, 73);
            foreverNotification1.Close = true;
            foreverNotification1.Font = new Font("Segoe UI", 10F);
            foreverNotification1.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            foreverNotification1.Location = new Point(664, 667);
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
            parrotPieGraph1.Location = new Point(102, 609);
            parrotPieGraph1.Name = "parrotPieGraph1";
            parrotPieGraph1.Numbers = (List<int>)resources.GetObject("parrotPieGraph1.Numbers");
            parrotPieGraph1.Size = new Size(100, 100);
            parrotPieGraph1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPieGraph1.TabIndex = 12;
            parrotPieGraph1.Text = "parrotPieGraph1";
            // 
            // picNight
            // 
            picNight.Anchor = AnchorStyles.None;
            picNight.Image = Properties.Resources.Home___Car_Night;
            picNight.Location = new Point(406, 20);
            picNight.Name = "picNight";
            picNight.Size = new Size(150, 150);
            picNight.SizeMode = PictureBoxSizeMode.StretchImage;
            picNight.TabIndex = 9;
            picNight.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1184, 784);
            ControlBox = false;
            Controls.Add(pnlForm);
            Controls.Add(pnlTop);
            Controls.Add(pnlSideMenu);
            MinimumSize = new Size(236, 0);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainMenu_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
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
        private ReaLTaiizor.Animate.Parrot.ObjectAnimator objectAnimator1;
        private PictureBox picNight;
        private ReaLTaiizor.Animate.Parrot.ObjectAnimator objectAnimator2;
        private ReaLTaiizor.Controls.ForeverNotification foreverNotification1;
        private ReaLTaiizor.Controls.ParrotPieGraph parrotPieGraph1;
    }
}