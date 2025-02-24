namespace Peak_Performance_V1._0
{
    partial class ManageAccount
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
            picProfilePicture = new PictureBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblUsername = new Label();
            lblRole = new Label();
            lblUserID = new Label();
            lblEmail = new Label();
            lblNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)picProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // picProfilePicture
            // 
            picProfilePicture.Location = new Point(519, 85);
            picProfilePicture.Name = "picProfilePicture";
            picProfilePicture.Size = new Size(158, 152);
            picProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfilePicture.TabIndex = 0;
            picProfilePicture.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(789, 637);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(950, 637);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Account";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(621, 637);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(561, 268);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(71, 19);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(712, 268);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(35, 19);
            lblRole.TabIndex = 5;
            lblRole.Text = "Role";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(438, 268);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(55, 19);
            lblUserID.TabIndex = 6;
            lblUserID.Text = "User ID";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(206, 408);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(94, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email Address";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(189, 479);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(111, 19);
            lblNumber.TabIndex = 8;
            lblNumber.Text = "Contact Number";
            // 
            // ManageAccount
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1184, 761);
            Controls.Add(lblNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblUserID);
            Controls.Add(lblRole);
            Controls.Add(lblUsername);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(picProfilePicture);
            Name = "ManageAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Account";
            ((System.ComponentModel.ISupportInitialize)picProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProfilePicture;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;
        private Label lblUsername;
        private Label lblRole;
        private Label lblUserID;
        private Label lblEmail;
        private Label lblNumber;
    }
}