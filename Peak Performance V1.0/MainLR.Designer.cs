namespace Peak_Performance_V1._0
{
    partial class MainLR
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLR));
            lblGoToR = new Label();
            lblGoToL = new Label();
            picClose = new PictureBox();
            btnAbout = new ReaLTaiizor.Controls.CyberButton();
            Gauge = new ReaLTaiizor.Controls.ParrotGauge();
            pictureBox1 = new PictureBox();
            picCar = new PictureBox();
            picVan = new PictureBox();
            picMotor = new PictureBox();
            picF1 = new PictureBox();
            tmrGauge = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tmrFadeIn = new System.Windows.Forms.Timer(components);
            lblMainTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMotor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picF1).BeginInit();
            SuspendLayout();
            // 
            // lblGoToR
            // 
            lblGoToR.AutoSize = true;
            lblGoToR.BackColor = Color.Transparent;
            lblGoToR.Cursor = Cursors.Hand;
            lblGoToR.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoToR.ForeColor = Color.FromArgb(255, 128, 0);
            lblGoToR.Location = new Point(118, 469);
            lblGoToR.Name = "lblGoToR";
            lblGoToR.Size = new Size(96, 28);
            lblGoToR.TabIndex = 5;
            lblGoToR.Text = "REGISTER";
            lblGoToR.TextAlign = ContentAlignment.MiddleCenter;
            lblGoToR.Click += lblGoToR_Click;
            // 
            // lblGoToL
            // 
            lblGoToL.AutoSize = true;
            lblGoToL.BackColor = Color.Transparent;
            lblGoToL.Cursor = Cursors.Hand;
            lblGoToL.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoToL.ForeColor = Color.FromArgb(255, 128, 0);
            lblGoToL.Location = new Point(408, 469);
            lblGoToL.Name = "lblGoToL";
            lblGoToL.Size = new Size(65, 28);
            lblGoToL.TabIndex = 31;
            lblGoToL.Text = "LOGIN";
            lblGoToL.TextAlign = ContentAlignment.MiddleCenter;
            lblGoToL.Click += lblGoToL_Click;
            // 
            // picClose
            // 
            picClose.BackColor = Color.Transparent;
            picClose.BackgroundImage = Properties.Resources.Close2;
            picClose.BackgroundImageLayout = ImageLayout.Stretch;
            picClose.Cursor = Cursors.Hand;
            picClose.Location = new Point(568, 12);
            picClose.Name = "picClose";
            picClose.Size = new Size(20, 20);
            picClose.TabIndex = 32;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // btnAbout
            // 
            btnAbout.Alpha = 20;
            btnAbout.BackColor = Color.Transparent;
            btnAbout.Background = true;
            btnAbout.Background_WidthPen = 1F;
            btnAbout.BackgroundPen = true;
            btnAbout.ColorBackground = Color.Transparent;
            btnAbout.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnAbout.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnAbout.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnAbout.ColorLighting = Color.FromArgb(29, 200, 238);
            btnAbout.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnAbout.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAbout.Effect_1 = true;
            btnAbout.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnAbout.Effect_1_Transparency = 25;
            btnAbout.Effect_2 = true;
            btnAbout.Effect_2_ColorBackground = Color.White;
            btnAbout.Effect_2_Transparency = 20;
            btnAbout.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbout.ForeColor = Color.White;
            btnAbout.Lighting = false;
            btnAbout.LinearGradient_Background = false;
            btnAbout.LinearGradientPen = false;
            btnAbout.Location = new Point(186, 285);
            btnAbout.Name = "btnAbout";
            btnAbout.PenWidth = 15;
            btnAbout.RGB = true;
            btnAbout.Rounding = true;
            btnAbout.RoundingInt = 70;
            btnAbout.Size = new Size(218, 33);
            btnAbout.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAbout.TabIndex = 33;
            btnAbout.Tag = "Cyber";
            btnAbout.TextButton = "--- Rent Ride Repeat ---";
            btnAbout.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAbout.Timer_Effect_1 = 5;
            btnAbout.Timer_RGB = 100;
            btnAbout.Click += btnAbout_Click;
            // 
            // Gauge
            // 
            Gauge.BackColor = Color.Transparent;
            Gauge.BarColor = (List<Color>)resources.GetObject("Gauge.BarColor");
            Gauge.ConsumptionColor = Color.Black;
            Gauge.DialColor = Color.Black;
            Gauge.DialThickness = 5;
            Gauge.FilledColor = Color.White;
            Gauge.GaugeStyle = ReaLTaiizor.Controls.ParrotGauge.Style.Standard;
            Gauge.Location = new Point(132, 98);
            Gauge.Name = "Gauge";
            Gauge.Percentage = 10;
            Gauge.Size = new Size(133, 60);
            Gauge.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Gauge.TabIndex = 34;
            Gauge.Text = "parrotGauge1";
            Gauge.Thickness = 8;
            Gauge.UnfilledColor = Color.Gray;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.SteeringWheel2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(317, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // picCar
            // 
            picCar.BackColor = Color.Transparent;
            picCar.BackgroundImage = Properties.Resources.Car___MainLR3;
            picCar.BackgroundImageLayout = ImageLayout.Stretch;
            picCar.Location = new Point(430, 336);
            picCar.Name = "picCar";
            picCar.Size = new Size(130, 130);
            picCar.TabIndex = 36;
            picCar.TabStop = false;
            picCar.Visible = false;
            // 
            // picVan
            // 
            picVan.BackColor = Color.Transparent;
            picVan.BackgroundImage = Properties.Resources.Van;
            picVan.BackgroundImageLayout = ImageLayout.Stretch;
            picVan.Location = new Point(260, 336);
            picVan.Name = "picVan";
            picVan.Size = new Size(150, 150);
            picVan.TabIndex = 37;
            picVan.TabStop = false;
            picVan.Visible = false;
            // 
            // picMotor
            // 
            picMotor.BackColor = Color.Transparent;
            picMotor.BackgroundImage = Properties.Resources.Motor;
            picMotor.BackgroundImageLayout = ImageLayout.Stretch;
            picMotor.Location = new Point(154, 357);
            picMotor.Name = "picMotor";
            picMotor.Size = new Size(100, 100);
            picMotor.TabIndex = 38;
            picMotor.TabStop = false;
            picMotor.Visible = false;
            // 
            // picF1
            // 
            picF1.BackColor = Color.Transparent;
            picF1.BackgroundImage = Properties.Resources.F1;
            picF1.BackgroundImageLayout = ImageLayout.Stretch;
            picF1.Location = new Point(23, 341);
            picF1.Name = "picF1";
            picF1.Size = new Size(125, 125);
            picF1.TabIndex = 39;
            picF1.TabStop = false;
            picF1.Visible = false;
            // 
            // tmrGauge
            // 
            tmrGauge.Enabled = true;
            tmrGauge.Interval = 1000;
            tmrGauge.Tick += tmrGauge_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(271, 147);
            label1.Name = "label1";
            label1.Size = new Size(28, 14);
            label1.TabIndex = 40;
            label1.Text = "400";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(121, 147);
            label2.Name = "label2";
            label2.Size = new Size(14, 14);
            label2.TabIndex = 41;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(129, 106);
            label3.Name = "label3";
            label3.Size = new Size(28, 14);
            label3.TabIndex = 42;
            label3.Text = "100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(186, 85);
            label4.Name = "label4";
            label4.Size = new Size(28, 14);
            label4.TabIndex = 43;
            label4.Text = "200";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(247, 106);
            label5.Name = "label5";
            label5.Size = new Size(28, 14);
            label5.TabIndex = 44;
            label5.Text = "300";
            // 
            // tmrFadeIn
            // 
            tmrFadeIn.Interval = 10;
            tmrFadeIn.Tick += tmrFadeIn_Tick;
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.BackColor = Color.Transparent;
            lblMainTitle.Font = new Font("Copperplate Gothic Bold", 36F);
            lblMainTitle.Location = new Point(31, 161);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(538, 106);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "Peak Performance\r\nVehicle Rentals";
            lblMainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainLR
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.LoginRegister2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 600);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picF1);
            Controls.Add(picMotor);
            Controls.Add(picVan);
            Controls.Add(pictureBox1);
            Controls.Add(btnAbout);
            Controls.Add(picClose);
            Controls.Add(lblGoToL);
            Controls.Add(lblGoToR);
            Controls.Add(lblMainTitle);
            Controls.Add(Gauge);
            Controls.Add(picCar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainLR";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainLR_Load;
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMotor).EndInit();
            ((System.ComponentModel.ISupportInitialize)picF1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGoToR;
        private Label lblGoToL;
        private PictureBox picClose;
        private ReaLTaiizor.Controls.CyberButton btnAbout;
        private ReaLTaiizor.Controls.ParrotGauge Gauge;
        private PictureBox pictureBox1;
        private PictureBox picCar;
        private PictureBox picVan;
        private PictureBox picMotor;
        private PictureBox picF1;
        private System.Windows.Forms.Timer tmrGauge;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer tmrFadeIn;
        private Label lblMainTitle;
    }
}
