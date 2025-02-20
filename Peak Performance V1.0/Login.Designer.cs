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
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblGoToR = new Label();
            lblProceed = new Label();
            btnLogin = new Button();
            chkShowPass = new CheckBox();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(189, 97);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(193, 217);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 19);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(189, 119);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 26);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 253);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 26);
            txtPassword.TabIndex = 3;
            // 
            // lblGoToR
            // 
            lblGoToR.AutoSize = true;
            lblGoToR.Location = new Point(189, 508);
            lblGoToR.Name = "lblGoToR";
            lblGoToR.Size = new Size(122, 19);
            lblGoToR.TabIndex = 4;
            lblGoToR.Text = "Create an Account";
            lblGoToR.Click += lblGoToR_Click;
            // 
            // lblProceed
            // 
            lblProceed.AutoSize = true;
            lblProceed.Location = new Point(161, 479);
            lblProceed.Name = "lblProceed";
            lblProceed.Size = new Size(176, 19);
            lblProceed.TabIndex = 15;
            lblProceed.Text = "Don't have an account yet?";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(253, 362);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 36);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Location = new Point(253, 301);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(123, 23);
            chkShowPass.TabIndex = 17;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 561);
            Controls.Add(chkShowPass);
            Controls.Add(btnLogin);
            Controls.Add(lblProceed);
            Controls.Add(lblGoToR);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblGoToR;
        private Label lblProceed;
        private Button btnLogin;
        private CheckBox chkShowPass;
    }
}