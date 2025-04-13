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
            panel1 = new Panel();
            lblApproval = new Label();
            lblCurrent = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpWaitingApproval
            // 
            flpWaitingApproval.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flpWaitingApproval.AutoScroll = true;
            flpWaitingApproval.BackgroundImage = Properties.Resources.CarbonFiber2;
            flpWaitingApproval.Location = new Point(0, 50);
            flpWaitingApproval.Name = "flpWaitingApproval";
            flpWaitingApproval.Size = new Size(482, 654);
            flpWaitingApproval.TabIndex = 1;
            // 
            // flpCurrentlyRented
            // 
            flpCurrentlyRented.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCurrentlyRented.AutoScroll = true;
            flpCurrentlyRented.BackgroundImage = Properties.Resources.CarbonFiber3;
            flpCurrentlyRented.Location = new Point(482, 50);
            flpCurrentlyRented.Name = "flpCurrentlyRented";
            flpCurrentlyRented.Size = new Size(482, 654);
            flpCurrentlyRented.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 60);
            panel1.Controls.Add(lblApproval);
            panel1.Controls.Add(lblCurrent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 50);
            panel1.TabIndex = 4;
            // 
            // lblApproval
            // 
            lblApproval.Font = new Font("Copperplate Gothic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApproval.ForeColor = Color.FromArgb(255, 128, 0);
            lblApproval.Location = new Point(91, 9);
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
            lblCurrent.ForeColor = Color.FromArgb(255, 128, 0);
            lblCurrent.Location = new Point(578, 9);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(314, 30);
            lblCurrent.TabIndex = 5;
            lblCurrent.Text = "Currently being rented";
            lblCurrent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProviderViewRental
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(964, 704);
            Controls.Add(flpWaitingApproval);
            Controls.Add(flpCurrentlyRented);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProviderViewRental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProviderViewRental";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpWaitingApproval;
        private FlowLayoutPanel flpCurrentlyRented;
        private Panel panel1;
        private Label lblCurrent;
        private Label lblApproval;
    }
}