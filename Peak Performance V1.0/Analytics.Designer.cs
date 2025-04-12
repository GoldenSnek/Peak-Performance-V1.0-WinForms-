namespace Peak_Performance_V1._0
{
    partial class Analytics
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
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            panel1 = new Panel();
            panel2 = new Panel();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            panel3 = new Panel();
            plotView3 = new OxyPlot.WindowsForms.PlotView();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // plotView1
            // 
            plotView1.BackColor = Color.Lavender;
            plotView1.ForeColor = Color.Lavender;
            plotView1.Location = new Point(5, 5);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(350, 250);
            plotView1.TabIndex = 6;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(plotView1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(53, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 260);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(plotView2);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(53, 401);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 260);
            panel2.TabIndex = 13;
            // 
            // plotView2
            // 
            plotView2.BackColor = Color.Lavender;
            plotView2.ForeColor = Color.Lavender;
            plotView2.Location = new Point(5, 5);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(350, 250);
            plotView2.TabIndex = 6;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(plotView3);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(521, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 567);
            panel3.TabIndex = 13;
            // 
            // plotView3
            // 
            plotView3.BackColor = Color.Lavender;
            plotView3.ForeColor = Color.Lavender;
            plotView3.Location = new Point(5, 5);
            plotView3.Name = "plotView3";
            plotView3.PanCursor = Cursors.Hand;
            plotView3.Size = new Size(350, 557);
            plotView3.TabIndex = 6;
            plotView3.Text = "plotView3";
            plotView3.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView3.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView3.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = Properties.Resources.CarbonFiber;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(964, 704);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // Analytics
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(964, 704);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Analytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProviderViewRental";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Panel panel1;
        private Panel panel2;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private Panel panel3;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private PictureBox pictureBox1;
    }
}