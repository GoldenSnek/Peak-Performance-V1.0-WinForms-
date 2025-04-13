﻿namespace Peak_Performance_V1._0
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
            btnDelete = new Button();
            btnClear = new Button();
            btnClearPicture = new Button();
            btnUpdate = new Button();
            brnBrowse = new Button();
            panel15 = new Panel();
            cbxDrivetrain = new ReaLTaiizor.Controls.MaterialComboBox();
            panel16 = new Panel();
            cbxTransmission = new ReaLTaiizor.Controls.MaterialComboBox();
            panel6 = new Panel();
            txtMake = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            picPreview = new PictureBox();
            lblImagePath = new Label();
            panel14 = new Panel();
            lblOwned = new Label();
            panel1.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
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
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // flpDisplay
            // 
            flpDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpDisplay.AutoScroll = true;
            flpDisplay.BackgroundImage = Properties.Resources.CarbonFiber2;
            flpDisplay.Location = new Point(604, 50);
            flpDisplay.Name = "flpDisplay";
            flpDisplay.Size = new Size(360, 654);
            flpDisplay.TabIndex = 58;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 60);
            panel1.BackgroundImage = Properties.Resources.AddUpdate;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnClearPicture);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(brnBrowse);
            panel1.Controls.Add(panel15);
            panel1.Controls.Add(panel16);
            panel1.Controls.Add(panel6);
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
            panel1.Controls.Add(parrotGradientPanel1);
            panel1.Controls.Add(lblImagePath);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 654);
            panel1.TabIndex = 59;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Maroon;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Lavender;
            btnDelete.Location = new Point(389, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 35);
            btnDelete.TabIndex = 79;
            btnDelete.Text = "Delete Vehicle";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.Cyan;
            btnClear.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold);
            btnClear.ForeColor = Color.Lavender;
            btnClear.Location = new Point(207, 130);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 35);
            btnClear.TabIndex = 78;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearPicture
            // 
            btnClearPicture.BackColor = Color.Transparent;
            btnClearPicture.Cursor = Cursors.Hand;
            btnClearPicture.FlatAppearance.BorderColor = Color.Cyan;
            btnClearPicture.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btnClearPicture.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnClearPicture.FlatStyle = FlatStyle.Flat;
            btnClearPicture.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold);
            btnClearPicture.ForeColor = Color.Lavender;
            btnClearPicture.Location = new Point(207, 72);
            btnClearPicture.Name = "btnClearPicture";
            btnClearPicture.Size = new Size(130, 35);
            btnClearPicture.TabIndex = 77;
            btnClearPicture.Text = "Clear Picture";
            btnClearPicture.UseVisualStyleBackColor = false;
            btnClearPicture.Click += btnClearPicture_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.Green;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Green;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Green;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Lavender;
            btnUpdate.Location = new Point(389, 45);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 35);
            btnUpdate.TabIndex = 76;
            btnUpdate.Text = "Update Details";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // brnBrowse
            // 
            brnBrowse.BackColor = Color.Transparent;
            brnBrowse.Cursor = Cursors.Hand;
            brnBrowse.FlatAppearance.BorderColor = Color.Cyan;
            brnBrowse.FlatAppearance.MouseDownBackColor = Color.Cyan;
            brnBrowse.FlatAppearance.MouseOverBackColor = Color.Cyan;
            brnBrowse.FlatStyle = FlatStyle.Flat;
            brnBrowse.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold);
            brnBrowse.ForeColor = Color.Lavender;
            brnBrowse.Location = new Point(207, 11);
            brnBrowse.Name = "brnBrowse";
            brnBrowse.Size = new Size(130, 35);
            brnBrowse.TabIndex = 75;
            brnBrowse.Text = "Browse Device";
            brnBrowse.UseVisualStyleBackColor = false;
            brnBrowse.Click += btnBrowse_Click;
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.None;
            panel15.BackColor = Color.Lavender;
            panel15.Controls.Add(cbxDrivetrain);
            panel15.Location = new Point(359, 403);
            panel15.Name = "panel15";
            panel15.Size = new Size(200, 49);
            panel15.TabIndex = 74;
            // 
            // cbxDrivetrain
            // 
            cbxDrivetrain.AutoResize = false;
            cbxDrivetrain.BackColor = Color.FromArgb(255, 255, 255);
            cbxDrivetrain.Cursor = Cursors.Hand;
            cbxDrivetrain.Depth = 0;
            cbxDrivetrain.Dock = DockStyle.Fill;
            cbxDrivetrain.DrawMode = DrawMode.OwnerDrawVariable;
            cbxDrivetrain.DropDownHeight = 174;
            cbxDrivetrain.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDrivetrain.DropDownWidth = 121;
            cbxDrivetrain.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDrivetrain.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDrivetrain.FormattingEnabled = true;
            cbxDrivetrain.Hint = "Drivetrain";
            cbxDrivetrain.IntegralHeight = false;
            cbxDrivetrain.ItemHeight = 43;
            cbxDrivetrain.Items.AddRange(new object[] { "Front-wheel drive", "Rear-wheel drive", "4-wheel drive", "All-wheel drive" });
            cbxDrivetrain.Location = new Point(0, 0);
            cbxDrivetrain.MaxDropDownItems = 4;
            cbxDrivetrain.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxDrivetrain.Name = "cbxDrivetrain";
            cbxDrivetrain.Size = new Size(200, 49);
            cbxDrivetrain.StartIndex = 0;
            cbxDrivetrain.TabIndex = 35;
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.None;
            panel16.BackColor = Color.Lavender;
            panel16.Controls.Add(cbxTransmission);
            panel16.Location = new Point(35, 403);
            panel16.Name = "panel16";
            panel16.Size = new Size(200, 49);
            panel16.TabIndex = 73;
            // 
            // cbxTransmission
            // 
            cbxTransmission.AutoResize = false;
            cbxTransmission.BackColor = Color.FromArgb(255, 255, 255);
            cbxTransmission.Cursor = Cursors.Hand;
            cbxTransmission.Depth = 0;
            cbxTransmission.Dock = DockStyle.Fill;
            cbxTransmission.DrawMode = DrawMode.OwnerDrawVariable;
            cbxTransmission.DropDownHeight = 174;
            cbxTransmission.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTransmission.DropDownWidth = 121;
            cbxTransmission.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxTransmission.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxTransmission.FormattingEnabled = true;
            cbxTransmission.Hint = "Transmission";
            cbxTransmission.IntegralHeight = false;
            cbxTransmission.ItemHeight = 43;
            cbxTransmission.Items.AddRange(new object[] { "Manual", "Automatic" });
            cbxTransmission.Location = new Point(0, 0);
            cbxTransmission.MaxDropDownItems = 4;
            cbxTransmission.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxTransmission.Name = "cbxTransmission";
            cbxTransmission.Size = new Size(200, 49);
            cbxTransmission.StartIndex = 0;
            cbxTransmission.TabIndex = 35;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.Lavender;
            panel6.Controls.Add(txtMake);
            panel6.Location = new Point(35, 476);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 36);
            panel6.TabIndex = 72;
            // 
            // txtMake
            // 
            txtMake.AnimateReadOnly = false;
            txtMake.AutoCompleteMode = AutoCompleteMode.None;
            txtMake.AutoCompleteSource = AutoCompleteSource.None;
            txtMake.BackgroundImageLayout = ImageLayout.None;
            txtMake.CharacterCasing = CharacterCasing.Normal;
            txtMake.Cursor = Cursors.Hand;
            txtMake.Depth = 0;
            txtMake.Dock = DockStyle.Fill;
            txtMake.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMake.HideSelection = true;
            txtMake.Hint = "Make";
            txtMake.LeadingIcon = null;
            txtMake.LeaveOnEnterKey = true;
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
            txtMake.Size = new Size(200, 36);
            txtMake.TabIndex = 31;
            txtMake.TabStop = false;
            txtMake.TextAlign = HorizontalAlignment.Left;
            txtMake.TrailingIcon = null;
            txtMake.UseSystemPasswordChar = false;
            txtMake.UseTallSize = false;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.Lavender;
            panel10.Controls.Add(cbxSeats);
            panel10.Location = new Point(359, 332);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 49);
            panel10.TabIndex = 71;
            // 
            // cbxSeats
            // 
            cbxSeats.AutoResize = false;
            cbxSeats.BackColor = Color.FromArgb(255, 255, 255);
            cbxSeats.Cursor = Cursors.Hand;
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
            panel12.BackColor = Color.Lavender;
            panel12.Controls.Add(txtPriceHourly);
            panel12.Location = new Point(359, 598);
            panel12.Name = "panel12";
            panel12.Size = new Size(200, 36);
            panel12.TabIndex = 66;
            // 
            // txtPriceHourly
            // 
            txtPriceHourly.AnimateReadOnly = false;
            txtPriceHourly.AutoCompleteMode = AutoCompleteMode.None;
            txtPriceHourly.AutoCompleteSource = AutoCompleteSource.None;
            txtPriceHourly.BackgroundImageLayout = ImageLayout.None;
            txtPriceHourly.CharacterCasing = CharacterCasing.Normal;
            txtPriceHourly.Cursor = Cursors.Hand;
            txtPriceHourly.Depth = 0;
            txtPriceHourly.Dock = DockStyle.Fill;
            txtPriceHourly.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPriceHourly.HideSelection = true;
            txtPriceHourly.Hint = "Hourly Price (₱)";
            txtPriceHourly.LeadingIcon = null;
            txtPriceHourly.LeaveOnEnterKey = true;
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
            txtPriceHourly.Size = new Size(200, 36);
            txtPriceHourly.TabIndex = 31;
            txtPriceHourly.TabStop = false;
            txtPriceHourly.TextAlign = HorizontalAlignment.Left;
            txtPriceHourly.TrailingIcon = null;
            txtPriceHourly.UseSystemPasswordChar = false;
            txtPriceHourly.UseTallSize = false;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.None;
            panel11.BackColor = Color.Lavender;
            panel11.Controls.Add(txtMileage);
            panel11.Location = new Point(359, 476);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 36);
            panel11.TabIndex = 63;
            // 
            // txtMileage
            // 
            txtMileage.AnimateReadOnly = false;
            txtMileage.AutoCompleteMode = AutoCompleteMode.None;
            txtMileage.AutoCompleteSource = AutoCompleteSource.None;
            txtMileage.BackgroundImageLayout = ImageLayout.None;
            txtMileage.CharacterCasing = CharacterCasing.Normal;
            txtMileage.Cursor = Cursors.Hand;
            txtMileage.Depth = 0;
            txtMileage.Dock = DockStyle.Fill;
            txtMileage.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMileage.HideSelection = true;
            txtMileage.Hint = "Mileage (km)";
            txtMileage.LeadingIcon = null;
            txtMileage.LeaveOnEnterKey = true;
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
            txtMileage.Size = new Size(200, 36);
            txtMileage.TabIndex = 31;
            txtMileage.TabStop = false;
            txtMileage.TextAlign = HorizontalAlignment.Left;
            txtMileage.TrailingIcon = null;
            txtMileage.UseSystemPasswordChar = false;
            txtMileage.UseTallSize = false;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.None;
            panel13.BackColor = Color.Lavender;
            panel13.Controls.Add(txtPriceDaily);
            panel13.Location = new Point(359, 537);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 35);
            panel13.TabIndex = 65;
            // 
            // txtPriceDaily
            // 
            txtPriceDaily.AnimateReadOnly = false;
            txtPriceDaily.AutoCompleteMode = AutoCompleteMode.None;
            txtPriceDaily.AutoCompleteSource = AutoCompleteSource.None;
            txtPriceDaily.BackgroundImageLayout = ImageLayout.None;
            txtPriceDaily.CharacterCasing = CharacterCasing.Normal;
            txtPriceDaily.Cursor = Cursors.Hand;
            txtPriceDaily.Depth = 0;
            txtPriceDaily.Dock = DockStyle.Fill;
            txtPriceDaily.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPriceDaily.HideSelection = true;
            txtPriceDaily.Hint = "Daily Price (₱)";
            txtPriceDaily.LeadingIcon = null;
            txtPriceDaily.LeaveOnEnterKey = true;
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
            txtPriceDaily.Size = new Size(200, 36);
            txtPriceDaily.TabIndex = 31;
            txtPriceDaily.TabStop = false;
            txtPriceDaily.TextAlign = HorizontalAlignment.Left;
            txtPriceDaily.TrailingIcon = null;
            txtPriceDaily.UseSystemPasswordChar = false;
            txtPriceDaily.UseTallSize = false;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.Lavender;
            panel7.Controls.Add(cbxFuel);
            panel7.Location = new Point(359, 260);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 49);
            panel7.TabIndex = 70;
            // 
            // cbxFuel
            // 
            cbxFuel.AutoResize = false;
            cbxFuel.BackColor = Color.FromArgb(255, 255, 255);
            cbxFuel.Cursor = Cursors.Hand;
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
            panel8.BackColor = Color.Lavender;
            panel8.Controls.Add(cbxColor);
            panel8.Location = new Point(359, 188);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 49);
            panel8.TabIndex = 69;
            // 
            // cbxColor
            // 
            cbxColor.AutoResize = false;
            cbxColor.BackColor = Color.FromArgb(255, 255, 255);
            cbxColor.Cursor = Cursors.Hand;
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
            panel5.BackColor = Color.Lavender;
            panel5.Controls.Add(cbxSpecificType);
            panel5.Location = new Point(35, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 49);
            panel5.TabIndex = 67;
            // 
            // cbxSpecificType
            // 
            cbxSpecificType.AutoResize = false;
            cbxSpecificType.BackColor = Color.FromArgb(255, 255, 255);
            cbxSpecificType.Cursor = Cursors.Hand;
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
            panel9.BackColor = Color.Lavender;
            panel9.Controls.Add(cbxYear);
            panel9.Location = new Point(35, 332);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 49);
            panel9.TabIndex = 68;
            // 
            // cbxYear
            // 
            cbxYear.AutoResize = false;
            cbxYear.BackColor = Color.FromArgb(255, 255, 255);
            cbxYear.Cursor = Cursors.Hand;
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
            cbxYear.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909", "1908", "1907", "1906", "1905", "1904", "1903", "1902", "1901", "1900" });
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
            panel4.BackColor = Color.Lavender;
            panel4.Controls.Add(txtLicense);
            panel4.Location = new Point(35, 598);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 36);
            panel4.TabIndex = 64;
            // 
            // txtLicense
            // 
            txtLicense.AnimateReadOnly = false;
            txtLicense.AutoCompleteMode = AutoCompleteMode.None;
            txtLicense.AutoCompleteSource = AutoCompleteSource.None;
            txtLicense.BackgroundImageLayout = ImageLayout.None;
            txtLicense.CharacterCasing = CharacterCasing.Normal;
            txtLicense.Cursor = Cursors.Hand;
            txtLicense.Depth = 0;
            txtLicense.Dock = DockStyle.Fill;
            txtLicense.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLicense.HideSelection = true;
            txtLicense.Hint = "License Plate Number";
            txtLicense.LeadingIcon = null;
            txtLicense.LeaveOnEnterKey = true;
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
            txtLicense.Size = new Size(200, 36);
            txtLicense.TabIndex = 31;
            txtLicense.TabStop = false;
            txtLicense.TextAlign = HorizontalAlignment.Left;
            txtLicense.TrailingIcon = null;
            txtLicense.UseSystemPasswordChar = false;
            txtLicense.UseTallSize = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(cbxGeneralType);
            panel3.Location = new Point(35, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 49);
            panel3.TabIndex = 62;
            // 
            // cbxGeneralType
            // 
            cbxGeneralType.AutoResize = false;
            cbxGeneralType.BackColor = Color.FromArgb(255, 255, 255);
            cbxGeneralType.Cursor = Cursors.Hand;
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
            cbxGeneralType.Items.AddRange(new object[] { "Car", "Motorcycle" });
            cbxGeneralType.Location = new Point(0, 0);
            cbxGeneralType.MaxDropDownItems = 4;
            cbxGeneralType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxGeneralType.Name = "cbxGeneralType";
            cbxGeneralType.Size = new Size(200, 49);
            cbxGeneralType.StartIndex = 0;
            cbxGeneralType.TabIndex = 35;
            cbxGeneralType.SelectedIndexChanged += cbxGeneralType_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(txtModel);
            panel2.Location = new Point(35, 536);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 36);
            panel2.TabIndex = 61;
            // 
            // txtModel
            // 
            txtModel.AnimateReadOnly = false;
            txtModel.AutoCompleteMode = AutoCompleteMode.None;
            txtModel.AutoCompleteSource = AutoCompleteSource.None;
            txtModel.BackgroundImageLayout = ImageLayout.None;
            txtModel.CharacterCasing = CharacterCasing.Normal;
            txtModel.Cursor = Cursors.Hand;
            txtModel.Depth = 0;
            txtModel.Dock = DockStyle.Fill;
            txtModel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModel.HideSelection = true;
            txtModel.Hint = "Model";
            txtModel.LeadingIcon = null;
            txtModel.LeaveOnEnterKey = true;
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
            txtModel.Size = new Size(200, 36);
            txtModel.TabIndex = 31;
            txtModel.TabStop = false;
            txtModel.TextAlign = HorizontalAlignment.Left;
            txtModel.TrailingIcon = null;
            txtModel.UseSystemPasswordChar = false;
            txtModel.UseTallSize = false;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.Anchor = AnchorStyles.Top;
            parrotGradientPanel1.BottomLeft = Color.FromArgb(255, 192, 128);
            parrotGradientPanel1.BottomRight = Color.FromArgb(192, 64, 0);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(picPreview);
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(35, 9);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(156, 156);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 60;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(192, 64, 0);
            parrotGradientPanel1.TopRight = Color.FromArgb(255, 192, 128);
            // 
            // picPreview
            // 
            picPreview.Anchor = AnchorStyles.None;
            picPreview.BackColor = Color.Lavender;
            picPreview.BackgroundImageLayout = ImageLayout.None;
            picPreview.Location = new Point(3, 3);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(150, 150);
            picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picPreview.TabIndex = 21;
            picPreview.TabStop = false;
            // 
            // lblImagePath
            // 
            lblImagePath.Anchor = AnchorStyles.Top;
            lblImagePath.AutoSize = true;
            lblImagePath.Location = new Point(105, 150);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(0, 19);
            lblImagePath.TabIndex = 28;
            lblImagePath.Visible = false;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(35, 40, 60);
            panel14.Controls.Add(lblOwned);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(964, 50);
            panel14.TabIndex = 60;
            // 
            // lblOwned
            // 
            lblOwned.Anchor = AnchorStyles.Top;
            lblOwned.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOwned.ForeColor = Color.FromArgb(255, 128, 0);
            lblOwned.Location = new Point(604, 9);
            lblOwned.Name = "lblOwned";
            lblOwned.Size = new Size(361, 30);
            lblOwned.TabIndex = 5;
            lblOwned.Text = "Owned Vehicles";
            lblOwned.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProviderUpdateVehicle
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(964, 704);
            Controls.Add(panel1);
            Controls.Add(flpDisplay);
            Controls.Add(panel14);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderUpdateVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProviderEditVehicle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
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
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            panel14.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpDisplay;
        private Panel panel1;
        private Label lblImagePath;
        private PictureBox picPreview;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Panel panel14;
        private Label lblOwned;
        private Panel panel15;
        private ReaLTaiizor.Controls.MaterialComboBox cbxDrivetrain;
        private Panel panel16;
        private ReaLTaiizor.Controls.MaterialComboBox cbxTransmission;
        private Panel panel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMake;
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
        private Button btnDelete;
        private Button btnClear;
        private Button btnClearPicture;
        private Button btnUpdate;
        private Button brnBrowse;
    }
}