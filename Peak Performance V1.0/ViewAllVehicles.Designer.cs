﻿namespace Peak_Performance_V1._0
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            grpFilter = new GroupBox();
            btnClear = new Button();
            btnApply = new Button();
            grpSort = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            rbtnAscending = new RadioButton();
            rbtnDescending = new RadioButton();
            label1 = new Label();
            grpFilter.SuspendLayout();
            grpSort.SuspendLayout();
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
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(948, 33);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(49, 19);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(948, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 26);
            txtSearch.TabIndex = 2;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(btnApply);
            grpFilter.Controls.Add(btnClear);
            grpFilter.Location = new Point(948, 109);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(200, 420);
            grpFilter.TabIndex = 3;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(6, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(110, 379);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // grpSort
            // 
            grpSort.Controls.Add(rbtnDescending);
            grpSort.Controls.Add(rbtnAscending);
            grpSort.Controls.Add(label1);
            grpSort.Controls.Add(button1);
            grpSort.Controls.Add(button2);
            grpSort.Location = new Point(948, 535);
            grpSort.Name = "grpSort";
            grpSort.Size = new Size(200, 156);
            grpSort.TabIndex = 4;
            grpSort.TabStop = false;
            grpSort.Text = "Sort";
            // 
            // button1
            // 
            button1.Location = new Point(110, 379);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 379);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // rbtnAscending
            // 
            rbtnAscending.AutoSize = true;
            rbtnAscending.Location = new Point(59, 53);
            rbtnAscending.Name = "rbtnAscending";
            rbtnAscending.Size = new Size(90, 23);
            rbtnAscending.TabIndex = 3;
            rbtnAscending.TabStop = true;
            rbtnAscending.Text = "Ascending";
            rbtnAscending.UseVisualStyleBackColor = true;
            // 
            // rbtnDescending
            // 
            rbtnDescending.AutoSize = true;
            rbtnDescending.Location = new Point(59, 110);
            rbtnDescending.Name = "rbtnDescending";
            rbtnDescending.Size = new Size(98, 23);
            rbtnDescending.TabIndex = 4;
            rbtnDescending.TabStop = true;
            rbtnDescending.Text = "Descending";
            rbtnDescending.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 88);
            label1.Name = "label1";
            label1.Size = new Size(211, 19);
            label1.TabIndex = 2;
            label1.Text = "i reference tong topdrivesrecords";
            // 
            // ViewAllVehicles
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1184, 761);
            Controls.Add(grpSort);
            Controls.Add(grpFilter);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(flpDisplay);
            Name = "ViewAllVehicles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewAllVehicles";
            grpFilter.ResumeLayout(false);
            grpSort.ResumeLayout(false);
            grpSort.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpDisplay;
        private Label lblSearch;
        private TextBox txtSearch;
        private GroupBox grpFilter;
        private Button btnApply;
        private Button btnClear;
        private GroupBox grpSort;
        private Button button1;
        private Button button2;
        private RadioButton rbtnDescending;
        private RadioButton rbtnAscending;
        private Label label1;
    }
}