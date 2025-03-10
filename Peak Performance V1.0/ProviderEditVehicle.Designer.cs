namespace Peak_Performance_V1._0
{
    partial class ProviderEditVehicle
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
            flpDisplay = new FlowLayoutPanel();
            lblImagePath = new Label();
            btnBrowse = new Button();
            cbxSpecificType = new ComboBox();
            cbxGeneralType = new ComboBox();
            lblType = new Label();
            btnSaveVehicle = new Button();
            lblImage = new Label();
            picPreview = new PictureBox();
            txtPriceHourly = new TextBox();
            lblPriceH = new Label();
            txtPriceDaily = new TextBox();
            lblPriceD = new Label();
            txtMileage = new TextBox();
            lblMileage = new Label();
            cbxSeats = new ComboBox();
            lblSeats = new Label();
            cbxFuel = new ComboBox();
            lblFuel = new Label();
            cbxColor = new ComboBox();
            lblColor = new Label();
            txtLicense = new TextBox();
            lblLicense = new Label();
            cbxYear = new ComboBox();
            lblYear = new Label();
            txtModel = new TextBox();
            lblModel = new Label();
            cbxMake = new ComboBox();
            lblMake = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // flpDisplay
            // 
            flpDisplay.AutoScroll = true;
            flpDisplay.Location = new Point(561, 59);
            flpDisplay.Name = "flpDisplay";
            flpDisplay.Size = new Size(347, 650);
            flpDisplay.TabIndex = 58;
            // 
            // lblImagePath
            // 
            lblImagePath.AutoSize = true;
            lblImagePath.Location = new Point(317, 605);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(37, 19);
            lblImagePath.TabIndex = 57;
            lblImagePath.Text = "path";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(317, 562);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(106, 23);
            btnBrowse.TabIndex = 56;
            btnBrowse.Text = "Browse Device";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // cbxSpecificType
            // 
            cbxSpecificType.FormattingEnabled = true;
            cbxSpecificType.Items.AddRange(new object[] { "Sedan", "Suv", "Coupe", "Convertible", "Hatchback", "Minivan", "Pickup Truck", "Limousine", "Sports Car", "Luxury Car", "Underbone", "Scooter", "Naked", "Motocross", "Cafe Racer", "Chopper", "Tourer", "Sports Bike" });
            cbxSpecificType.Location = new Point(31, 81);
            cbxSpecificType.Name = "cbxSpecificType";
            cbxSpecificType.Size = new Size(150, 27);
            cbxSpecificType.TabIndex = 55;
            // 
            // cbxGeneralType
            // 
            cbxGeneralType.FormattingEnabled = true;
            cbxGeneralType.Items.AddRange(new object[] { "Motorcycle", "Car" });
            cbxGeneralType.Location = new Point(31, 48);
            cbxGeneralType.Name = "cbxGeneralType";
            cbxGeneralType.Size = new Size(150, 27);
            cbxGeneralType.TabIndex = 54;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(31, 26);
            lblType.Name = "lblType";
            lblType.Size = new Size(83, 19);
            lblType.TabIndex = 53;
            lblType.Text = "Vehicle Type";
            // 
            // btnSaveVehicle
            // 
            btnSaveVehicle.Location = new Point(317, 671);
            btnSaveVehicle.Name = "btnSaveVehicle";
            btnSaveVehicle.Size = new Size(145, 23);
            btnSaveVehicle.TabIndex = 52;
            btnSaveVehicle.Text = "Save Changes";
            btnSaveVehicle.UseVisualStyleBackColor = true;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(317, 402);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(76, 19);
            lblImage.TabIndex = 51;
            lblImage.Text = "Add Image";
            // 
            // picPreview
            // 
            picPreview.BackgroundImageLayout = ImageLayout.None;
            picPreview.Location = new Point(317, 424);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(150, 126);
            picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picPreview.TabIndex = 50;
            picPreview.TabStop = false;
            // 
            // txtPriceHourly
            // 
            txtPriceHourly.Location = new Point(317, 326);
            txtPriceHourly.Name = "txtPriceHourly";
            txtPriceHourly.Size = new Size(150, 26);
            txtPriceHourly.TabIndex = 49;
            // 
            // lblPriceH
            // 
            lblPriceH.AutoSize = true;
            lblPriceH.Location = new Point(317, 295);
            lblPriceH.Name = "lblPriceH";
            lblPriceH.Size = new Size(91, 19);
            lblPriceH.TabIndex = 48;
            lblPriceH.Text = "Price (Hourly)";
            // 
            // txtPriceDaily
            // 
            txtPriceDaily.Location = new Point(317, 244);
            txtPriceDaily.Name = "txtPriceDaily";
            txtPriceDaily.Size = new Size(150, 26);
            txtPriceDaily.TabIndex = 47;
            // 
            // lblPriceD
            // 
            lblPriceD.AutoSize = true;
            lblPriceD.Location = new Point(317, 213);
            lblPriceD.Name = "lblPriceD";
            lblPriceD.Size = new Size(80, 19);
            lblPriceD.TabIndex = 46;
            lblPriceD.Text = "Price (Daily)";
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(317, 161);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(150, 26);
            txtMileage.TabIndex = 45;
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(317, 130);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(57, 19);
            lblMileage.TabIndex = 44;
            lblMileage.Text = "Mileage";
            // 
            // cbxSeats
            // 
            cbxSeats.FormattingEnabled = true;
            cbxSeats.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10+" });
            cbxSeats.Location = new Point(317, 70);
            cbxSeats.Name = "cbxSeats";
            cbxSeats.Size = new Size(150, 27);
            cbxSeats.TabIndex = 43;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Location = new Point(317, 48);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(41, 19);
            lblSeats.TabIndex = 42;
            lblSeats.Text = "Seats";
            // 
            // cbxFuel
            // 
            cbxFuel.FormattingEnabled = true;
            cbxFuel.Items.AddRange(new object[] { "Bio-Diesel", "Compressed Natural Gas (CNG)", "Diesel", "Electric", "Ethanol (E85)", "Flex Fuel", "Gasoline (Petrol)", "Hydrogen", "Hybrid (Electric + Gasoline)", "Liquefied Natural Gas (LNG)", "Liquefied Petroleum Gas (LPG)", "Plug-in Hybrid", "Propane" });
            cbxFuel.Location = new Point(32, 597);
            cbxFuel.Name = "cbxFuel";
            cbxFuel.Size = new Size(150, 27);
            cbxFuel.TabIndex = 41;
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.Location = new Point(32, 566);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(66, 19);
            lblFuel.TabIndex = 40;
            lblFuel.Text = "Fuel Type";
            // 
            // cbxColor
            // 
            cbxColor.FormattingEnabled = true;
            cbxColor.Items.AddRange(new object[] { "Beige", "Black", "Blue", "Bronze", "Brown", "Burgundy", "Charcoal", "Coral", "Cyan", "Gold", "Gray", "Green", "Indigo", "Ivory", "Lavender", "Lime", "Magenta", "Maroon", "Mint", "Navy", "Olive", "Orange", "Peach", "Pink", "Purple", "Red", "Silver", "Teal", "Turquoise", "Violet", "White", "Yellow" });
            cbxColor.Location = new Point(31, 508);
            cbxColor.Name = "cbxColor";
            cbxColor.Size = new Size(150, 27);
            cbxColor.TabIndex = 39;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(31, 477);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 19);
            lblColor.TabIndex = 38;
            lblColor.Text = "Color";
            // 
            // txtLicense
            // 
            txtLicense.Location = new Point(31, 423);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(150, 26);
            txtLicense.TabIndex = 37;
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Location = new Point(31, 391);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(112, 19);
            lblLicense.TabIndex = 36;
            lblLicense.Text = "License Plate No.";
            // 
            // cbxYear
            // 
            cbxYear.FormattingEnabled = true;
            cbxYear.Items.AddRange(new object[] { "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            cbxYear.Location = new Point(31, 341);
            cbxYear.Name = "cbxYear";
            cbxYear.Size = new Size(150, 27);
            cbxYear.TabIndex = 35;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(31, 309);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(35, 19);
            lblYear.TabIndex = 34;
            lblYear.Text = "Year";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(31, 257);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(150, 26);
            txtModel.TabIndex = 33;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(31, 226);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(48, 19);
            lblModel.TabIndex = 32;
            lblModel.Text = "Model";
            // 
            // cbxMake
            // 
            cbxMake.FormattingEnabled = true;
            cbxMake.Items.AddRange(new object[] { "Abarth", "Acura", "Aixam", "Alfa Romeo", "Aprilia", "Aston Martin", "Audi", "Bajaj", "Bentley", "Benelli", "BMW", "Bugatti", "Buick", "BYD", "Cadillac", "Can-Am", "Caterham", "CFMoto", "Chevrolet", "Chrysler", "Citroën", "Dacia", "Daewoo", "Daihatsu", "Dodge", "Ducati", "Ferrari", "Fiat", "Ford", "Genesis", "GMC", "Harley-Davidson", "Hero", "Holden", "Honda", "Hummer", "Husqvarna", "Hyundai", "Indian Motorcycle", "Infiniti", "Isuzu", "Jaguar", "Jeep", "Kawasaki", "Kia", "Koenigsegg", "KTM", "Lamborghini", "Lancia", "Land Rover", "Lexus", "Lincoln", "Lotus", "Mahindra", "Maserati", "Maybach", "Mazda", "McLaren", "Mercedes-Benz", "Mercury", "MG", "Mini", "Mitsubishi", "Moto Guzzi", "Nissan", "Opel", "Pagani", "Peugeot", "Piaggio", "Plymouth", "Polaris", "Polestar", "Pontiac", "Porsche", "Proton", "RAM", "Renault", "Rivian", "Rolls-Royce", "Royal Enfield", "Saab", "Scania", "Seat", "Skoda", "Smart", "Subaru", "Suzuki", "Tata", "Tesla", "Toyota", "Triumph", "TVS", "Vauxhall", "Volkswagen", "Volvo", "Yamaha", "Zontes" });
            cbxMake.Location = new Point(31, 166);
            cbxMake.Name = "cbxMake";
            cbxMake.Size = new Size(150, 27);
            cbxMake.TabIndex = 31;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(31, 144);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(43, 19);
            lblMake.TabIndex = 30;
            lblMake.Text = "Make";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(80, 671);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 23);
            btnClear.TabIndex = 59;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ProviderEditVehicle
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 754);
            Controls.Add(btnClear);
            Controls.Add(flpDisplay);
            Controls.Add(lblImagePath);
            Controls.Add(btnBrowse);
            Controls.Add(cbxSpecificType);
            Controls.Add(cbxGeneralType);
            Controls.Add(lblType);
            Controls.Add(btnSaveVehicle);
            Controls.Add(lblImage);
            Controls.Add(picPreview);
            Controls.Add(txtPriceHourly);
            Controls.Add(lblPriceH);
            Controls.Add(txtPriceDaily);
            Controls.Add(lblPriceD);
            Controls.Add(txtMileage);
            Controls.Add(lblMileage);
            Controls.Add(cbxSeats);
            Controls.Add(lblSeats);
            Controls.Add(cbxFuel);
            Controls.Add(lblFuel);
            Controls.Add(cbxColor);
            Controls.Add(lblColor);
            Controls.Add(txtLicense);
            Controls.Add(lblLicense);
            Controls.Add(cbxYear);
            Controls.Add(lblYear);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(cbxMake);
            Controls.Add(lblMake);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderEditVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProviderEditVehicle";
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpDisplay;
        private Label lblImagePath;
        private Button btnBrowse;
        private ComboBox cbxSpecificType;
        private ComboBox cbxGeneralType;
        private Label lblType;
        private Button btnSaveVehicle;
        private Label lblImage;
        private PictureBox picPreview;
        private TextBox txtPriceHourly;
        private Label lblPriceH;
        private TextBox txtPriceDaily;
        private Label lblPriceD;
        private TextBox txtMileage;
        private Label lblMileage;
        private ComboBox cbxSeats;
        private Label lblSeats;
        private ComboBox cbxFuel;
        private Label lblFuel;
        private ComboBox cbxColor;
        private Label lblColor;
        private TextBox txtLicense;
        private Label lblLicense;
        private ComboBox cbxYear;
        private Label lblYear;
        private TextBox txtModel;
        private Label lblModel;
        private ComboBox cbxMake;
        private Label lblMake;
        private Button btnClear;
    }
}