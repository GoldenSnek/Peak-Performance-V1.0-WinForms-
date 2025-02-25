namespace Peak_Performance_V1._0
{
    partial class MainLR
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HomeMenu = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lblMainTitle = new Label();
            lblMotto = new Label();
            lblProceed = new Label();
            lblGoToL = new Label();
            label1 = new Label();
            lblGoToR = new Label();
            HomeMenu.SuspendLayout();
            SuspendLayout();
            // 
            // HomeMenu
            // 
            HomeMenu.Dock = DockStyle.Left;
            HomeMenu.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, loginToolStripMenuItem, registerToolStripMenuItem, aboutToolStripMenuItem, exitToolStripMenuItem });
            HomeMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            HomeMenu.Location = new Point(0, 0);
            HomeMenu.Name = "HomeMenu";
            HomeMenu.Size = new Size(76, 561);
            HomeMenu.TabIndex = 0;
            HomeMenu.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(63, 23);
            homeToolStripMenuItem.Text = "Home";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(63, 23);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(63, 23);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(63, 23);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(63, 23);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Location = new Point(203, 98);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(218, 19);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "Peak Performance | Vehicle Rentals";
            // 
            // lblMotto
            // 
            lblMotto.AutoSize = true;
            lblMotto.Location = new Point(230, 130);
            lblMotto.Name = "lblMotto";
            lblMotto.Size = new Size(157, 19);
            lblMotto.TabIndex = 2;
            lblMotto.Text = "--- Rent Ride Repeat ---";
            // 
            // lblProceed
            // 
            lblProceed.AutoSize = true;
            lblProceed.Location = new Point(147, 444);
            lblProceed.Name = "lblProceed";
            lblProceed.Size = new Size(165, 19);
            lblProceed.TabIndex = 16;
            lblProceed.Text = "Already have an account?";
            // 
            // lblGoToL
            // 
            lblGoToL.AutoSize = true;
            lblGoToL.Location = new Point(173, 473);
            lblGoToL.Name = "lblGoToL";
            lblGoToL.Size = new Size(113, 19);
            lblGoToL.TabIndex = 15;
            lblGoToL.Text = "Proceed to Login";
            lblGoToL.Click += lblGoToL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 444);
            label1.Name = "label1";
            label1.Size = new Size(176, 19);
            label1.TabIndex = 18;
            label1.Text = "Don't have an account yet?";
            // 
            // lblGoToR
            // 
            lblGoToR.AutoSize = true;
            lblGoToR.Location = new Point(381, 473);
            lblGoToR.Name = "lblGoToR";
            lblGoToR.Size = new Size(122, 19);
            lblGoToR.TabIndex = 17;
            lblGoToR.Text = "Create an Account";
            lblGoToR.Click += lblGoToR_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 561);
            Controls.Add(label1);
            Controls.Add(lblGoToR);
            Controls.Add(lblProceed);
            Controls.Add(lblGoToL);
            Controls.Add(lblMotto);
            Controls.Add(lblMainTitle);
            Controls.Add(HomeMenu);
            MainMenuStrip = HomeMenu;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            HomeMenu.ResumeLayout(false);
            HomeMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip HomeMenu;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lblMainTitle;
        private Label lblMotto;
        private Label lblProceed;
        private Label lblGoToL;
        private Label label1;
        private Label lblGoToR;
    }
}
