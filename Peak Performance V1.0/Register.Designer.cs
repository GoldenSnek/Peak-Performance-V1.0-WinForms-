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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            txtConPass = new TextBox();
            lblConPass = new Label();
            rbtnProvider = new RadioButton();
            rbtnClient = new RadioButton();
            lblGoToL = new Label();
            lblProceed = new Label();
            btnRegister = new Button();
            chkShowPass = new CheckBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(226, 157);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 26);
            txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(226, 79);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 26);
            txtUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(226, 135);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 19);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(226, 57);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 19);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // txtConPass
            // 
            txtConPass.Location = new Point(226, 230);
            txtConPass.Name = "txtConPass";
            txtConPass.Size = new Size(100, 26);
            txtConPass.TabIndex = 9;
            // 
            // lblConPass
            // 
            lblConPass.AutoSize = true;
            lblConPass.Location = new Point(226, 208);
            lblConPass.Name = "lblConPass";
            lblConPass.Size = new Size(120, 19);
            lblConPass.TabIndex = 8;
            lblConPass.Text = "Confirm Password";
            // 
            // rbtnProvider
            // 
            rbtnProvider.AutoSize = true;
            rbtnProvider.Location = new Point(173, 341);
            rbtnProvider.Name = "rbtnProvider";
            rbtnProvider.Size = new Size(124, 23);
            rbtnProvider.TabIndex = 11;
            rbtnProvider.TabStop = true;
            rbtnProvider.Text = "Vehicle Provider";
            rbtnProvider.UseVisualStyleBackColor = true;
            // 
            // rbtnClient
            // 
            rbtnClient.AutoSize = true;
            rbtnClient.Location = new Point(303, 341);
            rbtnClient.Name = "rbtnClient";
            rbtnClient.Size = new Size(62, 23);
            rbtnClient.TabIndex = 12;
            rbtnClient.TabStop = true;
            rbtnClient.Text = "Client";
            rbtnClient.UseVisualStyleBackColor = true;
            // 
            // lblGoToL
            // 
            lblGoToL.AutoSize = true;
            lblGoToL.Location = new Point(226, 509);
            lblGoToL.Name = "lblGoToL";
            lblGoToL.Size = new Size(113, 19);
            lblGoToL.TabIndex = 13;
            lblGoToL.Text = "Proceed to Login";
            lblGoToL.Click += lblGoToL_Click;
            // 
            // lblProceed
            // 
            lblProceed.AutoSize = true;
            lblProceed.Location = new Point(200, 480);
            lblProceed.Name = "lblProceed";
            lblProceed.Size = new Size(165, 19);
            lblProceed.TabIndex = 14;
            lblProceed.Text = "Already have an account?";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(251, 406);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 36);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Location = new Point(303, 271);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(123, 23);
            chkShowPass.TabIndex = 18;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 561);
            Controls.Add(chkShowPass);
            Controls.Add(btnRegister);
            Controls.Add(lblProceed);
            Controls.Add(lblGoToL);
            Controls.Add(rbtnClient);
            Controls.Add(rbtnProvider);
            Controls.Add(txtConPass);
            Controls.Add(lblConPass);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtConPass;
        private Label lblConPass;
        private RadioButton rbtnProvider;
        private RadioButton rbtnClient;
        private Label lblGoToL;
        private Label lblProceed;
        private Button btnRegister;
        private CheckBox chkShowPass;
    }
}