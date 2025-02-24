namespace Peak_Performance_V1._0
{
    partial class MainMenu
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
            ProviderMenu = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            viewAllVehiclesToolStripMenuItem = new ToolStripMenuItem();
            viewRentalDetailsToolStripMenuItem = new ToolStripMenuItem();
            addRentableVehicleToolStripMenuItem = new ToolStripMenuItem();
            updateVehiclesToolStripMenuItem = new ToolStripMenuItem();
            manageAccountDetailsToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            lblTime = new Label();
            lblDate = new Label();
            lblDay = new Label();
            tmrClock = new System.Windows.Forms.Timer(components);
            lblGreetings = new Label();
            ProviderMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ProviderMenu
            // 
            ProviderMenu.Dock = DockStyle.Left;
            ProviderMenu.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, viewAllVehiclesToolStripMenuItem, viewRentalDetailsToolStripMenuItem, addRentableVehicleToolStripMenuItem, updateVehiclesToolStripMenuItem, manageAccountDetailsToolStripMenuItem, lOGOUTToolStripMenuItem, eXITToolStripMenuItem });
            ProviderMenu.Location = new Point(0, 0);
            ProviderMenu.Name = "ProviderMenu";
            ProviderMenu.Size = new Size(155, 761);
            ProviderMenu.TabIndex = 1;
            ProviderMenu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(142, 23);
            homeToolStripMenuItem.Text = "Home";
            // 
            // viewAllVehiclesToolStripMenuItem
            // 
            viewAllVehiclesToolStripMenuItem.Name = "viewAllVehiclesToolStripMenuItem";
            viewAllVehiclesToolStripMenuItem.Size = new Size(142, 23);
            viewAllVehiclesToolStripMenuItem.Text = "View All Vehicles";
            viewAllVehiclesToolStripMenuItem.Click += viewAllVehiclesToolStripMenuItem_Click;
            // 
            // viewRentalDetailsToolStripMenuItem
            // 
            viewRentalDetailsToolStripMenuItem.Name = "viewRentalDetailsToolStripMenuItem";
            viewRentalDetailsToolStripMenuItem.Size = new Size(142, 23);
            viewRentalDetailsToolStripMenuItem.Text = "View Rental Details";
            // 
            // addRentableVehicleToolStripMenuItem
            // 
            addRentableVehicleToolStripMenuItem.Name = "addRentableVehicleToolStripMenuItem";
            addRentableVehicleToolStripMenuItem.Size = new Size(142, 23);
            addRentableVehicleToolStripMenuItem.Text = "Add Rentable Vehicle";
            addRentableVehicleToolStripMenuItem.Click += addRentableVehicleToolStripMenuItem_Click;
            // 
            // updateVehiclesToolStripMenuItem
            // 
            updateVehiclesToolStripMenuItem.Name = "updateVehiclesToolStripMenuItem";
            updateVehiclesToolStripMenuItem.Size = new Size(142, 23);
            updateVehiclesToolStripMenuItem.Text = "Update Vehicles";
            updateVehiclesToolStripMenuItem.Click += updateVehiclesToolStripMenuItem_Click;
            // 
            // manageAccountDetailsToolStripMenuItem
            // 
            manageAccountDetailsToolStripMenuItem.Name = "manageAccountDetailsToolStripMenuItem";
            manageAccountDetailsToolStripMenuItem.Size = new Size(142, 23);
            manageAccountDetailsToolStripMenuItem.Text = "Manage Account";
            manageAccountDetailsToolStripMenuItem.Click += manageAccountDetailsToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(142, 23);
            lOGOUTToolStripMenuItem.Text = "LOGOUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(142, 23);
            eXITToolStripMenuItem.Text = "EXIT";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(587, 227);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(63, 19);
            lblTime.TabIndex = 2;
            lblTime.Text = "00:00:00";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(578, 271);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(79, 19);
            lblDate.TabIndex = 3;
            lblDate.Text = "Placeholder";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(578, 317);
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
            lblGreetings.AutoSize = true;
            lblGreetings.Location = new Point(486, 161);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(290, 19);
            lblGreetings.TabIndex = 5;
            lblGreetings.Text = "Hello {user}! what would you like to do today?";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1184, 761);
            Controls.Add(lblGreetings);
            Controls.Add(lblDay);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(ProviderMenu);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Provider";
            Load += MainMenu_Load;
            ProviderMenu.ResumeLayout(false);
            ProviderMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ProviderMenu;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem viewAllVehiclesToolStripMenuItem;
        private ToolStripMenuItem viewRentalDetailsToolStripMenuItem;
        private ToolStripMenuItem addRentableVehicleToolStripMenuItem;
        private ToolStripMenuItem updateVehiclesToolStripMenuItem;
        private ToolStripMenuItem manageAccountDetailsToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private Label lblTime;
        private Label lblDate;
        private Label lblDay;
        private System.Windows.Forms.Timer tmrClock;
        private Label lblGreetings;
    }
}