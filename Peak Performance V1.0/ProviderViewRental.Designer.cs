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
            SuspendLayout();
            // 
            // flpWaitingApproval
            // 
            flpWaitingApproval.AutoScroll = true;
            flpWaitingApproval.Location = new Point(216, 55);
            flpWaitingApproval.Name = "flpWaitingApproval";
            flpWaitingApproval.Size = new Size(352, 650);
            flpWaitingApproval.TabIndex = 1;
            // 
            // flpCurrentlyRented
            // 
            flpCurrentlyRented.AutoScroll = true;
            flpCurrentlyRented.Location = new Point(594, 55);
            flpCurrentlyRented.Name = "flpCurrentlyRented";
            flpCurrentlyRented.Size = new Size(352, 650);
            flpCurrentlyRented.TabIndex = 2;
            // 
            // lblStatistics
            // 
            lblStatistics.AutoSize = true;
            lblStatistics.Location = new Point(1023, 87);
            lblStatistics.Name = "lblStatistics";
            lblStatistics.Size = new Size(62, 19);
            lblStatistics.TabIndex = 3;
            lblStatistics.Text = "Statistics";
            // 
            // ProviderViewRental
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1184, 761);
            Controls.Add(lblStatistics);
            Controls.Add(flpCurrentlyRented);
            Controls.Add(flpWaitingApproval);
            Name = "ProviderViewRental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProviderViewRental";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpWaitingApproval;
        private FlowLayoutPanel flpCurrentlyRented;
        private Label lblStatistics;
    }
}