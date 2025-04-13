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
            lblGoToR = new Label();
            lblGoToL = new Label();
            picClose = new PictureBox();
            pictureBox1 = new PictureBox();
            tmrFadeIn = new System.Windows.Forms.Timer(components);
            btnAbout = new ReaLTaiizor.Controls.CyberButton();
            lblMainTitle = new Label();
            picCar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            SuspendLayout();
            // 
            // lblGoToR
            // 
            lblGoToR.AutoSize = true;
            lblGoToR.BackColor = Color.Transparent;
            lblGoToR.Cursor = Cursors.Hand;
            lblGoToR.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoToR.ForeColor = Color.FromArgb(255, 128, 0);
            lblGoToR.Location = new Point(115, 523);
            lblGoToR.Name = "lblGoToR";
            lblGoToR.Size = new Size(96, 28);
            lblGoToR.TabIndex = 2;
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
            lblGoToL.Location = new Point(405, 523);
            lblGoToL.Name = "lblGoToL";
            lblGoToL.Size = new Size(65, 28);
            lblGoToL.TabIndex = 1;
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
            picClose.Location = new Point(565, 15);
            picClose.Name = "picClose";
            picClose.Size = new Size(20, 20);
            picClose.TabIndex = 32;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.SteeringWheel2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(319, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // tmrFadeIn
            // 
            tmrFadeIn.Interval = 10;
            tmrFadeIn.Tick += tmrFadeIn_Tick;
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
            btnAbout.ColorBackground_Pen = Color.FromArgb(255, 128, 0);
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
            btnAbout.ForeColor = Color.Silver;
            btnAbout.Lighting = false;
            btnAbout.LinearGradient_Background = false;
            btnAbout.LinearGradientPen = false;
            btnAbout.Location = new Point(188, 288);
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
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.BackColor = Color.Transparent;
            lblMainTitle.Font = new Font("Copperplate Gothic Bold", 36F);
            lblMainTitle.ForeColor = Color.Silver;
            lblMainTitle.Location = new Point(33, 164);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(538, 106);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "Peak Performance\r\nVehicle Rentals";
            lblMainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picCar
            // 
            picCar.Anchor = AnchorStyles.None;
            picCar.BackColor = Color.Transparent;
            picCar.Image = Properties.Resources.OrangeMustang;
            picCar.Location = new Point(169, 24);
            picCar.Name = "picCar";
            picCar.Size = new Size(250, 175);
            picCar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCar.TabIndex = 50;
            picCar.TabStop = false;
            // 
            // MainLR
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.LRNew2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 600);
            Controls.Add(pictureBox1);
            Controls.Add(btnAbout);
            Controls.Add(picClose);
            Controls.Add(lblGoToL);
            Controls.Add(lblGoToR);
            Controls.Add(lblMainTitle);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGoToR;
        private Label lblGoToL;
        private PictureBox picClose;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrFadeIn;
        private ReaLTaiizor.Controls.CyberButton btnAbout;
        private Label lblMainTitle;
        private PictureBox picCar;
    }
}
