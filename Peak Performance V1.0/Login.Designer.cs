namespace Peak_Performance_V1._0
{
    partial class Login
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
            lblGoToR = new Label();
            lblProceed = new Label();
            btnLogin = new ReaLTaiizor.Controls.MaterialButton();
            txtUsername = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            chkShowPass = new ReaLTaiizor.Controls.CyberCheckBox();
            lblLOGIN = new Label();
            label1 = new Label();
            lblUsernameError = new Label();
            lblPasswordError = new Label();
            picClose = new PictureBox();
            picBack = new PictureBox();
            tmrFadeIn = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            SuspendLayout();
            // 
            // lblGoToR
            // 
            lblGoToR.AutoSize = true;
            lblGoToR.BackColor = Color.Transparent;
            lblGoToR.Cursor = Cursors.Hand;
            lblGoToR.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoToR.ForeColor = Color.FromArgb(255, 128, 0);
            lblGoToR.Location = new Point(212, 537);
            lblGoToR.Name = "lblGoToR";
            lblGoToR.Size = new Size(162, 28);
            lblGoToR.TabIndex = 4;
            lblGoToR.Text = "Create an Account";
            lblGoToR.TextAlign = ContentAlignment.MiddleCenter;
            lblGoToR.Click += lblGoToR_Click;
            // 
            // lblProceed
            // 
            lblProceed.AutoSize = true;
            lblProceed.BackColor = Color.Transparent;
            lblProceed.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProceed.ForeColor = Color.White;
            lblProceed.Location = new Point(186, 519);
            lblProceed.Name = "lblProceed";
            lblProceed.Size = new Size(225, 18);
            lblProceed.TabIndex = 15;
            lblProceed.Text = "Don't have an account yet?";
            lblProceed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = false;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLogin.Location = new Point(173, 417);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(250, 36);
            btnLogin.TabIndex = 21;
            btnLogin.Text = "Login";
            btnLogin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.AnimateReadOnly = false;
            txtUsername.AutoCompleteMode = AutoCompleteMode.None;
            txtUsername.AutoCompleteSource = AutoCompleteSource.None;
            txtUsername.BackgroundImageLayout = ImageLayout.None;
            txtUsername.CharacterCasing = CharacterCasing.Normal;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.HideSelection = true;
            txtUsername.Hint = "Username";
            txtUsername.LeadingIcon = Properties.Resources.Username;
            txtUsername.LeaveOnEnterKey = true;
            txtUsername.Location = new Point(150, 184);
            txtUsername.MaxLength = 32767;
            txtUsername.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PrefixSuffixText = null;
            txtUsername.ReadOnly = false;
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.ShortcutsEnabled = true;
            txtUsername.Size = new Size(300, 48);
            txtUsername.TabIndex = 19;
            txtUsername.TabStop = false;
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TrailingIcon = null;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.LeadingIcon = Properties.Resources.Password;
            txtPassword.LeaveOnEnterKey = true;
            txtPassword.Location = new Point(150, 273);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(300, 48);
            txtPassword.TabIndex = 20;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // chkShowPass
            // 
            chkShowPass.BackColor = Color.Transparent;
            chkShowPass.Background = true;
            chkShowPass.Background_WidthPen = 2F;
            chkShowPass.BackgroundPen = true;
            chkShowPass.Checked = false;
            chkShowPass.ColorBackground = Color.FromArgb(64, 64, 64);
            chkShowPass.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            chkShowPass.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            chkShowPass.ColorBackground_Pen = Color.White;
            chkShowPass.ColorChecked = Color.FromArgb(255, 128, 0);
            chkShowPass.ColorPen_1 = Color.FromArgb(37, 52, 68);
            chkShowPass.ColorPen_2 = Color.FromArgb(41, 63, 86);
            chkShowPass.Cursor = Cursors.Hand;
            chkShowPass.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            chkShowPass.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            chkShowPass.Effect_1_Transparency = 25;
            chkShowPass.Effect_2 = true;
            chkShowPass.Effect_2_ColorBackground = Color.White;
            chkShowPass.Effect_2_Transparency = 15;
            chkShowPass.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPass.ForeColor = Color.FromArgb(245, 245, 245);
            chkShowPass.LinearGradient_Background = false;
            chkShowPass.LinearGradientPen = false;
            chkShowPass.Location = new Point(296, 327);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.RGB = false;
            chkShowPass.Rounding = true;
            chkShowPass.RoundingInt = 50;
            chkShowPass.Size = new Size(154, 45);
            chkShowPass.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkShowPass.TabIndex = 23;
            chkShowPass.Tag = "Cyber";
            chkShowPass.TextButton = "Show Password";
            chkShowPass.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chkShowPass.Timer_Effect_1 = 1;
            chkShowPass.Timer_RGB = 300;
            chkShowPass.Click += chkShowPass_CheckedChanged;
            // 
            // lblLOGIN
            // 
            lblLOGIN.AutoSize = true;
            lblLOGIN.BackColor = Color.Transparent;
            lblLOGIN.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLOGIN.ForeColor = Color.FromArgb(255, 128, 0);
            lblLOGIN.Location = new Point(198, 43);
            lblLOGIN.Name = "lblLOGIN";
            lblLOGIN.Size = new Size(197, 53);
            lblLOGIN.TabIndex = 24;
            lblLOGIN.Text = "LOGIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(206, 99);
            label1.Name = "label1";
            label1.Size = new Size(182, 18);
            label1.TabIndex = 25;
            label1.Text = "Login to your account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.BackColor = Color.Transparent;
            lblUsernameError.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsernameError.ForeColor = Color.Red;
            lblUsernameError.Location = new Point(150, 235);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(0, 16);
            lblUsernameError.TabIndex = 26;
            lblUsernameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.BackColor = Color.Transparent;
            lblPasswordError.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(150, 324);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 16);
            lblPasswordError.TabIndex = 27;
            lblPasswordError.TextAlign = ContentAlignment.MiddleCenter;
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
            picClose.TabIndex = 28;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
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
            picBack.TabIndex = 29;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // tmrFadeIn
            // 
            tmrFadeIn.Interval = 10;
            tmrFadeIn.Tick += tmrFadeIn_Tick;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.LRNew2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 600);
            Controls.Add(picBack);
            Controls.Add(picClose);
            Controls.Add(lblPasswordError);
            Controls.Add(lblUsernameError);
            Controls.Add(label1);
            Controls.Add(lblLOGIN);
            Controls.Add(chkShowPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(lblProceed);
            Controls.Add(lblGoToR);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1040);
            Name = "Login";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            TransparencyKey = Color.Fuchsia;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGoToR;
        private Label lblProceed;
        private ReaLTaiizor.Controls.MaterialButton btnLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsername;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.CyberCheckBox chkShowPass;
        private Label lblLOGIN;
        private Label label1;
        private Label lblUsernameError;
        private Label lblPasswordError;
        private PictureBox picClose;
        private PictureBox picBack;
        private System.Windows.Forms.Timer tmrFadeIn;
    }
}