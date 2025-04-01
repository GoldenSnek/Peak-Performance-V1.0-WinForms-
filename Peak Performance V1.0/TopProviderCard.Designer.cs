namespace Peak_Performance_V1._0
{
    partial class TopProviderCard
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
            lblName = new Label();
            pnlTop = new Panel();
            pnlDown = new Panel();
            pnlRight = new Panel();
            pnlLeft = new Panel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            picUser = new PictureBox();
            pictureBox1 = new PictureBox();
            lblRating = new Label();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Copperplate Gothic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Lavender;
            lblName.Location = new Point(72, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(145, 26);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 128, 0);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.ForeColor = Color.Coral;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(220, 1);
            pnlTop.TabIndex = 13;
            // 
            // pnlDown
            // 
            pnlDown.BackColor = Color.FromArgb(255, 128, 0);
            pnlDown.Dock = DockStyle.Bottom;
            pnlDown.ForeColor = Color.Coral;
            pnlDown.Location = new Point(0, 149);
            pnlDown.Name = "pnlDown";
            pnlDown.Size = new Size(220, 1);
            pnlDown.TabIndex = 14;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(255, 128, 0);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.ForeColor = Color.Coral;
            pnlRight.Location = new Point(219, 1);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1, 148);
            pnlRight.TabIndex = 14;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(255, 128, 0);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.ForeColor = Color.Coral;
            pnlLeft.Location = new Point(0, 1);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(1, 148);
            pnlLeft.TabIndex = 14;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.FromArgb(255, 192, 128);
            parrotGradientPanel1.BottomRight = Color.FromArgb(192, 64, 0);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(picUser);
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(13, 14);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(55, 55);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 16;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(192, 64, 0);
            parrotGradientPanel1.TopRight = Color.FromArgb(255, 192, 128);
            // 
            // picUser
            // 
            picUser.BackColor = Color.Lavender;
            picUser.Location = new Point(3, 2);
            picUser.Name = "picUser";
            picUser.Size = new Size(50, 50);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 12;
            picUser.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Star1;
            pictureBox1.Location = new Point(13, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.BackColor = Color.Transparent;
            lblRating.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRating.ForeColor = Color.Lavender;
            lblRating.Location = new Point(44, 105);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(62, 25);
            lblRating.TabIndex = 21;
            lblRating.Text = "Rating";
            lblRating.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TopProviderCard
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(45, 60, 75);
            BackgroundImage = Properties.Resources.BGbmw;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblRating);
            Controls.Add(pictureBox1);
            Controls.Add(parrotGradientPanel1);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Controls.Add(pnlDown);
            Controls.Add(pnlTop);
            Controls.Add(lblName);
            DoubleBuffered = true;
            Name = "TopProviderCard";
            Size = new Size(220, 150);
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblName;
        private Panel pnlTop;
        private Panel pnlDown;
        private Panel pnlRight;
        private Panel pnlLeft;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private PictureBox pictureBox1;
        private Label lblRating;
        private PictureBox picUser;
    }
}