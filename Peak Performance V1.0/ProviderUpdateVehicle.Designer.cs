namespace Peak_Performance_V1._0
{
    partial class ProviderUpdateVehicle
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
            panel1 = new Panel();
            lblImagePath = new Label();
            lblImage = new Label();
            picPreview = new PictureBox();
            panel6 = new Panel();
            txtMake = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnAddVehicle = new ReaLTaiizor.Controls.MaterialButton();
            btnClear = new ReaLTaiizor.Controls.MaterialButton();
            panel10 = new Panel();
            cbxSeats = new ReaLTaiizor.Controls.MaterialComboBox();
            panel12 = new Panel();
            txtPriceHourly = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel11 = new Panel();
            txtMileage = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel13 = new Panel();
            txtPriceDaily = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel7 = new Panel();
            cbxFuel = new ReaLTaiizor.Controls.MaterialComboBox();
            panel8 = new Panel();
            cbxColor = new ReaLTaiizor.Controls.MaterialComboBox();
            panel5 = new Panel();
            cbxSpecificType = new ReaLTaiizor.Controls.MaterialComboBox();
            panel9 = new Panel();
            cbxYear = new ReaLTaiizor.Controls.MaterialComboBox();
            panel4 = new Panel();
            txtLicense = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel3 = new Panel();
            cbxGeneralType = new ReaLTaiizor.Controls.MaterialComboBox();
            panel2 = new Panel();
            txtModel = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnBrowse = new ReaLTaiizor.Controls.MaterialButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel13.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flpDisplay
            // 
            flpDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpDisplay.AutoScroll = true;
            flpDisplay.Location = new Point(604, 0);
            flpDisplay.Name = "flpDisplay";
            flpDisplay.Size = new Size(360, 754);
            flpDisplay.TabIndex = 58;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 60);
            panel1.Controls.Add(lblImagePath);
            panel1.Controls.Add(lblImage);
            panel1.Controls.Add(picPreview);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnAddVehicle);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnBrowse);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 754);
            panel1.TabIndex = 59;
            // 
            // lblImagePath
            // 
            lblImagePath.Anchor = AnchorStyles.None;
            lblImagePath.AutoSize = true;
            lblImagePath.Location = new Point(106, 208);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(37, 19);
            lblImagePath.TabIndex = 28;
            lblImagePath.Text = "path";
            // 
            // lblImage
            // 
            lblImage.Anchor = AnchorStyles.None;
            lblImage.AutoSize = true;
            lblImage.Font = new Font("Arial Rounded MT Bold", 12F);
            lblImage.ForeColor = Color.White;
            lblImage.Location = new Point(81, 9);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(93, 18);
            lblImage.TabIndex = 22;
            lblImage.Text = "Add Image";
            // 
            // picPreview
            // 
            picPreview.Anchor = AnchorStyles.None;
            picPreview.BackColor = Color.FromArgb(35, 40, 50);
            picPreview.BackgroundImageLayout = ImageLayout.None;
            picPreview.Location = new Point(54, 44);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(150, 150);
            picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picPreview.TabIndex = 21;
            picPreview.TabStop = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(255, 224, 192);
            panel6.Controls.Add(txtMake);
            panel6.Location = new Point(36, 423);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 63);
            panel6.TabIndex = 44;
            // 
            // txtMake
            // 
            txtMake.AnimateReadOnly = false;
            txtMake.AutoCompleteMode = AutoCompleteMode.None;
            txtMake.AutoCompleteSource = AutoCompleteSource.None;
            txtMake.BackgroundImageLayout = ImageLayout.None;
            txtMake.CharacterCasing = CharacterCasing.Normal;
            txtMake.Depth = 0;
            txtMake.Dock = DockStyle.Fill;
            txtMake.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMake.HideSelection = true;
            txtMake.Hint = "Make";
            txtMake.LeadingIcon = null;
            txtMake.Location = new Point(0, 0);
            txtMake.MaxLength = 32767;
            txtMake.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMake.Name = "txtMake";
            txtMake.PasswordChar = '\0';
            txtMake.PrefixSuffixText = null;
            txtMake.ReadOnly = false;
            txtMake.RightToLeft = RightToLeft.No;
            txtMake.SelectedText = "";
            txtMake.SelectionLength = 0;
            txtMake.SelectionStart = 0;
            txtMake.ShortcutsEnabled = true;
            txtMake.Size = new Size(200, 48);
            txtMake.TabIndex = 31;
            txtMake.TabStop = false;
            txtMake.TextAlign = HorizontalAlignment.Left;
            txtMake.TrailingIcon = null;
            txtMake.UseSystemPasswordChar = false;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Anchor = AnchorStyles.None;
            btnAddVehicle.AutoSize = false;
            btnAddVehicle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddVehicle.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddVehicle.Depth = 0;
            btnAddVehicle.HighEmphasis = true;
            btnAddVehicle.Icon = null;
            btnAddVehicle.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAddVehicle.Location = new Point(400, 136);
            btnAddVehicle.Margin = new Padding(4, 6, 4, 6);
            btnAddVehicle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.NoAccentTextColor = Color.Empty;
            btnAddVehicle.Size = new Size(119, 36);
            btnAddVehicle.TabIndex = 43;
            btnAddVehicle.Text = "Add Vehicle";
            btnAddVehicle.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddVehicle.UseAccentColor = false;
            btnAddVehicle.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.AutoSize = false;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnClear.Location = new Point(400, 65);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(119, 36);
            btnClear.TabIndex = 42;
            btnClear.Text = "Clear All";
            btnClear.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.FromArgb(255, 224, 192);
            panel10.Controls.Add(cbxSeats);
            panel10.Location = new Point(360, 423);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 63);
            panel10.TabIndex = 41;
            // 
            // cbxSeats
            // 
            cbxSeats.AutoResize = false;
            cbxSeats.BackColor = Color.FromArgb(255, 255, 255);
            cbxSeats.Depth = 0;
            cbxSeats.Dock = DockStyle.Fill;
            cbxSeats.DrawMode = DrawMode.OwnerDrawVariable;
            cbxSeats.DropDownHeight = 174;
            cbxSeats.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSeats.DropDownWidth = 121;
            cbxSeats.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxSeats.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxSeats.FormattingEnabled = true;
            cbxSeats.Hint = "Seats";
            cbxSeats.IntegralHeight = false;
            cbxSeats.ItemHeight = 43;
            cbxSeats.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbxSeats.Location = new Point(0, 0);
            cbxSeats.MaxDropDownItems = 4;
            cbxSeats.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxSeats.Name = "cbxSeats";
            cbxSeats.Size = new Size(200, 49);
            cbxSeats.StartIndex = 0;
            cbxSeats.TabIndex = 35;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.None;
            panel12.BackColor = Color.FromArgb(255, 224, 192);
            panel12.Controls.Add(txtPriceHourly);
            panel12.Location = new Point(360, 669);
            panel12.Name = "panel12";
            panel12.Size = new Size(200, 63);
            panel12.TabIndex = 36;
            // 
            // txtPriceHourly
            // 
            txtPriceHourly.AnimateReadOnly = false;
            txtPriceHourly.AutoCompleteMode = AutoCompleteMode.None;
            txtPriceHourly.AutoCompleteSource = AutoCompleteSource.None;
            txtPriceHourly.BackgroundImageLayout = ImageLayout.None;
            txtPriceHourly.CharacterCasing = CharacterCasing.Normal;
            txtPriceHourly.Depth = 0;
            txtPriceHourly.Dock = DockStyle.Fill;
            txtPriceHourly.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPriceHourly.HideSelection = true;
            txtPriceHourly.Hint = "Price (Hourly)";
            txtPriceHourly.LeadingIcon = null;
            txtPriceHourly.Location = new Point(0, 0);
            txtPriceHourly.MaxLength = 32767;
            txtPriceHourly.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPriceHourly.Name = "txtPriceHourly";
            txtPriceHourly.PasswordChar = '\0';
            txtPriceHourly.PrefixSuffixText = null;
            txtPriceHourly.ReadOnly = false;
            txtPriceHourly.RightToLeft = RightToLeft.No;
            txtPriceHourly.SelectedText = "";
            txtPriceHourly.SelectionLength = 0;
            txtPriceHourly.SelectionStart = 0;
            txtPriceHourly.ShortcutsEnabled = true;
            txtPriceHourly.Size = new Size(200, 48);
            txtPriceHourly.TabIndex = 31;
            txtPriceHourly.TabStop = false;
            txtPriceHourly.TextAlign = HorizontalAlignment.Left;
            txtPriceHourly.TrailingIcon = null;
            txtPriceHourly.UseSystemPasswordChar = false;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.None;
            panel11.BackColor = Color.FromArgb(255, 224, 192);
            panel11.Controls.Add(txtMileage);
            panel11.Location = new Point(360, 505);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 63);
            panel11.TabIndex = 34;
            // 
            // txtMileage
            // 
            txtMileage.AnimateReadOnly = false;
            txtMileage.AutoCompleteMode = AutoCompleteMode.None;
            txtMileage.AutoCompleteSource = AutoCompleteSource.None;
            txtMileage.BackgroundImageLayout = ImageLayout.None;
            txtMileage.CharacterCasing = CharacterCasing.Normal;
            txtMileage.Depth = 0;
            txtMileage.Dock = DockStyle.Fill;
            txtMileage.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMileage.HideSelection = true;
            txtMileage.Hint = "Mileage";
            txtMileage.LeadingIcon = null;
            txtMileage.Location = new Point(0, 0);
            txtMileage.MaxLength = 32767;
            txtMileage.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMileage.Name = "txtMileage";
            txtMileage.PasswordChar = '\0';
            txtMileage.PrefixSuffixText = null;
            txtMileage.ReadOnly = false;
            txtMileage.RightToLeft = RightToLeft.No;
            txtMileage.SelectedText = "";
            txtMileage.SelectionLength = 0;
            txtMileage.SelectionStart = 0;
            txtMileage.ShortcutsEnabled = true;
            txtMileage.Size = new Size(200, 48);
            txtMileage.TabIndex = 31;
            txtMileage.TabStop = false;
            txtMileage.TextAlign = HorizontalAlignment.Left;
            txtMileage.TrailingIcon = null;
            txtMileage.UseSystemPasswordChar = false;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.None;
            panel13.BackColor = Color.FromArgb(255, 224, 192);
            panel13.Controls.Add(txtPriceDaily);
            panel13.Location = new Point(360, 587);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 63);
            panel13.TabIndex = 35;
            // 
            // txtPriceDaily
            // 
            txtPriceDaily.AnimateReadOnly = false;
            txtPriceDaily.AutoCompleteMode = AutoCompleteMode.None;
            txtPriceDaily.AutoCompleteSource = AutoCompleteSource.None;
            txtPriceDaily.BackgroundImageLayout = ImageLayout.None;
            txtPriceDaily.CharacterCasing = CharacterCasing.Normal;
            txtPriceDaily.Depth = 0;
            txtPriceDaily.Dock = DockStyle.Fill;
            txtPriceDaily.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPriceDaily.HideSelection = true;
            txtPriceDaily.Hint = "Price (Daily)";
            txtPriceDaily.LeadingIcon = null;
            txtPriceDaily.Location = new Point(0, 0);
            txtPriceDaily.MaxLength = 32767;
            txtPriceDaily.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPriceDaily.Name = "txtPriceDaily";
            txtPriceDaily.PasswordChar = '\0';
            txtPriceDaily.PrefixSuffixText = null;
            txtPriceDaily.ReadOnly = false;
            txtPriceDaily.RightToLeft = RightToLeft.No;
            txtPriceDaily.SelectedText = "";
            txtPriceDaily.SelectionLength = 0;
            txtPriceDaily.SelectionStart = 0;
            txtPriceDaily.ShortcutsEnabled = true;
            txtPriceDaily.Size = new Size(200, 48);
            txtPriceDaily.TabIndex = 31;
            txtPriceDaily.TabStop = false;
            txtPriceDaily.TextAlign = HorizontalAlignment.Left;
            txtPriceDaily.TrailingIcon = null;
            txtPriceDaily.UseSystemPasswordChar = false;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.FromArgb(255, 224, 192);
            panel7.Controls.Add(cbxFuel);
            panel7.Location = new Point(360, 341);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 63);
            panel7.TabIndex = 40;
            // 
            // cbxFuel
            // 
            cbxFuel.AutoResize = false;
            cbxFuel.BackColor = Color.FromArgb(255, 255, 255);
            cbxFuel.Depth = 0;
            cbxFuel.Dock = DockStyle.Fill;
            cbxFuel.DrawMode = DrawMode.OwnerDrawVariable;
            cbxFuel.DropDownHeight = 174;
            cbxFuel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFuel.DropDownWidth = 121;
            cbxFuel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxFuel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxFuel.FormattingEnabled = true;
            cbxFuel.Hint = "Fuel Type";
            cbxFuel.IntegralHeight = false;
            cbxFuel.ItemHeight = 43;
            cbxFuel.Items.AddRange(new object[] { "Bio-Diesel", "Compressed Natural Gas (CNG)", "Diesel", "Electric", "Ethanol (E85)", "Flex Fuel", "Gasoline (Petrol)", "Hydrogen", "Hybrid (Electric + Gasoline)", "Liquefied Natural Gas (LNG)", "Liquefied Petroleum Gas (LPG)", "Plug-in Hybrid", "Propane" });
            cbxFuel.Location = new Point(0, 0);
            cbxFuel.MaxDropDownItems = 4;
            cbxFuel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxFuel.Name = "cbxFuel";
            cbxFuel.Size = new Size(200, 49);
            cbxFuel.StartIndex = 0;
            cbxFuel.TabIndex = 35;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.FromArgb(255, 224, 192);
            panel8.Controls.Add(cbxColor);
            panel8.Location = new Point(360, 259);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 63);
            panel8.TabIndex = 39;
            // 
            // cbxColor
            // 
            cbxColor.AutoResize = false;
            cbxColor.BackColor = Color.FromArgb(255, 255, 255);
            cbxColor.Depth = 0;
            cbxColor.Dock = DockStyle.Fill;
            cbxColor.DrawMode = DrawMode.OwnerDrawVariable;
            cbxColor.DropDownHeight = 174;
            cbxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxColor.DropDownWidth = 121;
            cbxColor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxColor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxColor.FormattingEnabled = true;
            cbxColor.Hint = "Color";
            cbxColor.IntegralHeight = false;
            cbxColor.ItemHeight = 43;
            cbxColor.Items.AddRange(new object[] { "Beige", "Black", "Blue", "Bronze", "Brown", "Burgundy", "Charcoal", "Coral", "Cyan", "Gold", "Gray", "Green", "Indigo", "Ivory", "Lavender", "Lime", "Magenta", "Maroon", "Mint", "Navy", "Olive", "Orange", "Peach", "Pink", "Purple", "Red", "Silver", "Teal", "Turquoise", "Violet", "White", "Yellow" });
            cbxColor.Location = new Point(0, 0);
            cbxColor.MaxDropDownItems = 4;
            cbxColor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxColor.Name = "cbxColor";
            cbxColor.Size = new Size(200, 49);
            cbxColor.StartIndex = 0;
            cbxColor.TabIndex = 35;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(255, 224, 192);
            panel5.Controls.Add(cbxSpecificType);
            panel5.Location = new Point(36, 341);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 63);
            panel5.TabIndex = 36;
            // 
            // cbxSpecificType
            // 
            cbxSpecificType.AutoResize = false;
            cbxSpecificType.BackColor = Color.FromArgb(255, 255, 255);
            cbxSpecificType.Depth = 0;
            cbxSpecificType.Dock = DockStyle.Fill;
            cbxSpecificType.DrawMode = DrawMode.OwnerDrawVariable;
            cbxSpecificType.DropDownHeight = 174;
            cbxSpecificType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSpecificType.DropDownWidth = 121;
            cbxSpecificType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxSpecificType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxSpecificType.FormattingEnabled = true;
            cbxSpecificType.Hint = "Vehicle Type";
            cbxSpecificType.IntegralHeight = false;
            cbxSpecificType.ItemHeight = 43;
            cbxSpecificType.Items.AddRange(new object[] { "Sedan", "Suv", "Coupe", "Convertible", "Hatchback", "Minivan", "Pickup Truck", "Limousine", "Sports Car", "Luxury Car", "Underbone", "Scooter", "Naked", "Motocross", "Cafe Racer", "Chopper", "Tourer", "Sports Bike" });
            cbxSpecificType.Location = new Point(0, 0);
            cbxSpecificType.MaxDropDownItems = 4;
            cbxSpecificType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxSpecificType.Name = "cbxSpecificType";
            cbxSpecificType.Size = new Size(200, 49);
            cbxSpecificType.StartIndex = 0;
            cbxSpecificType.TabIndex = 35;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.BackColor = Color.FromArgb(255, 224, 192);
            panel9.Controls.Add(cbxYear);
            panel9.Location = new Point(36, 587);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 63);
            panel9.TabIndex = 38;
            // 
            // cbxYear
            // 
            cbxYear.AutoResize = false;
            cbxYear.BackColor = Color.FromArgb(255, 255, 255);
            cbxYear.Depth = 0;
            cbxYear.Dock = DockStyle.Fill;
            cbxYear.DrawMode = DrawMode.OwnerDrawVariable;
            cbxYear.DropDownHeight = 174;
            cbxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxYear.DropDownWidth = 121;
            cbxYear.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxYear.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxYear.FormattingEnabled = true;
            cbxYear.Hint = "Year";
            cbxYear.IntegralHeight = false;
            cbxYear.ItemHeight = 43;
            cbxYear.Items.AddRange(new object[] { "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            cbxYear.Location = new Point(0, 0);
            cbxYear.MaxDropDownItems = 4;
            cbxYear.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxYear.Name = "cbxYear";
            cbxYear.Size = new Size(200, 49);
            cbxYear.StartIndex = 0;
            cbxYear.TabIndex = 35;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(255, 224, 192);
            panel4.Controls.Add(txtLicense);
            panel4.Location = new Point(36, 669);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 63);
            panel4.TabIndex = 34;
            // 
            // txtLicense
            // 
            txtLicense.AnimateReadOnly = false;
            txtLicense.AutoCompleteMode = AutoCompleteMode.None;
            txtLicense.AutoCompleteSource = AutoCompleteSource.None;
            txtLicense.BackgroundImageLayout = ImageLayout.None;
            txtLicense.CharacterCasing = CharacterCasing.Normal;
            txtLicense.Depth = 0;
            txtLicense.Dock = DockStyle.Fill;
            txtLicense.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLicense.HideSelection = true;
            txtLicense.Hint = "License Plate Number";
            txtLicense.LeadingIcon = null;
            txtLicense.Location = new Point(0, 0);
            txtLicense.MaxLength = 32767;
            txtLicense.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLicense.Name = "txtLicense";
            txtLicense.PasswordChar = '\0';
            txtLicense.PrefixSuffixText = null;
            txtLicense.ReadOnly = false;
            txtLicense.RightToLeft = RightToLeft.No;
            txtLicense.SelectedText = "";
            txtLicense.SelectionLength = 0;
            txtLicense.SelectionStart = 0;
            txtLicense.ShortcutsEnabled = true;
            txtLicense.Size = new Size(200, 48);
            txtLicense.TabIndex = 31;
            txtLicense.TabStop = false;
            txtLicense.TextAlign = HorizontalAlignment.Left;
            txtLicense.TrailingIcon = null;
            txtLicense.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(cbxGeneralType);
            panel3.Location = new Point(36, 259);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 63);
            panel3.TabIndex = 33;
            // 
            // cbxGeneralType
            // 
            cbxGeneralType.AutoResize = false;
            cbxGeneralType.BackColor = Color.FromArgb(255, 255, 255);
            cbxGeneralType.Depth = 0;
            cbxGeneralType.Dock = DockStyle.Fill;
            cbxGeneralType.DrawMode = DrawMode.OwnerDrawVariable;
            cbxGeneralType.DropDownHeight = 174;
            cbxGeneralType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGeneralType.DropDownWidth = 121;
            cbxGeneralType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxGeneralType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxGeneralType.FormattingEnabled = true;
            cbxGeneralType.Hint = "Vehicle Type";
            cbxGeneralType.IntegralHeight = false;
            cbxGeneralType.ItemHeight = 43;
            cbxGeneralType.Items.AddRange(new object[] { "Motorcycle", "Car" });
            cbxGeneralType.Location = new Point(0, 0);
            cbxGeneralType.MaxDropDownItems = 4;
            cbxGeneralType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxGeneralType.Name = "cbxGeneralType";
            cbxGeneralType.Size = new Size(200, 49);
            cbxGeneralType.StartIndex = 0;
            cbxGeneralType.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(txtModel);
            panel2.Location = new Point(36, 505);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 63);
            panel2.TabIndex = 32;
            // 
            // txtModel
            // 
            txtModel.AnimateReadOnly = false;
            txtModel.AutoCompleteMode = AutoCompleteMode.None;
            txtModel.AutoCompleteSource = AutoCompleteSource.None;
            txtModel.BackgroundImageLayout = ImageLayout.None;
            txtModel.CharacterCasing = CharacterCasing.Normal;
            txtModel.Depth = 0;
            txtModel.Dock = DockStyle.Fill;
            txtModel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModel.HideSelection = true;
            txtModel.Hint = "Model";
            txtModel.LeadingIcon = null;
            txtModel.Location = new Point(0, 0);
            txtModel.MaxLength = 32767;
            txtModel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModel.Name = "txtModel";
            txtModel.PasswordChar = '\0';
            txtModel.PrefixSuffixText = null;
            txtModel.ReadOnly = false;
            txtModel.RightToLeft = RightToLeft.No;
            txtModel.SelectedText = "";
            txtModel.SelectionLength = 0;
            txtModel.SelectionStart = 0;
            txtModel.ShortcutsEnabled = true;
            txtModel.Size = new Size(200, 48);
            txtModel.TabIndex = 31;
            txtModel.TabStop = false;
            txtModel.TextAlign = HorizontalAlignment.Left;
            txtModel.TrailingIcon = null;
            txtModel.UseSystemPasswordChar = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.None;
            btnBrowse.AutoSize = false;
            btnBrowse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBrowse.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBrowse.Depth = 0;
            btnBrowse.HighEmphasis = true;
            btnBrowse.Icon = null;
            btnBrowse.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnBrowse.Location = new Point(215, 99);
            btnBrowse.Margin = new Padding(4, 6, 4, 6);
            btnBrowse.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnBrowse.Name = "btnBrowse";
            btnBrowse.NoAccentTextColor = Color.Empty;
            btnBrowse.Size = new Size(119, 36);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse Device";
            btnBrowse.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBrowse.UseAccentColor = false;
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // ProviderUpdateVehicle
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(964, 754);
            Controls.Add(panel1);
            Controls.Add(flpDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderUpdateVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProviderEditVehicle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpDisplay;
        private Panel panel1;
        private Label lblImagePath;
        private Label lblImage;
        private PictureBox picPreview;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMake;
        private ReaLTaiizor.Controls.MaterialButton btnAddVehicle;
        private ReaLTaiizor.Controls.MaterialButton btnClear;
        private Panel panel10;
        private ReaLTaiizor.Controls.MaterialComboBox cbxSeats;
        private Panel panel12;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPriceHourly;
        private Panel panel11;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMileage;
        private Panel panel13;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPriceDaily;
        private Panel panel7;
        private ReaLTaiizor.Controls.MaterialComboBox cbxFuel;
        private Panel panel8;
        private ReaLTaiizor.Controls.MaterialComboBox cbxColor;
        private Panel panel5;
        private ReaLTaiizor.Controls.MaterialComboBox cbxSpecificType;
        private Panel panel9;
        private ReaLTaiizor.Controls.MaterialComboBox cbxYear;
        private Panel panel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLicense;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialComboBox cbxGeneralType;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModel;
        private ReaLTaiizor.Controls.MaterialButton btnBrowse;
    }
}