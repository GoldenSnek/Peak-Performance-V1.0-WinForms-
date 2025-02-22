namespace Peak_Performance_V1._0
{
    partial class ClientMain
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
            ClientMenu = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            rentalVehiclesToolStripMenuItem = new ToolStripMenuItem();
            viewAllVehiclesToolStripMenuItem = new ToolStripMenuItem();
            viewRentalDetailsToolStripMenuItem = new ToolStripMenuItem();
            manageUserDetailsToolStripMenuItem = new ToolStripMenuItem();
            viewDetailsToolStripMenuItem = new ToolStripMenuItem();
            updateManageDetailsToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem = new ToolStripMenuItem();
            ClientMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ClientMenu
            // 
            ClientMenu.Dock = DockStyle.Left;
            ClientMenu.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, rentalVehiclesToolStripMenuItem, viewAllVehiclesToolStripMenuItem, viewRentalDetailsToolStripMenuItem, manageUserDetailsToolStripMenuItem, viewDetailsToolStripMenuItem, updateManageDetailsToolStripMenuItem, lOGOUTToolStripMenuItem, eXITToolStripMenuItem });
            ClientMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            ClientMenu.Location = new Point(0, 0);
            ClientMenu.Name = "ClientMenu";
            ClientMenu.Size = new Size(172, 761);
            ClientMenu.TabIndex = 2;
            ClientMenu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(159, 23);
            homeToolStripMenuItem.Text = "Home";
            // 
            // rentalVehiclesToolStripMenuItem
            // 
            rentalVehiclesToolStripMenuItem.Enabled = false;
            rentalVehiclesToolStripMenuItem.Name = "rentalVehiclesToolStripMenuItem";
            rentalVehiclesToolStripMenuItem.Size = new Size(159, 23);
            rentalVehiclesToolStripMenuItem.Text = "Rental Vehicles:";
            // 
            // viewAllVehiclesToolStripMenuItem
            // 
            viewAllVehiclesToolStripMenuItem.Name = "viewAllVehiclesToolStripMenuItem";
            viewAllVehiclesToolStripMenuItem.Size = new Size(159, 23);
            viewAllVehiclesToolStripMenuItem.Text = "View All Vehicles";
            // 
            // viewRentalDetailsToolStripMenuItem
            // 
            viewRentalDetailsToolStripMenuItem.Name = "viewRentalDetailsToolStripMenuItem";
            viewRentalDetailsToolStripMenuItem.Size = new Size(159, 23);
            viewRentalDetailsToolStripMenuItem.Text = "View Rental Details";
            // 
            // manageUserDetailsToolStripMenuItem
            // 
            manageUserDetailsToolStripMenuItem.Enabled = false;
            manageUserDetailsToolStripMenuItem.Name = "manageUserDetailsToolStripMenuItem";
            manageUserDetailsToolStripMenuItem.Size = new Size(159, 23);
            manageUserDetailsToolStripMenuItem.Text = "Manage Account";
            // 
            // viewDetailsToolStripMenuItem
            // 
            viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            viewDetailsToolStripMenuItem.Size = new Size(159, 23);
            viewDetailsToolStripMenuItem.Text = "View Details";
            // 
            // updateManageDetailsToolStripMenuItem
            // 
            updateManageDetailsToolStripMenuItem.Name = "updateManageDetailsToolStripMenuItem";
            updateManageDetailsToolStripMenuItem.Size = new Size(159, 23);
            updateManageDetailsToolStripMenuItem.Text = "Update/Manage Details";
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(159, 23);
            lOGOUTToolStripMenuItem.Text = "LOGOUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem
            // 
            eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            eXITToolStripMenuItem.Size = new Size(159, 23);
            eXITToolStripMenuItem.Text = "EXIT";
            eXITToolStripMenuItem.Click += eXITToolStripMenuItem_Click;
            // 
            // ClientMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 761);
            Controls.Add(ClientMenu);
            Name = "ClientMain";
            Text = "ClientMenu";
            ClientMenu.ResumeLayout(false);
            ClientMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ClientMenu;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem rentalVehiclesToolStripMenuItem;
        private ToolStripMenuItem viewAllVehiclesToolStripMenuItem;
        private ToolStripMenuItem viewRentalDetailsToolStripMenuItem;
        private ToolStripMenuItem manageUserDetailsToolStripMenuItem;
        private ToolStripMenuItem viewDetailsToolStripMenuItem;
        private ToolStripMenuItem updateManageDetailsToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}