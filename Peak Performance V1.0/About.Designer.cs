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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            lblAbout = new Label();
            picBack = new PictureBox();
            picClose = new PictureBox();
            lblREGISTER = new Label();
            picFB = new PictureBox();
            picDiscord = new PictureBox();
            picGithub = new PictureBox();
            tmrFadeIn = new System.Windows.Forms.Timer(components);
            picDrawCar = new PictureBox();
            picCar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDiscord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGithub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDrawCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            SuspendLayout();
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.FlatStyle = FlatStyle.Flat;
            lblAbout.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAbout.ForeColor = Color.White;
            lblAbout.Location = new Point(85, 204);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(440, 238);
            lblAbout.TabIndex = 2;
            lblAbout.Text = resources.GetString("lblAbout.Text");
            lblAbout.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picBack
            // 
            picBack.BackColor = Color.Transparent;
            picBack.BackgroundImage = Properties.Resources.Back3;
            picBack.BackgroundImageLayout = ImageLayout.Stretch;
            picBack.Cursor = Cursors.Hand;
            picBack.Location = new Point(12, 12);
            picBack.Name = "picBack";
            picBack.Size = new Size(30, 30);
            picBack.TabIndex = 44;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // picClose
            // 
            picClose.BackColor = Color.Transparent;
            picClose.BackgroundImage = Properties.Resources.Close2;
            picClose.BackgroundImageLayout = ImageLayout.Stretch;
            picClose.Cursor = Cursors.Hand;
            picClose.Location = new Point(565, 15);
            picClose.Name = "picClose";
            picClose.Size = new Size(20, 20);
            picClose.TabIndex = 43;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // lblREGISTER
            // 
            lblREGISTER.AutoSize = true;
            lblREGISTER.BackColor = Color.Transparent;
            lblREGISTER.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblREGISTER.ForeColor = Color.FromArgb(255, 128, 0);
            lblREGISTER.Location = new Point(198, 43);
            lblREGISTER.Name = "lblREGISTER";
            lblREGISTER.Size = new Size(213, 53);
            lblREGISTER.TabIndex = 42;
            lblREGISTER.Text = "ABOUT";
            // 
            // picFB
            // 
            picFB.BackColor = Color.Transparent;
            picFB.BackgroundImage = Properties.Resources.Facebook;
            picFB.BackgroundImageLayout = ImageLayout.Stretch;
            picFB.Cursor = Cursors.Hand;
            picFB.Location = new Point(167, 489);
            picFB.Name = "picFB";
            picFB.Size = new Size(50, 50);
            picFB.TabIndex = 45;
            picFB.TabStop = false;
            picFB.Click += picFB_Click;
            // 
            // picDiscord
            // 
            picDiscord.BackColor = Color.Transparent;
            picDiscord.BackgroundImage = Properties.Resources.Discord;
            picDiscord.BackgroundImageLayout = ImageLayout.Stretch;
            picDiscord.Cursor = Cursors.Hand;
            picDiscord.Location = new Point(361, 489);
            picDiscord.Name = "picDiscord";
            picDiscord.Size = new Size(50, 50);
            picDiscord.TabIndex = 46;
            picDiscord.TabStop = false;
            picDiscord.Click += picDiscord_Click;
            // 
            // picGithub
            // 
            picGithub.BackColor = Color.Transparent;
            picGithub.BackgroundImage = Properties.Resources.Github1;
            picGithub.BackgroundImageLayout = ImageLayout.Stretch;
            picGithub.Cursor = Cursors.Hand;
            picGithub.Location = new Point(266, 489);
            picGithub.Name = "picGithub";
            picGithub.Size = new Size(50, 50);
            picGithub.TabIndex = 47;
            picGithub.TabStop = false;
            picGithub.Click += picGithub_Click;
            // 
            // tmrFadeIn
            // 
            tmrFadeIn.Interval = 10;
            tmrFadeIn.Tick += tmrFadeIn_Tick;
            // 
            // picDrawCar
            // 
            picDrawCar.Anchor = AnchorStyles.None;
            picDrawCar.BackColor = Color.Transparent;
            picDrawCar.Image = Properties.Resources.SportsCar;
            picDrawCar.Location = new Point(492, 115);
            picDrawCar.Name = "picDrawCar";
            picDrawCar.Size = new Size(179, 195);
            picDrawCar.SizeMode = PictureBoxSizeMode.StretchImage;
            picDrawCar.TabIndex = 48;
            picDrawCar.TabStop = false;
            // 
            // picCar
            // 
            picCar.Anchor = AnchorStyles.None;
            picCar.BackColor = Color.Transparent;
            picCar.Image = Properties.Resources.OrangeMustang;
            picCar.Location = new Point(178, 59);
            picCar.Name = "picCar";
            picCar.Size = new Size(250, 175);
            picCar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCar.TabIndex = 49;
            picCar.TabStop = false;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.LRNew2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 600);
            Controls.Add(lblREGISTER);
            Controls.Add(picGithub);
            Controls.Add(picDiscord);
            Controls.Add(picFB);
            Controls.Add(picBack);
            Controls.Add(picClose);
            Controls.Add(lblAbout);
            Controls.Add(picDrawCar);
            Controls.Add(picCar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += About_Load;
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFB).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDiscord).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGithub).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDrawCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAbout;
        private PictureBox picBack;
        private PictureBox picClose;
        private Label lblREGISTER;
        private PictureBox picFB;
        private PictureBox picDiscord;
        private PictureBox picGithub;
        private System.Windows.Forms.Timer tmrFadeIn;
        private PictureBox picDrawCar;
        private PictureBox picCar;
    }
}