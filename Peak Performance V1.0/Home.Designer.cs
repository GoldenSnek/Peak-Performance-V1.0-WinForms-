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
            tmrClock = new System.Windows.Forms.Timer(components);
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
            picNight = new PictureBox();
            picDay = new PictureBox();
            pnlForm = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDay).BeginInit();
            pnlForm.SuspendLayout();
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
            btnExit.Location = new Point(0, 625);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.RightToLeft = RightToLeft.No;
            btnExit.Size = new Size(220, 75);
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
            btnLogout.Location = new Point(0, 550);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(220, 75);
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
            btnManageAccount.Location = new Point(0, 475);
            btnManageAccount.Name = "btnManageAccount";
            btnManageAccount.Padding = new Padding(10, 0, 0, 0);
            btnManageAccount.RightToLeft = RightToLeft.No;
            btnManageAccount.Size = new Size(220, 75);
            btnManageAccount.TabIndex = 7;
            btnManageAccount.Text = "  Manage Account";
            btnManageAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnManageAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            btnUpdateVehicles.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateVehicles.Location = new Point(0, 400);
            btnUpdateVehicles.Name = "btnUpdateVehicles";
            btnUpdateVehicles.Padding = new Padding(10, 0, 0, 0);
            btnUpdateVehicles.RightToLeft = RightToLeft.No;
            btnUpdateVehicles.Size = new Size(220, 75);
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
            btnAddVehicles.Location = new Point(0, 325);
            btnAddVehicles.Name = "btnAddVehicles";
            btnAddVehicles.Padding = new Padding(10, 0, 0, 0);
            btnAddVehicles.RightToLeft = RightToLeft.No;
            btnAddVehicles.Size = new Size(220, 75);
            btnAddVehicles.TabIndex = 5;
            btnAddVehicles.Text = "  Add Vehicles";
            btnAddVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnAddVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            btnRentalDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentalDetails.Location = new Point(0, 250);
            btnRentalDetails.Name = "btnRentalDetails";
            btnRentalDetails.Padding = new Padding(10, 0, 0, 0);
            btnRentalDetails.RightToLeft = RightToLeft.No;
            btnRentalDetails.Size = new Size(220, 75);
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
            btnAllVehicles.Location = new Point(0, 175);
            btnAllVehicles.Name = "btnAllVehicles";
            btnAllVehicles.Padding = new Padding(10, 0, 0, 0);
            btnAllVehicles.RightToLeft = RightToLeft.No;
            btnAllVehicles.Size = new Size(220, 75);
            btnAllVehicles.TabIndex = 3;
            btnAllVehicles.Text = "  All Vehicles";
            btnAllVehicles.TextAlign = ContentAlignment.MiddleLeft;
            btnAllVehicles.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 100);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.RightToLeft = RightToLeft.No;
            btnHome.Size = new Size(220, 75);
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
            picHide.Anchor = AnchorStyles.Right;
            picHide.BackColor = Color.Transparent;
            picHide.BackgroundImage = Properties.Resources.HideShowMenu;
            picHide.BackgroundImageLayout = ImageLayout.Stretch;
            picHide.Cursor = Cursors.Hand;
            picHide.Location = new Point(20, 3);
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
            picShow.Location = new Point(20, 2);
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
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(450, 407);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(79, 19);
            lblDate.TabIndex = 3;
            lblDate.Text = "Placeholder";
            // 
            // lblDay
            // 
            lblDay.Anchor = AnchorStyles.None;
            lblDay.AutoSize = true;
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(450, 445);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(79, 19);
            lblDay.TabIndex = 4;
            lblDay.Text = "Placeholder";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.None;
            lblTime.AutoSize = true;
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(450, 351);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(63, 19);
            lblTime.TabIndex = 2;
            lblTime.Text = "00:00:00";
            // 
            // lblGreetings
            // 
            lblGreetings.Anchor = AnchorStyles.None;
            lblGreetings.AutoSize = true;
            lblGreetings.ForeColor = Color.White;
            lblGreetings.Location = new Point(332, 295);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(290, 19);
            lblGreetings.TabIndex = 5;
            lblGreetings.Text = "Hello {user}! what would you like to do today?";
            // 
            // lblNotifications
            // 
            lblNotifications.Anchor = AnchorStyles.None;
            lblNotifications.AutoSize = true;
            lblNotifications.ForeColor = Color.White;
            lblNotifications.Location = new Point(655, 558);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new Size(85, 19);
            lblNotifications.TabIndex = 7;
            lblNotifications.Text = "Notifications";
            // 
            // lblAnalytics
            // 
            lblAnalytics.Anchor = AnchorStyles.None;
            lblAnalytics.AutoSize = true;
            lblAnalytics.ForeColor = Color.White;
            lblAnalytics.Location = new Point(228, 558);
            lblAnalytics.Name = "lblAnalytics";
            lblAnalytics.Size = new Size(63, 19);
            lblAnalytics.TabIndex = 6;
            lblAnalytics.Text = "Analytics";
            // 
            // picNight
            // 
            picNight.Anchor = AnchorStyles.None;
            picNight.Image = Properties.Resources.Home___Car_Night;
            picNight.Location = new Point(472, 104);
            picNight.Name = "picNight";
            picNight.Size = new Size(150, 150);
            picNight.SizeMode = PictureBoxSizeMode.StretchImage;
            picNight.TabIndex = 9;
            picNight.TabStop = false;
            // 
            // picDay
            // 
            picDay.Anchor = AnchorStyles.None;
            picDay.Image = Properties.Resources.Home___Car_Day;
            picDay.Location = new Point(300, 104);
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
            pnlForm.Controls.Add(picDay);
            pnlForm.Controls.Add(picNight);
            pnlForm.Controls.Add(lblAnalytics);
            pnlForm.Controls.Add(lblNotifications);
            pnlForm.Controls.Add(lblGreetings);
            pnlForm.Controls.Add(lblTime);
            pnlForm.Controls.Add(lblDay);
            pnlForm.Controls.Add(lblDate);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(220, 30);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(964, 754);
            pnlForm.TabIndex = 12;
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
            ((System.ComponentModel.ISupportInitialize)picNight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDay).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
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
        private PictureBox picNight;
        private PictureBox picDay;
        private Panel pnlForm;
        private PictureBox picHide;
        private PictureBox picShow;
    }
}