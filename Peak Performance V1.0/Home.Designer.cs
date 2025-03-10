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
            lblTime = new Label();
            lblDate = new Label();
            lblDay = new Label();
            tmrClock = new System.Windows.Forms.Timer(components);
            lblGreetings = new Label();
            lblAnalytics = new Label();
            lblNotifications = new Label();
            picDay = new PictureBox();
            picNight = new PictureBox();
            pnlSideMenu = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            btnManageAccount = new Button();
            btnUpdateVehicles = new Button();
            btnAddVehicles = new Button();
            btnRentalDetails = new Button();
            btnAllVehicles = new Button();
            btnHome = new Button();
            pnlTitle = new Panel();
            pnlTop = new Panel();
            pnlForm = new Panel();
            picMax = new PictureBox();
            picMin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNight).BeginInit();
            pnlSideMenu.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMin).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.None;
            lblTime.AutoSize = true;
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(460, 351);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(63, 19);
            lblTime.TabIndex = 2;
            lblTime.Text = "00:00:00";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(460, 407);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(79, 19);
            lblDate.TabIndex = 3;
            lblDate.Text = "Placeholder";
            // 
            // lblDay
            // 
            lblDay.Anchor = AnchorStyles.None;
            lblDay.AutoSize = true;
            lblDay.ForeColor = Color.Black;
            lblDay.Location = new Point(460, 445);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(79, 19);
            lblDay.TabIndex = 4;
            lblDay.Text = "Placeholder";
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // lblGreetings
            // 
            lblGreetings.Anchor = AnchorStyles.None;
            lblGreetings.AutoSize = true;
            lblGreetings.ForeColor = Color.Black;
            lblGreetings.Location = new Point(342, 295);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(290, 19);
            lblGreetings.TabIndex = 5;
            lblGreetings.Text = "Hello {user}! what would you like to do today?";
            // 
            // lblAnalytics
            // 
            lblAnalytics.Anchor = AnchorStyles.None;
            lblAnalytics.AutoSize = true;
            lblAnalytics.ForeColor = Color.Black;
            lblAnalytics.Location = new Point(238, 558);
            lblAnalytics.Name = "lblAnalytics";
            lblAnalytics.Size = new Size(63, 19);
            lblAnalytics.TabIndex = 6;
            lblAnalytics.Text = "Analytics";
            // 
            // lblNotifications
            // 
            lblNotifications.Anchor = AnchorStyles.None;
            lblNotifications.AutoSize = true;
            lblNotifications.ForeColor = Color.Black;
            lblNotifications.Location = new Point(665, 558);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new Size(85, 19);
            lblNotifications.TabIndex = 7;
            lblNotifications.Text = "Notifications";
            // 
            // picDay
            // 
            picDay.Anchor = AnchorStyles.None;
            picDay.Image = Properties.Resources.Home___Car_Day;
            picDay.Location = new Point(310, 104);
            picDay.Name = "picDay";
            picDay.Size = new Size(150, 150);
            picDay.SizeMode = PictureBoxSizeMode.StretchImage;
            picDay.TabIndex = 8;
            picDay.TabStop = false;
            // 
            // picNight
            // 
            picNight.Anchor = AnchorStyles.None;
            picNight.Image = Properties.Resources.Home___Car_Night;
            picNight.Location = new Point(482, 104);
            picNight.Name = "picNight";
            picNight.Size = new Size(150, 150);
            picNight.SizeMode = PictureBoxSizeMode.StretchImage;
            picNight.TabIndex = 9;
            picNight.TabStop = false;
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.AutoScroll = true;
            pnlSideMenu.BackColor = Color.FromArgb(45, 60, 75);
            pnlSideMenu.Controls.Add(btnExit);
            pnlSideMenu.Controls.Add(btnLogout);
            pnlSideMenu.Controls.Add(btnManageAccount);
            pnlSideMenu.Controls.Add(btnUpdateVehicles);
            pnlSideMenu.Controls.Add(btnAddVehicles);
            pnlSideMenu.Controls.Add(btnRentalDetails);
            pnlSideMenu.Controls.Add(btnAllVehicles);
            pnlSideMenu.Controls.Add(btnHome);
            pnlSideMenu.Controls.Add(pnlTitle);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.RightToLeft = RightToLeft.Yes;
            pnlSideMenu.Size = new Size(200, 784);
            pnlSideMenu.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial Rounded MT Bold", 12F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 625);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 75);
            btnExit.TabIndex = 8;
            btnExit.Text = "EXIT";
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
            btnLogout.Location = new Point(0, 550);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 75);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
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
            btnManageAccount.Location = new Point(0, 475);
            btnManageAccount.Name = "btnManageAccount";
            btnManageAccount.Size = new Size(200, 75);
            btnManageAccount.TabIndex = 7;
            btnManageAccount.Text = "Manage Account";
            btnManageAccount.UseVisualStyleBackColor = true;
            btnManageAccount.Click += btnManageAccount_Click;
            // 
            // btnUpdateVehicles
            // 
            btnUpdateVehicles.Dock = DockStyle.Top;
            btnUpdateVehicles.FlatAppearance.BorderSize = 0;
            btnUpdateVehicles.FlatStyle = FlatStyle.Flat;
            btnUpdateVehicles.Font = new Font("Arial Rounded MT Bold", 12F);
            btnUpdateVehicles.ForeColor = Color.White;
            btnUpdateVehicles.Location = new Point(0, 400);
            btnUpdateVehicles.Name = "btnUpdateVehicles";
            btnUpdateVehicles.Size = new Size(200, 75);
            btnUpdateVehicles.TabIndex = 6;
            btnUpdateVehicles.Text = "Update Vehicles";
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
            btnAddVehicles.Location = new Point(0, 325);
            btnAddVehicles.Name = "btnAddVehicles";
            btnAddVehicles.Size = new Size(200, 75);
            btnAddVehicles.TabIndex = 5;
            btnAddVehicles.Text = "Add Vehicles";
            btnAddVehicles.UseVisualStyleBackColor = true;
            btnAddVehicles.Click += btnAddVehicles_Click;
            // 
            // btnRentalDetails
            // 
            btnRentalDetails.Dock = DockStyle.Top;
            btnRentalDetails.FlatAppearance.BorderSize = 0;
            btnRentalDetails.FlatStyle = FlatStyle.Flat;
            btnRentalDetails.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRentalDetails.ForeColor = Color.White;
            btnRentalDetails.Location = new Point(0, 250);
            btnRentalDetails.Name = "btnRentalDetails";
            btnRentalDetails.Size = new Size(200, 75);
            btnRentalDetails.TabIndex = 4;
            btnRentalDetails.Text = "Rental Details";
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
            btnAllVehicles.Location = new Point(0, 175);
            btnAllVehicles.Name = "btnAllVehicles";
            btnAllVehicles.Size = new Size(200, 75);
            btnAllVehicles.TabIndex = 3;
            btnAllVehicles.Text = "All Vehicles";
            btnAllVehicles.UseVisualStyleBackColor = true;
            btnAllVehicles.Click += btnAllVehicles_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Arial Rounded MT Bold", 12F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 100);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 75);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(35, 40, 60);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(200, 100);
            pnlTitle.TabIndex = 12;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 128, 0);
            pnlTop.Controls.Add(picMin);
            pnlTop.Controls.Add(picMax);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(200, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(984, 30);
            pnlTop.TabIndex = 11;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = SystemColors.Control;
            pnlForm.BackgroundImageLayout = ImageLayout.Stretch;
            pnlForm.Controls.Add(picDay);
            pnlForm.Controls.Add(picNight);
            pnlForm.Controls.Add(lblAnalytics);
            pnlForm.Controls.Add(lblNotifications);
            pnlForm.Controls.Add(lblGreetings);
            pnlForm.Controls.Add(lblTime);
            pnlForm.Controls.Add(lblDay);
            pnlForm.Controls.Add(lblDate);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(200, 30);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(984, 754);
            pnlForm.TabIndex = 12;
            // 
            // picMax
            // 
            picMax.Anchor = AnchorStyles.Right;
            picMax.BackColor = Color.Transparent;
            picMax.BackgroundImage = Properties.Resources.Maximize;
            picMax.BackgroundImageLayout = ImageLayout.Stretch;
            picMax.Cursor = Cursors.Hand;
            picMax.Location = new Point(947, 2);
            picMax.Name = "picMax";
            picMax.Size = new Size(25, 25);
            picMax.TabIndex = 29;
            picMax.TabStop = false;
            picMax.Click += picMax_Click;
            // 
            // picMin
            // 
            picMin.Anchor = AnchorStyles.Right;
            picMin.BackColor = Color.Transparent;
            picMin.BackgroundImage = Properties.Resources.Minimize;
            picMin.BackgroundImageLayout = ImageLayout.Stretch;
            picMin.Cursor = Cursors.Hand;
            picMin.Location = new Point(907, 2);
            picMin.Name = "picMin";
            picMin.Size = new Size(25, 25);
            picMin.TabIndex = 30;
            picMin.TabStop = false;
            picMin.Click += picMin_Click;
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
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)picDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNight).EndInit();
            pnlSideMenu.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMin).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTime;
        private Label lblDate;
        private Label lblDay;
        private System.Windows.Forms.Timer tmrClock;
        private Label lblGreetings;
        private Label lblAnalytics;
        private Label lblNotifications;
        private PictureBox picDay;
        private PictureBox picNight;
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
        private Panel pnlForm;
        private PictureBox picMax;
        private PictureBox picMin;
    }
}