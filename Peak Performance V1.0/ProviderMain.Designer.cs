namespace Peak_Performance_V1._0
{
    partial class ProviderMain
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
            ProviderMenu = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            rentalVehiclesToolStripMenuItem = new ToolStripMenuItem();
            viewAllVehiclesToolStripMenuItem = new ToolStripMenuItem();
            viewRentalDetailsToolStripMenuItem = new ToolStripMenuItem();
            manageOwnedVehiclesToolStripMenuItem = new ToolStripMenuItem();
            addRentableVehicleToolStripMenuItem = new ToolStripMenuItem();
            updateVehiclesToolStripMenuItem = new ToolStripMenuItem();
            manageUserDetailsToolStripMenuItem = new ToolStripMenuItem();
            viewDetailsToolStripMenuItem = new ToolStripMenuItem();
            updateDetailsToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            ProviderMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ProviderMenu
            // 
            ProviderMenu.Dock = DockStyle.Left;
            ProviderMenu.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, rentalVehiclesToolStripMenuItem, viewAllVehiclesToolStripMenuItem, viewRentalDetailsToolStripMenuItem, manageOwnedVehiclesToolStripMenuItem, addRentableVehicleToolStripMenuItem, updateVehiclesToolStripMenuItem, manageUserDetailsToolStripMenuItem, viewDetailsToolStripMenuItem, updateDetailsToolStripMenuItem, lOGOUTToolStripMenuItem, eXITToolStripMenuItem });
            ProviderMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            ProviderMenu.Location = new Point(0, 0);
            ProviderMenu.Name = "ProviderMenu";
            ProviderMenu.Size = new Size(180, 761);
            ProviderMenu.TabIndex = 1;
            ProviderMenu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(167, 23);
            homeToolStripMenuItem.Text = "Home";
            // 
            // rentalVehiclesToolStripMenuItem
            // 
            rentalVehiclesToolStripMenuItem.Enabled = false;
            rentalVehiclesToolStripMenuItem.Name = "rentalVehiclesToolStripMenuItem";
            rentalVehiclesToolStripMenuItem.Size = new Size(167, 23);
            rentalVehiclesToolStripMenuItem.Text = "Rental Vehicles:";
            // 
            // viewAllVehiclesToolStripMenuItem
            // 
            viewAllVehiclesToolStripMenuItem.Name = "viewAllVehiclesToolStripMenuItem";
            viewAllVehiclesToolStripMenuItem.Size = new Size(167, 23);
            viewAllVehiclesToolStripMenuItem.Text = "View All Vehicles";
            viewAllVehiclesToolStripMenuItem.Click += viewAllVehiclesToolStripMenuItem_Click;
            // 
            // viewRentalDetailsToolStripMenuItem
            // 
            viewRentalDetailsToolStripMenuItem.Name = "viewRentalDetailsToolStripMenuItem";
            viewRentalDetailsToolStripMenuItem.Size = new Size(167, 23);
            viewRentalDetailsToolStripMenuItem.Text = "View Rental Details";
            // 
            // manageOwnedVehiclesToolStripMenuItem
            // 
            manageOwnedVehiclesToolStripMenuItem.Enabled = false;
            manageOwnedVehiclesToolStripMenuItem.Name = "manageOwnedVehiclesToolStripMenuItem";
            manageOwnedVehiclesToolStripMenuItem.Size = new Size(167, 23);
            manageOwnedVehiclesToolStripMenuItem.Text = "Manage Owned Vehicles:";
            // 
            // addRentableVehicleToolStripMenuItem
            // 
            addRentableVehicleToolStripMenuItem.Name = "addRentableVehicleToolStripMenuItem";
            addRentableVehicleToolStripMenuItem.Size = new Size(167, 23);
            addRentableVehicleToolStripMenuItem.Text = "Add Rentable Vehicle";
            addRentableVehicleToolStripMenuItem.Click += addRentableVehicleToolStripMenuItem_Click;
            // 
            // updateVehiclesToolStripMenuItem
            // 
            updateVehiclesToolStripMenuItem.Name = "updateVehiclesToolStripMenuItem";
            updateVehiclesToolStripMenuItem.Size = new Size(167, 23);
            updateVehiclesToolStripMenuItem.Text = "Update Vehicles";
            // 
            // manageUserDetailsToolStripMenuItem
            // 
            manageUserDetailsToolStripMenuItem.Enabled = false;
            manageUserDetailsToolStripMenuItem.Name = "manageUserDetailsToolStripMenuItem";
            manageUserDetailsToolStripMenuItem.Size = new Size(167, 23);
            manageUserDetailsToolStripMenuItem.Text = "Manage Account";
            // 
            // viewDetailsToolStripMenuItem
            // 
            viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            viewDetailsToolStripMenuItem.Size = new Size(167, 23);
            viewDetailsToolStripMenuItem.Text = "View Details";
            // 
            // updateDetailsToolStripMenuItem
            // 
            updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            updateDetailsToolStripMenuItem.Size = new Size(167, 23);
            updateDetailsToolStripMenuItem.Text = "Update Details";
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(167, 23);
            lOGOUTToolStripMenuItem.Text = "LOGOUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(167, 23);
            eXITToolStripMenuItem.Text = "EXIT";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // ProviderMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 761);
            Controls.Add(ProviderMenu);
            Name = "ProviderMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Provider";
            ProviderMenu.ResumeLayout(false);
            ProviderMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ProviderMenu;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem rentalVehiclesToolStripMenuItem;
        private ToolStripMenuItem viewAllVehiclesToolStripMenuItem;
        private ToolStripMenuItem viewRentalDetailsToolStripMenuItem;
        private ToolStripMenuItem manageOwnedVehiclesToolStripMenuItem;
        private ToolStripMenuItem addRentableVehicleToolStripMenuItem;
        private ToolStripMenuItem updateVehiclesToolStripMenuItem;
        private ToolStripMenuItem manageUserDetailsToolStripMenuItem;
        private ToolStripMenuItem viewDetailsToolStripMenuItem;
        private ToolStripMenuItem updateDetailsToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}