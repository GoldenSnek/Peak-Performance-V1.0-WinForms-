namespace Peak_Performance_V1._0
{
    partial class ProviderViewRental
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
            flpWaitingApproval = new FlowLayoutPanel();
            flpCurrentlyRented = new FlowLayoutPanel();
            lblStatistics = new Label();
            panel1 = new Panel();
            lblApproval = new Label();
            lblCurrent = new Label();
            panel2 = new Panel();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flpWaitingApproval
            // 
            flpWaitingApproval.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flpWaitingApproval.AutoScroll = true;
            flpWaitingApproval.BackgroundImage = Properties.Resources.CarbonFiber2;
            flpWaitingApproval.Location = new Point(0, 50);
            flpWaitingApproval.Name = "flpWaitingApproval";
            flpWaitingApproval.Size = new Size(360, 654);
            flpWaitingApproval.TabIndex = 1;
            // 
            // flpCurrentlyRented
            // 
            flpCurrentlyRented.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCurrentlyRented.AutoScroll = true;
            flpCurrentlyRented.BackgroundImage = Properties.Resources.CarbonFiber3;
            flpCurrentlyRented.Location = new Point(360, 50);
            flpCurrentlyRented.Name = "flpCurrentlyRented";
            flpCurrentlyRented.Size = new Size(360, 654);
            flpCurrentlyRented.TabIndex = 2;
            // 
            // lblStatistics
            // 
            lblStatistics.Anchor = AnchorStyles.Top;
            lblStatistics.AutoSize = true;
            lblStatistics.Font = new Font("Copperplate Gothic Bold", 14.25F);
            lblStatistics.ForeColor = Color.FromArgb(255, 128, 0);
            lblStatistics.Location = new Point(61, 28);
            lblStatistics.Name = "lblStatistics";
            lblStatistics.Size = new Size(119, 21);
            lblStatistics.TabIndex = 3;
            lblStatistics.Text = "Statistics";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(35, 40, 60);
            panel1.Controls.Add(lblApproval);
            panel1.Controls.Add(lblCurrent);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 50);
            panel1.TabIndex = 4;
            // 
            // lblApproval
            // 
            lblApproval.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApproval.ForeColor = Color.White;
            lblApproval.Location = new Point(31, 9);
            lblApproval.Name = "lblApproval";
            lblApproval.Size = new Size(314, 30);
            lblApproval.TabIndex = 6;
            lblApproval.Text = "Waiting for approval";
            lblApproval.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrent
            // 
            lblCurrent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrent.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrent.ForeColor = Color.White;
            lblCurrent.Location = new Point(381, 9);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(314, 30);
            lblCurrent.TabIndex = 5;
            lblCurrent.Text = "Currently being rented";
            lblCurrent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(35, 40, 60);
            panel2.Controls.Add(plotView2);
            panel2.Controls.Add(plotView1);
            panel2.Controls.Add(lblStatistics);
            panel2.Location = new Point(720, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 654);
            panel2.TabIndex = 5;
            // 
            // plotView2
            // 
            plotView2.Location = new Point(7, 392);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(228, 250);
            plotView2.TabIndex = 7;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(7, 103);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(228, 250);
            plotView1.TabIndex = 6;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // ProviderViewRental
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(964, 704);
            Controls.Add(panel2);
            Controls.Add(flpWaitingApproval);
            Controls.Add(flpCurrentlyRented);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderViewRental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProviderViewRental";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpWaitingApproval;
        private FlowLayoutPanel flpCurrentlyRented;
        private Label lblStatistics;
        private Panel panel1;
        private Label lblCurrent;
        private Panel panel2;
        private Label lblApproval;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
    }
}