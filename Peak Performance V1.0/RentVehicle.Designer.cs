namespace Peak_Performance_V1._0
{
    partial class RentVehicle
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrFadeIn = new System.Windows.Forms.Timer(components);
            picBack = new PictureBox();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            picProfilePicture = new PictureBox();
            panel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            picVehicleImage = new PictureBox();
            lblDailyPrice = new Label();
            lblHourlyPrice = new Label();
            pnlTop = new Panel();
            lblDay = new Label();
            picMin = new PictureBox();
            lblTime = new Label();
            lblDate = new Label();
            picMax = new PictureBox();
            txtNotes = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxRent = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxDuration = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxPaymentType = new ReaLTaiizor.Controls.MaterialComboBox();
            lblEstimatedPrice = new Label();
            cbxChildSeat = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxSound = new ReaLTaiizor.Controls.MaterialComboBox();
            label1 = new Label();
            cbxPowerbank = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxWifi = new ReaLTaiizor.Controls.MaterialComboBox();
            btnEstimate = new ReaLTaiizor.Controls.MaterialButton();
            btnFinalize = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfilePicture).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVehicleImage).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMax).BeginInit();
            SuspendLayout();
            // 
            // tmrFadeIn
            // 
            tmrFadeIn.Interval = 10;
            tmrFadeIn.Tick += tmrFadeIn_Tick;
            // 
            // picBack
            // 
            picBack.BackColor = Color.Transparent;
            picBack.BackgroundImage = Properties.Resources.Back3;
            picBack.BackgroundImageLayout = ImageLayout.Stretch;
            picBack.Cursor = Cursors.Hand;
            picBack.Location = new Point(12, 26);
            picBack.Name = "picBack";
            picBack.Size = new Size(30, 30);
            picBack.TabIndex = 30;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(255, 192, 128);
            parrotGradientPanel1.BottomRight = Color.FromArgb(192, 64, 0);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(picProfilePicture);
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(334, 26);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(54, 54);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 42;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(192, 64, 0);
            parrotGradientPanel1.TopRight = Color.FromArgb(255, 192, 128);
            // 
            // picProfilePicture
            // 
            picProfilePicture.BackColor = Color.Lavender;
            picProfilePicture.Location = new Point(2, 2);
            picProfilePicture.Name = "picProfilePicture";
            picProfilePicture.Size = new Size(50, 50);
            picProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfilePicture.TabIndex = 12;
            picProfilePicture.TabStop = false;
            // 
            // panel
            // 
            panel.BottomLeft = Color.FromArgb(255, 192, 128);
            panel.BottomRight = Color.FromArgb(192, 64, 0);
            panel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            panel.Controls.Add(picVehicleImage);
            panel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            panel.Location = new Point(117, 26);
            panel.Name = "panel";
            panel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            panel.PrimerColor = Color.White;
            panel.Size = new Size(156, 156);
            panel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            panel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            panel.TabIndex = 55;
            panel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            panel.TopLeft = Color.FromArgb(192, 64, 0);
            panel.TopRight = Color.FromArgb(255, 192, 128);
            // 
            // picVehicleImage
            // 
            picVehicleImage.BackColor = Color.Lavender;
            picVehicleImage.Location = new Point(3, 3);
            picVehicleImage.Name = "picVehicleImage";
            picVehicleImage.Size = new Size(150, 150);
            picVehicleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picVehicleImage.TabIndex = 12;
            picVehicleImage.TabStop = false;
            // 
            // lblDailyPrice
            // 
            lblDailyPrice.BackColor = Color.Transparent;
            lblDailyPrice.Font = new Font("Arial", 12F);
            lblDailyPrice.ForeColor = Color.FromArgb(192, 64, 0);
            lblDailyPrice.Location = new Point(12, 59);
            lblDailyPrice.Name = "lblDailyPrice";
            lblDailyPrice.Size = new Size(85, 50);
            lblDailyPrice.TabIndex = 56;
            lblDailyPrice.Text = "Daily Price";
            lblDailyPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHourlyPrice
            // 
            lblHourlyPrice.BackColor = Color.Transparent;
            lblHourlyPrice.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHourlyPrice.ForeColor = Color.FromArgb(255, 128, 0);
            lblHourlyPrice.Location = new Point(12, 129);
            lblHourlyPrice.Name = "lblHourlyPrice";
            lblHourlyPrice.Size = new Size(85, 50);
            lblHourlyPrice.TabIndex = 57;
            lblHourlyPrice.Text = "Hourly Price";
            lblHourlyPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 128, 0);
            pnlTop.Controls.Add(lblDay);
            pnlTop.Controls.Add(picMin);
            pnlTop.Controls.Add(lblTime);
            pnlTop.Controls.Add(lblDate);
            pnlTop.Controls.Add(picMax);
            pnlTop.Cursor = Cursors.Hand;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(400, 20);
            pnlTop.TabIndex = 59;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // lblDay
            // 
            lblDay.Anchor = AnchorStyles.Left;
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.Transparent;
            lblDay.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblDay.ForeColor = Color.Black;
            lblDay.Location = new Point(246, -36);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(87, 23);
            lblDay.TabIndex = 38;
            lblDay.Text = "Placeholder";
            lblDay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMin
            // 
            picMin.Anchor = AnchorStyles.Right;
            picMin.BackColor = Color.Transparent;
            picMin.BackgroundImage = Properties.Resources.Minimize;
            picMin.BackgroundImageLayout = ImageLayout.Stretch;
            picMin.Cursor = Cursors.Hand;
            picMin.Location = new Point(1090, -37);
            picMin.Name = "picMin";
            picMin.Size = new Size(25, 25);
            picMin.TabIndex = 40;
            picMin.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(39, -36);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(72, 23);
            lblTime.TabIndex = 36;
            lblTime.Text = "00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(118, -36);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(87, 23);
            lblDate.TabIndex = 37;
            lblDate.Text = "Placeholder";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMax
            // 
            picMax.Anchor = AnchorStyles.Right;
            picMax.BackColor = Color.Transparent;
            picMax.BackgroundImage = Properties.Resources.Maximize;
            picMax.BackgroundImageLayout = ImageLayout.Stretch;
            picMax.Cursor = Cursors.Hand;
            picMax.Location = new Point(1130, -37);
            picMax.Name = "picMax";
            picMax.Size = new Size(25, 25);
            picMax.TabIndex = 39;
            picMax.TabStop = false;
            // 
            // txtNotes
            // 
            txtNotes.AnimateReadOnly = false;
            txtNotes.AutoCompleteMode = AutoCompleteMode.None;
            txtNotes.AutoCompleteSource = AutoCompleteSource.None;
            txtNotes.BackgroundImageLayout = ImageLayout.None;
            txtNotes.CharacterCasing = CharacterCasing.Normal;
            txtNotes.Depth = 0;
            txtNotes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNotes.HideSelection = true;
            txtNotes.Hint = "Additional Notes:";
            txtNotes.LeadingIcon = null;
            txtNotes.Location = new Point(23, 510);
            txtNotes.MaxLength = 32767;
            txtNotes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNotes.Name = "txtNotes";
            txtNotes.PasswordChar = '\0';
            txtNotes.PrefixSuffixText = null;
            txtNotes.ReadOnly = false;
            txtNotes.RightToLeft = RightToLeft.No;
            txtNotes.SelectedText = "";
            txtNotes.SelectionLength = 0;
            txtNotes.SelectionStart = 0;
            txtNotes.ShortcutsEnabled = true;
            txtNotes.Size = new Size(350, 36);
            txtNotes.TabIndex = 60;
            txtNotes.TabStop = false;
            txtNotes.TextAlign = HorizontalAlignment.Left;
            txtNotes.TrailingIcon = null;
            txtNotes.UseSystemPasswordChar = false;
            txtNotes.UseTallSize = false;
            // 
            // cbxRent
            // 
            cbxRent.AutoResize = false;
            cbxRent.BackColor = Color.FromArgb(255, 255, 255);
            cbxRent.Depth = 0;
            cbxRent.DrawMode = DrawMode.OwnerDrawVariable;
            cbxRent.DropDownHeight = 174;
            cbxRent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRent.DropDownWidth = 121;
            cbxRent.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxRent.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxRent.FormattingEnabled = true;
            cbxRent.Hint = "Rent";
            cbxRent.IntegralHeight = false;
            cbxRent.ItemHeight = 43;
            cbxRent.Items.AddRange(new object[] { "Days", "Hours" });
            cbxRent.Location = new Point(23, 215);
            cbxRent.MaxDropDownItems = 4;
            cbxRent.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxRent.Name = "cbxRent";
            cbxRent.Size = new Size(160, 49);
            cbxRent.StartIndex = 0;
            cbxRent.TabIndex = 61;
            // 
            // cbxDuration
            // 
            cbxDuration.AutoResize = false;
            cbxDuration.BackColor = Color.FromArgb(255, 255, 255);
            cbxDuration.Depth = 0;
            cbxDuration.DrawMode = DrawMode.OwnerDrawVariable;
            cbxDuration.DropDownHeight = 174;
            cbxDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDuration.DropDownWidth = 121;
            cbxDuration.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDuration.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDuration.FormattingEnabled = true;
            cbxDuration.Hint = "Duration";
            cbxDuration.IntegralHeight = false;
            cbxDuration.ItemHeight = 43;
            cbxDuration.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            cbxDuration.Location = new Point(213, 215);
            cbxDuration.MaxDropDownItems = 4;
            cbxDuration.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxDuration.Name = "cbxDuration";
            cbxDuration.Size = new Size(160, 49);
            cbxDuration.StartIndex = 0;
            cbxDuration.TabIndex = 62;
            // 
            // cbxPaymentType
            // 
            cbxPaymentType.AutoResize = false;
            cbxPaymentType.BackColor = Color.FromArgb(255, 255, 255);
            cbxPaymentType.Depth = 0;
            cbxPaymentType.DrawMode = DrawMode.OwnerDrawVariable;
            cbxPaymentType.DropDownHeight = 174;
            cbxPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaymentType.DropDownWidth = 121;
            cbxPaymentType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxPaymentType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxPaymentType.FormattingEnabled = true;
            cbxPaymentType.Hint = "Payment Type";
            cbxPaymentType.IntegralHeight = false;
            cbxPaymentType.ItemHeight = 43;
            cbxPaymentType.Items.AddRange(new object[] { "Cash", "Card - Visa", "Card - Mastercard", "E-Wallet - GCash", "E-Wallet - Maya", "Bank - BDO Online Banking", "Bank - BPI Online", "Bank - Metrobank Direct", "Bank - RCBC", "Bank - UnionBank", "Bank - Other" });
            cbxPaymentType.Location = new Point(23, 284);
            cbxPaymentType.MaxDropDownItems = 4;
            cbxPaymentType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxPaymentType.Name = "cbxPaymentType";
            cbxPaymentType.Size = new Size(350, 49);
            cbxPaymentType.StartIndex = 0;
            cbxPaymentType.TabIndex = 63;
            // 
            // lblEstimatedPrice
            // 
            lblEstimatedPrice.BackColor = Color.Transparent;
            lblEstimatedPrice.Font = new Font("Arial", 12F);
            lblEstimatedPrice.ForeColor = Color.FromArgb(192, 64, 0);
            lblEstimatedPrice.Location = new Point(23, 560);
            lblEstimatedPrice.Name = "lblEstimatedPrice";
            lblEstimatedPrice.Size = new Size(127, 50);
            lblEstimatedPrice.TabIndex = 64;
            lblEstimatedPrice.Text = "Estimated Price";
            lblEstimatedPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxChildSeat
            // 
            cbxChildSeat.AutoResize = false;
            cbxChildSeat.BackColor = Color.FromArgb(255, 255, 255);
            cbxChildSeat.Depth = 0;
            cbxChildSeat.DrawMode = DrawMode.OwnerDrawVariable;
            cbxChildSeat.DropDownHeight = 174;
            cbxChildSeat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxChildSeat.DropDownWidth = 121;
            cbxChildSeat.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxChildSeat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxChildSeat.FormattingEnabled = true;
            cbxChildSeat.Hint = "Child Seat";
            cbxChildSeat.IntegralHeight = false;
            cbxChildSeat.ItemHeight = 43;
            cbxChildSeat.Items.AddRange(new object[] { "None", "Infant", "Toddler" });
            cbxChildSeat.Location = new Point(23, 369);
            cbxChildSeat.MaxDropDownItems = 4;
            cbxChildSeat.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxChildSeat.Name = "cbxChildSeat";
            cbxChildSeat.Size = new Size(160, 49);
            cbxChildSeat.StartIndex = 0;
            cbxChildSeat.TabIndex = 65;
            // 
            // cbxSound
            // 
            cbxSound.AutoResize = false;
            cbxSound.BackColor = Color.FromArgb(255, 255, 255);
            cbxSound.Depth = 0;
            cbxSound.DrawMode = DrawMode.OwnerDrawVariable;
            cbxSound.DropDownHeight = 174;
            cbxSound.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSound.DropDownWidth = 121;
            cbxSound.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxSound.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxSound.FormattingEnabled = true;
            cbxSound.Hint = "Sound System";
            cbxSound.IntegralHeight = false;
            cbxSound.ItemHeight = 43;
            cbxSound.Items.AddRange(new object[] { "Basic", "Premium" });
            cbxSound.Location = new Point(213, 369);
            cbxSound.MaxDropDownItems = 4;
            cbxSound.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxSound.Name = "cbxSound";
            cbxSound.Size = new Size(160, 49);
            cbxSound.StartIndex = 0;
            cbxSound.TabIndex = 66;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 340);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 67;
            label1.Text = "Add-ons";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxPowerbank
            // 
            cbxPowerbank.AutoResize = false;
            cbxPowerbank.BackColor = Color.FromArgb(255, 255, 255);
            cbxPowerbank.Depth = 0;
            cbxPowerbank.DrawMode = DrawMode.OwnerDrawVariable;
            cbxPowerbank.DropDownHeight = 174;
            cbxPowerbank.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPowerbank.DropDownWidth = 121;
            cbxPowerbank.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxPowerbank.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxPowerbank.FormattingEnabled = true;
            cbxPowerbank.Hint = "Powerbank";
            cbxPowerbank.IntegralHeight = false;
            cbxPowerbank.ItemHeight = 43;
            cbxPowerbank.Items.AddRange(new object[] { "None", "3,000 maH", "5,000 maH", "10,000 maH" });
            cbxPowerbank.Location = new Point(23, 438);
            cbxPowerbank.MaxDropDownItems = 4;
            cbxPowerbank.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxPowerbank.Name = "cbxPowerbank";
            cbxPowerbank.Size = new Size(160, 49);
            cbxPowerbank.StartIndex = 0;
            cbxPowerbank.TabIndex = 68;
            // 
            // cbxWifi
            // 
            cbxWifi.AutoResize = false;
            cbxWifi.BackColor = Color.FromArgb(255, 255, 255);
            cbxWifi.Depth = 0;
            cbxWifi.DrawMode = DrawMode.OwnerDrawVariable;
            cbxWifi.DropDownHeight = 174;
            cbxWifi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxWifi.DropDownWidth = 121;
            cbxWifi.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxWifi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxWifi.FormattingEnabled = true;
            cbxWifi.Hint = "WiFi";
            cbxWifi.IntegralHeight = false;
            cbxWifi.ItemHeight = 43;
            cbxWifi.Items.AddRange(new object[] { "None", "Pocket WiFi" });
            cbxWifi.Location = new Point(213, 438);
            cbxWifi.MaxDropDownItems = 4;
            cbxWifi.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxWifi.Name = "cbxWifi";
            cbxWifi.Size = new Size(160, 49);
            cbxWifi.StartIndex = 0;
            cbxWifi.TabIndex = 69;
            // 
            // btnEstimate
            // 
            btnEstimate.AutoSize = false;
            btnEstimate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEstimate.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEstimate.Depth = 0;
            btnEstimate.HighEmphasis = true;
            btnEstimate.Icon = null;
            btnEstimate.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEstimate.Location = new Point(233, 567);
            btnEstimate.Margin = new Padding(4, 6, 4, 6);
            btnEstimate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEstimate.Name = "btnEstimate";
            btnEstimate.NoAccentTextColor = Color.Empty;
            btnEstimate.Size = new Size(140, 36);
            btnEstimate.TabIndex = 70;
            btnEstimate.Text = "Estimate Price";
            btnEstimate.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEstimate.UseAccentColor = false;
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // btnFinalize
            // 
            btnFinalize.AutoSize = false;
            btnFinalize.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFinalize.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFinalize.Depth = 0;
            btnFinalize.HighEmphasis = true;
            btnFinalize.Icon = null;
            btnFinalize.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnFinalize.Location = new Point(117, 635);
            btnFinalize.Margin = new Padding(4, 6, 4, 6);
            btnFinalize.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnFinalize.Name = "btnFinalize";
            btnFinalize.NoAccentTextColor = Color.Empty;
            btnFinalize.Size = new Size(167, 36);
            btnFinalize.TabIndex = 71;
            btnFinalize.Text = "Finalize";
            btnFinalize.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFinalize.UseAccentColor = false;
            btnFinalize.UseVisualStyleBackColor = true;
            btnFinalize.Click += btnFinalize_Click;
            // 
            // RentVehicle
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.RentVehicle;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 700);
            Controls.Add(btnFinalize);
            Controls.Add(btnEstimate);
            Controls.Add(cbxWifi);
            Controls.Add(cbxPowerbank);
            Controls.Add(label1);
            Controls.Add(cbxSound);
            Controls.Add(cbxChildSeat);
            Controls.Add(lblEstimatedPrice);
            Controls.Add(cbxPaymentType);
            Controls.Add(cbxDuration);
            Controls.Add(cbxRent);
            Controls.Add(txtNotes);
            Controls.Add(pnlTop);
            Controls.Add(lblDailyPrice);
            Controls.Add(lblHourlyPrice);
            Controls.Add(panel);
            Controls.Add(parrotGradientPanel1);
            Controls.Add(picBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RentVehicle";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProfilePicture).EndInit();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picVehicleImage).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMax).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer tmrFadeIn;
        private PictureBox picBack;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private PictureBox picProfilePicture;
        private Label label2;
        private ReaLTaiizor.Controls.ParrotGradientPanel panel;
        private PictureBox picVehicleImage;
        private Label lblDailyPrice;
        private Label lblHourlyPrice;
        private Label label5;
        private Panel pnlTop;
        private Label lblDay;
        private PictureBox picMin;
        private Label lblTime;
        private Label lblDate;
        private PictureBox picMax;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNotes;
        private ReaLTaiizor.Controls.MaterialComboBox cbxRent;
        private ReaLTaiizor.Controls.MaterialComboBox cbxDuration;
        private ReaLTaiizor.Controls.MaterialComboBox cbxPaymentType;
        private Label lblEstimatedPrice;
        private ReaLTaiizor.Controls.MaterialComboBox cbxChildSeat;
        private ReaLTaiizor.Controls.MaterialComboBox cbxSound;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialComboBox cbxPowerbank;
        private ReaLTaiizor.Controls.MaterialComboBox cbxWifi;
        private ReaLTaiizor.Controls.MaterialButton btnEstimate;
        private ReaLTaiizor.Controls.MaterialButton btnFinalize;
    }
}