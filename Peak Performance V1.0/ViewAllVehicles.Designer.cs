namespace Peak_Performance_V1._0
{
    partial class ViewAllVehicles
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
            flpDisplay = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpDisplay
            // 
            flpDisplay.AutoScroll = true;
            flpDisplay.Location = new Point(254, 49);
            flpDisplay.Name = "flpDisplay";
            flpDisplay.Size = new Size(650, 650);
            flpDisplay.TabIndex = 0;
            // 
            // ViewAllVehicles
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1184, 761);
            Controls.Add(flpDisplay);
            Name = "ViewAllVehicles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewAllVehicles";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpDisplay;
    }
}