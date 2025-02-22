namespace Peak_Performance_V1._0
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            lblAbout = new Label();
            SuspendLayout();
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Location = new Point(114, 166);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(342, 247);
            lblAbout.TabIndex = 2;
            lblAbout.Text = resources.GetString("lblAbout.Text");
            lblAbout.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 561);
            Controls.Add(lblAbout);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAbout;
    }
}