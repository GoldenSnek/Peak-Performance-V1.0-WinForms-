namespace Peak_Performance_V1._0
{
    partial class ClientViewRental
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
            lblVehicleDetails = new Label();
            btnReceipt = new Button();
            picCurrentlyRenting = new PictureBox();
            lblOwnerDetails = new Label();
            lblRentalDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)picCurrentlyRenting).BeginInit();
            SuspendLayout();
            // 
            // lblVehicleDetails
            // 
            lblVehicleDetails.AutoSize = true;
            lblVehicleDetails.Location = new Point(70, 329);
            lblVehicleDetails.Name = "lblVehicleDetails";
            lblVehicleDetails.Size = new Size(96, 19);
            lblVehicleDetails.TabIndex = 3;
            lblVehicleDetails.Text = "Vehicle Details";
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new Point(601, 660);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(75, 23);
            btnReceipt.TabIndex = 4;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            // 
            // picCurrentlyRenting
            // 
            picCurrentlyRenting.Location = new Point(326, 93);
            picCurrentlyRenting.Name = "picCurrentlyRenting";
            picCurrentlyRenting.Size = new Size(150, 150);
            picCurrentlyRenting.TabIndex = 5;
            picCurrentlyRenting.TabStop = false;
            // 
            // lblOwnerDetails
            // 
            lblOwnerDetails.AutoSize = true;
            lblOwnerDetails.Location = new Point(335, 329);
            lblOwnerDetails.Name = "lblOwnerDetails";
            lblOwnerDetails.Size = new Size(141, 19);
            lblOwnerDetails.TabIndex = 6;
            lblOwnerDetails.Text = "Vehicle Owner Details";
            // 
            // lblRentalDetails
            // 
            lblRentalDetails.AutoSize = true;
            lblRentalDetails.Location = new Point(601, 329);
            lblRentalDetails.Name = "lblRentalDetails";
            lblRentalDetails.Size = new Size(138, 19);
            lblRentalDetails.TabIndex = 7;
            lblRentalDetails.Text = "Vehicle Rental Details";
            // 
            // ClientViewRental
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 754);
            Controls.Add(lblRentalDetails);
            Controls.Add(lblOwnerDetails);
            Controls.Add(picCurrentlyRenting);
            Controls.Add(btnReceipt);
            Controls.Add(lblVehicleDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientViewRental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientViewRental";
            ((System.ComponentModel.ISupportInitialize)picCurrentlyRenting).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpCurrentlyRenting;
        private Label lblVehicleDetails;
        private Button btnReceipt;
        private PictureBox picCurrentlyRenting;
        private Label lblOwnerDetails;
        private Label lblRentalDetails;
    }
}