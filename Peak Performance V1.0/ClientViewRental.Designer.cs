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
            picCurrentlyRenting = new PictureBox();
            lblOwnerDetails = new Label();
            lblRentalDetails = new Label();
            lblCurrent = new Label();
            label1 = new Label();
            btnReceipt = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)picCurrentlyRenting).BeginInit();
            SuspendLayout();
            // 
            // lblVehicleDetails
            // 
            lblVehicleDetails.AutoSize = true;
            lblVehicleDetails.Font = new Font("Arial Rounded MT Bold", 12F);
            lblVehicleDetails.ForeColor = SystemColors.Control;
            lblVehicleDetails.Location = new Point(84, 325);
            lblVehicleDetails.Name = "lblVehicleDetails";
            lblVehicleDetails.Size = new Size(126, 18);
            lblVehicleDetails.TabIndex = 3;
            lblVehicleDetails.Text = "Vehicle Details";
            // 
            // picCurrentlyRenting
            // 
            picCurrentlyRenting.Location = new Point(386, 125);
            picCurrentlyRenting.Name = "picCurrentlyRenting";
            picCurrentlyRenting.Size = new Size(150, 150);
            picCurrentlyRenting.TabIndex = 5;
            picCurrentlyRenting.TabStop = false;
            // 
            // lblOwnerDetails
            // 
            lblOwnerDetails.AutoSize = true;
            lblOwnerDetails.Font = new Font("Arial Rounded MT Bold", 12F);
            lblOwnerDetails.ForeColor = SystemColors.Control;
            lblOwnerDetails.Location = new Point(370, 325);
            lblOwnerDetails.Name = "lblOwnerDetails";
            lblOwnerDetails.Size = new Size(183, 18);
            lblOwnerDetails.TabIndex = 6;
            lblOwnerDetails.Text = "Vehicle Owner Details";
            // 
            // lblRentalDetails
            // 
            lblRentalDetails.AutoSize = true;
            lblRentalDetails.Font = new Font("Arial Rounded MT Bold", 12F);
            lblRentalDetails.ForeColor = SystemColors.Control;
            lblRentalDetails.Location = new Point(696, 325);
            lblRentalDetails.Name = "lblRentalDetails";
            lblRentalDetails.Size = new Size(182, 18);
            lblRentalDetails.TabIndex = 7;
            lblRentalDetails.Text = "Vehicle Rental Details";
            // 
            // lblCurrent
            // 
            lblCurrent.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrent.ForeColor = Color.White;
            lblCurrent.Location = new Point(302, 9);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(314, 30);
            lblCurrent.TabIndex = 8;
            lblCurrent.Text = "Currently renting";
            lblCurrent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(302, 54);
            label1.Name = "label1";
            label1.Size = new Size(314, 30);
            label1.TabIndex = 9;
            label1.Text = "<vehicle name>";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReceipt
            // 
            btnReceipt.Anchor = AnchorStyles.None;
            btnReceipt.AutoSize = false;
            btnReceipt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReceipt.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReceipt.Depth = 0;
            btnReceipt.HighEmphasis = true;
            btnReceipt.Icon = null;
            btnReceipt.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnReceipt.Location = new Point(400, 683);
            btnReceipt.Margin = new Padding(4, 6, 4, 6);
            btnReceipt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnReceipt.Name = "btnReceipt";
            btnReceipt.NoAccentTextColor = Color.Empty;
            btnReceipt.Size = new Size(119, 36);
            btnReceipt.TabIndex = 10;
            btnReceipt.Text = "View Receipt";
            btnReceipt.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReceipt.UseAccentColor = false;
            btnReceipt.UseVisualStyleBackColor = true;
            // 
            // ClientViewRental
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(964, 754);
            Controls.Add(btnReceipt);
            Controls.Add(label1);
            Controls.Add(lblCurrent);
            Controls.Add(lblRentalDetails);
            Controls.Add(lblOwnerDetails);
            Controls.Add(picCurrentlyRenting);
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
        private PictureBox picCurrentlyRenting;
        private Label lblOwnerDetails;
        private Label lblRentalDetails;
        private Label lblCurrent;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialButton btnReceipt;
    }
}