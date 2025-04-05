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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderViewRental));
            flpWaitingApproval = new FlowLayoutPanel();
            flpCurrentlyRented = new FlowLayoutPanel();
            lblStatistics = new Label();
            panel1 = new Panel();
            lblApproval = new Label();
            lblCurrent = new Label();
            panel2 = new Panel();
            parrotBarGraph1 = new ReaLTaiizor.Controls.ParrotBarGraph();
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
            panel2.Controls.Add(parrotBarGraph1);
            panel2.Controls.Add(lblStatistics);
            panel2.Location = new Point(720, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 654);
            panel2.TabIndex = 5;
            // 
            // parrotBarGraph1
            // 
            parrotBarGraph1.Anchor = AnchorStyles.None;
            parrotBarGraph1.FilledColor = Color.FromArgb(30, 33, 38);
            parrotBarGraph1.GraphOrientation = ReaLTaiizor.Controls.ParrotBarGraph.Orientation.Vertical;
            parrotBarGraph1.GraphStyle = ReaLTaiizor.Controls.ParrotBarGraph.Style.Material;
            parrotBarGraph1.Items = (List<int>)resources.GetObject("parrotBarGraph1.Items");
            parrotBarGraph1.Location = new Point(10, 226);
            parrotBarGraph1.Name = "parrotBarGraph1";
            parrotBarGraph1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotBarGraph1.ShowGrid = false;
            parrotBarGraph1.Size = new Size(226, 200);
            parrotBarGraph1.Sorting = ReaLTaiizor.Controls.ParrotBarGraph.SortStyle.Normal;
            parrotBarGraph1.SplitterColor = Color.FromArgb(59, 62, 71);
            parrotBarGraph1.TabIndex = 5;
            parrotBarGraph1.Text = "parrotBarGraph1";
            parrotBarGraph1.TextAlignment = ReaLTaiizor.Controls.ParrotBarGraph.Aligning.Far;
            parrotBarGraph1.TextColor = Color.FromArgb(120, 120, 120);
            parrotBarGraph1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotBarGraph1.UnfilledColor = Color.FromArgb(37, 40, 49);
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
        private ReaLTaiizor.Controls.ParrotBarGraph parrotBarGraph1;
    }
}