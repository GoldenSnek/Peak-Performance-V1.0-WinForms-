namespace Peak_Performance_V1._0
{
    partial class VehicleCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblType = new Label();
            lblMake = new Label();
            lblModel = new Label();
            lblLicense = new Label();
            lblColor = new Label();
            lblFuelType = new Label();
            lblSeats = new Label();
            lblMileage = new Label();
            lblDailyPrice = new Label();
            lblHourlyPrice = new Label();
            btnProceed = new Button();
            picVehicle = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picVehicle).BeginInit();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(36, 196);
            lblType.Name = "lblType";
            lblType.Size = new Size(37, 19);
            lblType.TabIndex = 0;
            lblType.Text = "Type";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(36, 215);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(43, 19);
            lblMake.TabIndex = 1;
            lblMake.Text = "Make";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(36, 234);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(48, 19);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model";
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Location = new Point(36, 253);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(109, 19);
            lblLicense.TabIndex = 4;
            lblLicense.Text = "License Plate No";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(36, 272);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 19);
            lblColor.TabIndex = 5;
            lblColor.Text = "Color";
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(36, 291);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(66, 19);
            lblFuelType.TabIndex = 6;
            lblFuelType.Text = "Fuel Type";
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Location = new Point(36, 310);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(41, 19);
            lblSeats.TabIndex = 7;
            lblSeats.Text = "Seats";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(36, 329);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(57, 19);
            lblMileage.TabIndex = 8;
            lblMileage.Text = "Mileage";
            // 
            // lblDailyPrice
            // 
            lblDailyPrice.AutoSize = true;
            lblDailyPrice.Location = new Point(36, 348);
            lblDailyPrice.Name = "lblDailyPrice";
            lblDailyPrice.Size = new Size(72, 19);
            lblDailyPrice.TabIndex = 9;
            lblDailyPrice.Text = "Daily Price";
            // 
            // lblHourlyPrice
            // 
            lblHourlyPrice.AutoSize = true;
            lblHourlyPrice.Location = new Point(36, 367);
            lblHourlyPrice.Name = "lblHourlyPrice";
            lblHourlyPrice.Size = new Size(83, 19);
            lblHourlyPrice.TabIndex = 10;
            lblHourlyPrice.Text = "Hourly Price";
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(83, 406);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(130, 23);
            btnProceed.TabIndex = 11;
            btnProceed.Text = "-";
            btnProceed.UseVisualStyleBackColor = true;
            // 
            // picVehicle
            // 
            picVehicle.Location = new Point(74, 24);
            picVehicle.Name = "picVehicle";
            picVehicle.Size = new Size(150, 150);
            picVehicle.SizeMode = PictureBoxSizeMode.StretchImage;
            picVehicle.TabIndex = 12;
            picVehicle.TabStop = false;
            // 
            // VehicleCard
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(picVehicle);
            Controls.Add(btnProceed);
            Controls.Add(lblHourlyPrice);
            Controls.Add(lblDailyPrice);
            Controls.Add(lblMileage);
            Controls.Add(lblSeats);
            Controls.Add(lblFuelType);
            Controls.Add(lblColor);
            Controls.Add(lblLicense);
            Controls.Add(lblModel);
            Controls.Add(lblMake);
            Controls.Add(lblType);
            Name = "VehicleCard";
            Size = new Size(300, 450);
            ((System.ComponentModel.ISupportInitialize)picVehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblType;
        private Label lblMake;
        private Label lblModel;
        private Label lblLicense;
        private Label lblColor;
        private Label lblFuelType;
        private Label lblSeats;
        private Label lblMileage;
        private Label lblDailyPrice;
        private Label lblHourlyPrice;
        private Button btnProceed;
        private PictureBox picVehicle;
    }
}
