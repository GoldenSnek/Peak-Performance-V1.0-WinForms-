﻿namespace Peak_Performance_V1._0
{
    partial class ErrorMessage
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
            pnlTop = new Panel();
            btnRefresh = new Button();
            picBack = new PictureBox();
            lblDay = new Label();
            picMin = new PictureBox();
            lblTime = new Label();
            lblDate = new Label();
            picMax = new PictureBox();
            lblPrompt = new Label();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMax).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(255, 128, 0);
            pnlTop.Controls.Add(btnRefresh);
            pnlTop.Controls.Add(picBack);
            pnlTop.Controls.Add(lblDay);
            pnlTop.Controls.Add(picMin);
            pnlTop.Controls.Add(lblTime);
            pnlTop.Controls.Add(lblDate);
            pnlTop.Controls.Add(picMax);
            pnlTop.Cursor = Cursors.Hand;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(350, 30);
            pnlTop.TabIndex = 61;
            pnlTop.MouseDown += pnlTop_MouseDown;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderColor = Color.Cyan;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(890, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 32);
            btnRefresh.TabIndex = 73;
            btnRefresh.Text = "Refresh Map";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // picBack
            // 
            picBack.BackColor = Color.Transparent;
            picBack.BackgroundImage = Properties.Resources.Close2;
            picBack.BackgroundImageLayout = ImageLayout.Stretch;
            picBack.Cursor = Cursors.Hand;
            picBack.Location = new Point(322, 3);
            picBack.Name = "picBack";
            picBack.Size = new Size(25, 25);
            picBack.TabIndex = 41;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // lblDay
            // 
            lblDay.Anchor = AnchorStyles.Left;
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.Transparent;
            lblDay.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblDay.ForeColor = Color.Black;
            lblDay.Location = new Point(246, -101);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(87, 23);
            lblDay.TabIndex = 38;
            lblDay.Text = "Placeholder";
            lblDay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMin
            // 
            picMin.Anchor = AnchorStyles.Right;
            picMin.BackColor = Color.Transparent;
            picMin.BackgroundImage = Properties.Resources.Minimize;
            picMin.BackgroundImageLayout = ImageLayout.Stretch;
            picMin.Cursor = Cursors.Hand;
            picMin.Location = new Point(2640, -102);
            picMin.Name = "picMin";
            picMin.Size = new Size(25, 25);
            picMin.TabIndex = 40;
            picMin.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(39, -101);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(72, 23);
            lblTime.TabIndex = 36;
            lblTime.Text = "00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(118, -101);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(87, 23);
            lblDate.TabIndex = 37;
            lblDate.Text = "Placeholder";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMax
            // 
            picMax.Anchor = AnchorStyles.Right;
            picMax.BackColor = Color.Transparent;
            picMax.BackgroundImage = Properties.Resources.Maximize;
            picMax.BackgroundImageLayout = ImageLayout.Stretch;
            picMax.Cursor = Cursors.Hand;
            picMax.Location = new Point(2680, -102);
            picMax.Name = "picMax";
            picMax.Size = new Size(25, 25);
            picMax.TabIndex = 39;
            picMax.TabStop = false;
            // 
            // lblPrompt
            // 
            lblPrompt.BackColor = Color.Transparent;
            lblPrompt.FlatStyle = FlatStyle.Flat;
            lblPrompt.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrompt.ForeColor = Color.Black;
            lblPrompt.Location = new Point(12, 44);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(326, 116);
            lblPrompt.TabIndex = 62;
            lblPrompt.Text = "hello";
            lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ErrorMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 200);
            Controls.Add(lblPrompt);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ErrorMessage";
            Text = "ErrorMessage";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Button btnRefresh;
        private PictureBox picBack;
        private Label lblDay;
        private PictureBox picMin;
        private Label lblTime;
        private Label lblDate;
        private PictureBox picMax;
        private Label lblPrompt;
    }
}