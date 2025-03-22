namespace Peak_Performance_V1._0
{
    partial class Register
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
            picBack = new PictureBox();
            picClose = new PictureBox();
            lblPasswordError = new Label();
            lblUsernameError = new Label();
            label1 = new Label();
            lblREGISTER = new Label();
            chkShowPass = new ReaLTaiizor.Controls.CyberCheckBox();
            txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUsername = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnRegister = new ReaLTaiizor.Controls.MaterialButton();
            lblProceed = new Label();
            lblGoToL = new Label();
            lblConPassError = new Label();
            txtConPass = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            rbtnClient = new ReaLTaiizor.Controls.CyberRadioButton();
            rbtnProvider = new ReaLTaiizor.Controls.CyberRadioButton();
            label2 = new Label();
            tmrFadeIn = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
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
            picBack.TabIndex = 41;
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
            picClose.TabIndex = 40;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.BackColor = Color.Transparent;
            lblPasswordError.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(152, 281);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 16);
            lblPasswordError.TabIndex = 39;
            lblPasswordError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.BackColor = Color.Transparent;
            lblUsernameError.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsernameError.ForeColor = Color.Red;
            lblUsernameError.Location = new Point(152, 192);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(0, 16);
            lblUsernameError.TabIndex = 38;
            lblUsernameError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(221, 99);
            label1.Name = "label1";
            label1.Size = new Size(157, 18);
            label1.TabIndex = 37;
            label1.Text = "Create an account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblREGISTER
            // 
            lblREGISTER.AutoSize = true;
            lblREGISTER.BackColor = Color.Transparent;
            lblREGISTER.Font = new Font("Copperplate Gothic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblREGISTER.ForeColor = Color.FromArgb(255, 128, 0);
            lblREGISTER.Location = new Point(154, 44);
            lblREGISTER.Name = "lblREGISTER";
            lblREGISTER.Size = new Size(297, 53);
            lblREGISTER.TabIndex = 36;
            lblREGISTER.Text = "REGISTER";
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
            chkShowPass.Location = new Point(298, 281);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.RGB = false;
            chkShowPass.Rounding = true;
            chkShowPass.RoundingInt = 50;
            chkShowPass.Size = new Size(154, 45);
            chkShowPass.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkShowPass.TabIndex = 35;
            chkShowPass.Tag = "Cyber";
            chkShowPass.TextButton = "Show Password";
            chkShowPass.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chkShowPass.Timer_Effect_1 = 1;
            chkShowPass.Timer_RGB = 300;
            chkShowPass.Click += chkShowPass_CheckedChanged;
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
            txtPassword.Location = new Point(152, 230);
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
            txtPassword.TabIndex = 34;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
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
            txtUsername.Location = new Point(152, 141);
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
            txtUsername.TabIndex = 33;
            txtUsername.TabStop = false;
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TrailingIcon = null;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = false;
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.BackColor = Color.White;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegister.Depth = 0;
            btnRegister.HighEmphasis = true;
            btnRegister.Icon = null;
            btnRegister.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRegister.Location = new Point(175, 460);
            btnRegister.Margin = new Padding(4, 6, 4, 6);
            btnRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.NoAccentTextColor = Color.Empty;
            btnRegister.Size = new Size(250, 36);
            btnRegister.TabIndex = 32;
            btnRegister.Text = "Register";
            btnRegister.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegister.UseAccentColor = false;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblProceed
            // 
            lblProceed.AutoSize = true;
            lblProceed.BackColor = Color.Transparent;
            lblProceed.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProceed.ForeColor = Color.White;
            lblProceed.Location = new Point(191, 519);
            lblProceed.Name = "lblProceed";
            lblProceed.Size = new Size(216, 18);
            lblProceed.TabIndex = 31;
            lblProceed.Text = "Already have an account?";
            lblProceed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGoToL
            // 
            lblGoToL.AutoSize = true;
            lblGoToL.BackColor = Color.Transparent;
            lblGoToL.Cursor = Cursors.Hand;
            lblGoToL.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoToL.ForeColor = Color.FromArgb(255, 128, 0);
            lblGoToL.Location = new Point(221, 536);
            lblGoToL.Name = "lblGoToL";
            lblGoToL.Size = new Size(148, 28);
            lblGoToL.TabIndex = 30;
            lblGoToL.Text = "Proceed to Login";
            lblGoToL.TextAlign = ContentAlignment.MiddleCenter;
            lblGoToL.Click += lblGoToL_Click;
            // 
            // lblConPassError
            // 
            lblConPassError.AutoSize = true;
            lblConPassError.BackColor = Color.Transparent;
            lblConPassError.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConPassError.ForeColor = Color.Red;
            lblConPassError.Location = new Point(152, 373);
            lblConPassError.Name = "lblConPassError";
            lblConPassError.Size = new Size(0, 16);
            lblConPassError.TabIndex = 43;
            lblConPassError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtConPass
            // 
            txtConPass.AnimateReadOnly = false;
            txtConPass.AutoCompleteMode = AutoCompleteMode.None;
            txtConPass.AutoCompleteSource = AutoCompleteSource.None;
            txtConPass.BackgroundImageLayout = ImageLayout.None;
            txtConPass.CharacterCasing = CharacterCasing.Normal;
            txtConPass.Depth = 0;
            txtConPass.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtConPass.HideSelection = true;
            txtConPass.Hint = "Confirm Password";
            txtConPass.LeadingIcon = Properties.Resources.ConPass;
            txtConPass.Location = new Point(152, 322);
            txtConPass.MaxLength = 32767;
            txtConPass.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtConPass.Name = "txtConPass";
            txtConPass.PasswordChar = '\0';
            txtConPass.PrefixSuffixText = null;
            txtConPass.ReadOnly = false;
            txtConPass.RightToLeft = RightToLeft.No;
            txtConPass.SelectedText = "";
            txtConPass.SelectionLength = 0;
            txtConPass.SelectionStart = 0;
            txtConPass.ShortcutsEnabled = true;
            txtConPass.Size = new Size(300, 48);
            txtConPass.TabIndex = 42;
            txtConPass.TabStop = false;
            txtConPass.TextAlign = HorizontalAlignment.Left;
            txtConPass.TrailingIcon = null;
            txtConPass.UseSystemPasswordChar = false;
            // 
            // rbtnClient
            // 
            rbtnClient.BackColor = Color.Transparent;
            rbtnClient.Background = true;
            rbtnClient.Background_WidthPen = 2F;
            rbtnClient.BackgroundPen = true;
            rbtnClient.Checked = false;
            rbtnClient.Color_1_Background_value = Color.Empty;
            rbtnClient.Color_2_Background_value = Color.Empty;
            rbtnClient.ColorBackground = Color.FromArgb(64, 64, 64);
            rbtnClient.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            rbtnClient.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            rbtnClient.ColorBackground_Pen = Color.White;
            rbtnClient.ColorChecked = Color.FromArgb(255, 128, 0);
            rbtnClient.ColorPen_1 = Color.FromArgb(37, 52, 68);
            rbtnClient.ColorPen_2 = Color.FromArgb(41, 63, 86);
            rbtnClient.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rbtnClient.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            rbtnClient.Effect_1_Transparency = 25;
            rbtnClient.Effect_2 = true;
            rbtnClient.Effect_2_ColorBackground = Color.White;
            rbtnClient.Effect_2_Transparency = 15;
            rbtnClient.Font = new Font("Arial", 9.75F);
            rbtnClient.ForeColor = Color.FromArgb(245, 245, 245);
            rbtnClient.LinearGradient_Background = false;
            rbtnClient.LinearGradient_Value = false;
            rbtnClient.LinearGradientPen = false;
            rbtnClient.Location = new Point(207, 392);
            rbtnClient.Name = "rbtnClient";
            rbtnClient.RGB = false;
            rbtnClient.Rounding = true;
            rbtnClient.RoundingInt = 100;
            rbtnClient.Size = new Size(91, 45);
            rbtnClient.SizeChecked = 8;
            rbtnClient.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbtnClient.TabIndex = 44;
            rbtnClient.Tag = "Cyber";
            rbtnClient.TextButton = "Client";
            rbtnClient.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbtnClient.Timer_Effect_1 = 1;
            rbtnClient.Timer_RGB = 300;
            rbtnClient.Click += rbtnClient_Click;
            // 
            // rbtnProvider
            // 
            rbtnProvider.BackColor = Color.Transparent;
            rbtnProvider.Background = true;
            rbtnProvider.Background_WidthPen = 2F;
            rbtnProvider.BackgroundPen = true;
            rbtnProvider.Checked = false;
            rbtnProvider.Color_1_Background_value = Color.Empty;
            rbtnProvider.Color_2_Background_value = Color.Empty;
            rbtnProvider.ColorBackground = Color.FromArgb(64, 64, 64);
            rbtnProvider.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            rbtnProvider.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            rbtnProvider.ColorBackground_Pen = Color.White;
            rbtnProvider.ColorChecked = Color.FromArgb(255, 128, 0);
            rbtnProvider.ColorPen_1 = Color.FromArgb(37, 52, 68);
            rbtnProvider.ColorPen_2 = Color.FromArgb(41, 63, 86);
            rbtnProvider.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rbtnProvider.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            rbtnProvider.Effect_1_Transparency = 25;
            rbtnProvider.Effect_2 = true;
            rbtnProvider.Effect_2_ColorBackground = Color.White;
            rbtnProvider.Effect_2_Transparency = 15;
            rbtnProvider.Font = new Font("Arial", 9.75F);
            rbtnProvider.ForeColor = Color.FromArgb(245, 245, 245);
            rbtnProvider.LinearGradient_Background = false;
            rbtnProvider.LinearGradient_Value = false;
            rbtnProvider.LinearGradientPen = false;
            rbtnProvider.Location = new Point(298, 392);
            rbtnProvider.Name = "rbtnProvider";
            rbtnProvider.RGB = false;
            rbtnProvider.Rounding = true;
            rbtnProvider.RoundingInt = 100;
            rbtnProvider.Size = new Size(153, 45);
            rbtnProvider.SizeChecked = 8;
            rbtnProvider.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rbtnProvider.TabIndex = 45;
            rbtnProvider.Tag = "Cyber";
            rbtnProvider.TextButton = "Vehicle Provider";
            rbtnProvider.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rbtnProvider.Timer_Effect_1 = 1;
            rbtnProvider.Timer_RGB = 300;
            rbtnProvider.Click += rbtnProvider_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 405);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 46;
            label2.Text = "Role:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrFadeIn
            // 
            tmrFadeIn.Interval = 10;
            tmrFadeIn.Tick += tmrFadeIn_Tick;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.LRNew2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 600);
            Controls.Add(label2);
            Controls.Add(rbtnProvider);
            Controls.Add(rbtnClient);
            Controls.Add(lblConPassError);
            Controls.Add(txtConPass);
            Controls.Add(picBack);
            Controls.Add(picClose);
            Controls.Add(lblPasswordError);
            Controls.Add(lblUsernameError);
            Controls.Add(label1);
            Controls.Add(lblREGISTER);
            Controls.Add(chkShowPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Controls.Add(lblProceed);
            Controls.Add(lblGoToL);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picBack;
        private PictureBox picClose;
        private Label lblPasswordError;
        private Label lblUsernameError;
        private Label label1;
        private Label lblREGISTER;
        private ReaLTaiizor.Controls.CyberCheckBox chkShowPass;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsername;
        private ReaLTaiizor.Controls.MaterialButton btnRegister;
        private Label lblProceed;
        private Label lblGoToL;
        private Label lblConPassError;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtConPass;
        private ReaLTaiizor.Controls.CyberRadioButton rbtnClient;
        private ReaLTaiizor.Controls.CyberRadioButton rbtnProvider;
        private Label label2;
        private System.Windows.Forms.Timer tmrFadeIn;
    }
}