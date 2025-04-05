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
            tmrProgress = new System.Windows.Forms.Timer(components);
            picSplash1 = new PictureBox();
            lblLoading = new Label();
            picSplash2 = new PictureBox();
            ProgressBar = new ReaLTaiizor.Controls.AloneProgressBar();
            cyberProgressBar = new ReaLTaiizor.Controls.CyberProgressBar();
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
            picSplash1.Image = Properties.Resources.NightRide;
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
            lblLoading.Location = new Point(38, 460);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(87, 18);
            lblLoading.TabIndex = 49;
            lblLoading.Text = "Loading...";
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
            // ProgressBar
            // 
            ProgressBar.BackColor = Color.Transparent;
            ProgressBar.BackgroundColor = Color.FromArgb(255, 128, 0);
            ProgressBar.BaseColor = Color.Black;
            ProgressBar.BorderColor = Color.FromArgb(192, 64, 0);
            ProgressBar.Location = new Point(38, 424);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(523, 33);
            ProgressBar.Stripes = Color.Black;
            ProgressBar.TabIndex = 54;
            ProgressBar.Text = "aloneProgressBar1";
            ProgressBar.Value = 80;
            // 
            // cyberProgressBar
            // 
            cyberProgressBar.Alpha = 50;
            cyberProgressBar.BackColor = Color.Transparent;
            cyberProgressBar.Background = true;
            cyberProgressBar.Background_WidthPen = 3F;
            cyberProgressBar.BackgroundPen = true;
            cyberProgressBar.ColorBackground = Color.Black;
            cyberProgressBar.ColorBackground_1 = Color.Black;
            cyberProgressBar.ColorBackground_2 = Color.Black;
            cyberProgressBar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberProgressBar.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            cyberProgressBar.ColorBackground_Value_2 = Color.Black;
            cyberProgressBar.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberProgressBar.ColorPen_1 = Color.Black;
            cyberProgressBar.ColorPen_2 = Color.Black;
            cyberProgressBar.ColorProgressBar = Color.FromArgb(29, 200, 238);
            cyberProgressBar.ColorValue_Transparency = 200;
            cyberProgressBar.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberProgressBar.Font = new Font("Arial", 11F);
            cyberProgressBar.ForeColor = Color.FromArgb(245, 245, 245);
            cyberProgressBar.Lighting = false;
            cyberProgressBar.LinearGradient_Background = false;
            cyberProgressBar.LinearGradient_Value = false;
            cyberProgressBar.LinearGradientPen = false;
            cyberProgressBar.Location = new Point(29, 82);
            cyberProgressBar.Maximum = 100;
            cyberProgressBar.Minimum = 0;
            cyberProgressBar.Name = "cyberProgressBar";
            cyberProgressBar.PenWidth = 10;
            cyberProgressBar.ProgressText = true;
            cyberProgressBar.RGB = true;
            cyberProgressBar.Rounding = true;
            cyberProgressBar.RoundingInt = 0;
            cyberProgressBar.Size = new Size(541, 322);
            cyberProgressBar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberProgressBar.StartDrawingValue = 0;
            cyberProgressBar.TabIndex = 52;
            cyberProgressBar.Tag = "Cyber";
            cyberProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberProgressBar.Timer_RGB = 10;
            cyberProgressBar.Value = 0;
            cyberProgressBar.Visible = false;
            // 
            // SplashLoading
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            ClientSize = new Size(600, 600);
            Controls.Add(ProgressBar);
            Controls.Add(lblLoading);
            Controls.Add(picSplash2);
            Controls.Add(picSplash1);
            Controls.Add(cyberProgressBar);
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
        private PictureBox picSplash2;
        private ReaLTaiizor.Controls.AloneProgressBar ProgressBar;
        private ReaLTaiizor.Controls.CyberProgressBar cyberProgressBar;
    }
}