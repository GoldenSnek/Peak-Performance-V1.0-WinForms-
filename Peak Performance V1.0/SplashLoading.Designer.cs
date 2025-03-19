namespace Peak_Performance_V1._0
{
    partial class SplashLoading
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashLoading));
            tmrProgress = new System.Windows.Forms.Timer(components);
            picSplash1 = new PictureBox();
            lblLoading = new Label();
            ProgressBar = new ReaLTaiizor.Controls.ParrotFlatProgressBar();
            cyberProgressBar1 = new ReaLTaiizor.Controls.CyberProgressBar();
            picSplash2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picSplash1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSplash2).BeginInit();
            SuspendLayout();
            // 
            // tmrProgress
            // 
            tmrProgress.Interval = 50;
            tmrProgress.Tick += tmrProgress_Tick;
            // 
            // picSplash1
            // 
            picSplash1.BackgroundImageLayout = ImageLayout.Stretch;
            picSplash1.Image = Properties.Resources.Sunset;
            picSplash1.Location = new Point(40, 93);
            picSplash1.Name = "picSplash1";
            picSplash1.Size = new Size(521, 302);
            picSplash1.SizeMode = PictureBoxSizeMode.StretchImage;
            picSplash1.TabIndex = 48;
            picSplash1.TabStop = false;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoading.ForeColor = Color.White;
            lblLoading.Location = new Point(12, 490);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(87, 18);
            lblLoading.TabIndex = 49;
            lblLoading.Text = "Loading...";
            // 
            // ProgressBar
            // 
            ProgressBar.BarStyle = ReaLTaiizor.Controls.ParrotFlatProgressBar.Style.Material;
            ProgressBar.BorderColor = Color.Black;
            ProgressBar.Colors = (List<Color>)resources.GetObject("ProgressBar.Colors");
            ProgressBar.CompleteBackColor = Color.FromArgb(0, 120, 250);
            ProgressBar.CompleteColor = Color.FromArgb(1, 119, 215);
            ProgressBar.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            ProgressBar.IncompletedBackColor = Color.FromArgb(180, 180, 180);
            ProgressBar.InocmpletedColor = Color.Black;
            ProgressBar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            ProgressBar.Location = new Point(12, 520);
            ProgressBar.MaxValue = 100;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            ProgressBar.Positions = (List<float>)resources.GetObject("ProgressBar.Positions");
            ProgressBar.ShowBorder = true;
            ProgressBar.Size = new Size(576, 35);
            ProgressBar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ProgressBar.TabIndex = 51;
            ProgressBar.Text = "parrotFlatProgressBar1";
            ProgressBar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            ProgressBar.Value = 0;
            // 
            // cyberProgressBar1
            // 
            cyberProgressBar1.Alpha = 50;
            cyberProgressBar1.BackColor = Color.Transparent;
            cyberProgressBar1.Background = true;
            cyberProgressBar1.Background_WidthPen = 3F;
            cyberProgressBar1.BackgroundPen = true;
            cyberProgressBar1.ColorBackground = Color.Black;
            cyberProgressBar1.ColorBackground_1 = Color.Black;
            cyberProgressBar1.ColorBackground_2 = Color.Black;
            cyberProgressBar1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberProgressBar1.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            cyberProgressBar1.ColorBackground_Value_2 = Color.Black;
            cyberProgressBar1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberProgressBar1.ColorPen_1 = Color.Black;
            cyberProgressBar1.ColorPen_2 = Color.Black;
            cyberProgressBar1.ColorProgressBar = Color.FromArgb(29, 200, 238);
            cyberProgressBar1.ColorValue_Transparency = 200;
            cyberProgressBar1.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberProgressBar1.Font = new Font("Arial", 11F);
            cyberProgressBar1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberProgressBar1.Lighting = false;
            cyberProgressBar1.LinearGradient_Background = false;
            cyberProgressBar1.LinearGradient_Value = false;
            cyberProgressBar1.LinearGradientPen = false;
            cyberProgressBar1.Location = new Point(12, 64);
            cyberProgressBar1.Maximum = 100;
            cyberProgressBar1.Minimum = 0;
            cyberProgressBar1.Name = "cyberProgressBar1";
            cyberProgressBar1.PenWidth = 10;
            cyberProgressBar1.ProgressText = true;
            cyberProgressBar1.RGB = true;
            cyberProgressBar1.Rounding = true;
            cyberProgressBar1.RoundingInt = 0;
            cyberProgressBar1.Size = new Size(576, 359);
            cyberProgressBar1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberProgressBar1.StartDrawingValue = 0;
            cyberProgressBar1.TabIndex = 52;
            cyberProgressBar1.Tag = "Cyber";
            cyberProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberProgressBar1.Timer_RGB = 10;
            cyberProgressBar1.Value = 0;
            // 
            // picSplash2
            // 
            picSplash2.BackgroundImageLayout = ImageLayout.Stretch;
            picSplash2.Image = Properties.Resources.Dawn;
            picSplash2.Location = new Point(40, 93);
            picSplash2.Name = "picSplash2";
            picSplash2.Size = new Size(521, 302);
            picSplash2.SizeMode = PictureBoxSizeMode.StretchImage;
            picSplash2.TabIndex = 53;
            picSplash2.TabStop = false;
            // 
            // SplashLoading
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            ClientSize = new Size(600, 600);
            Controls.Add(picSplash2);
            Controls.Add(ProgressBar);
            Controls.Add(lblLoading);
            Controls.Add(picSplash1);
            Controls.Add(cyberProgressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.Black;
            ((System.ComponentModel.ISupportInitialize)picSplash1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSplash2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tmrProgress;
        private PictureBox picSplash1;
        private Label lblLoading;
        private ReaLTaiizor.Controls.ParrotFlatProgressBar ProgressBar;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar1;
        private PictureBox picSplash2;
    }
}