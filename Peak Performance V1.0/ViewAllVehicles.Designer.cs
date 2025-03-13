namespace Peak_Performance_V1._0
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
            grpFilter = new GroupBox();
            btnApply = new Button();
            btnClear = new Button();
            grpSort = new GroupBox();
            rbtnDescending = new RadioButton();
            rbtnAscending = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtSearch = new TextBox();
            pnlExtra = new Panel();
            grpFilter.SuspendLayout();
            grpSort.SuspendLayout();
            pnlExtra.SuspendLayout();
            SuspendLayout();
            // 
            // flpDisplay
            // 
            flpDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpDisplay.AutoScroll = true;
            flpDisplay.Location = new Point(1, 1);
            flpDisplay.Name = "flpDisplay";
            flpDisplay.Size = new Size(700, 752);
            flpDisplay.TabIndex = 0;
            // 
            // grpFilter
            // 
            grpFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpFilter.Controls.Add(btnApply);
            grpFilter.Controls.Add(btnClear);
            grpFilter.Location = new Point(13, 57);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(215, 450);
            grpFilter.TabIndex = 3;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filter";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(134, 410);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(16, 410);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // grpSort
            // 
            grpSort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpSort.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpSort.Controls.Add(rbtnDescending);
            grpSort.Controls.Add(rbtnAscending);
            grpSort.Controls.Add(label1);
            grpSort.Controls.Add(button1);
            grpSort.Controls.Add(button2);
            grpSort.Location = new Point(13, 513);
            grpSort.Name = "grpSort";
            grpSort.Size = new Size(215, 450);
            grpSort.TabIndex = 4;
            grpSort.TabStop = false;
            grpSort.Text = "Sort";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(6, 88);
            label1.Name = "label1";
            label1.Size = new Size(211, 19);
            label1.TabIndex = 2;
            label1.Text = "i reference tong topdrivesrecords";
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
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(13, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(215, 26);
            txtSearch.TabIndex = 2;
            // 
            // pnlExtra
            // 
            pnlExtra.AutoScroll = true;
            pnlExtra.BackColor = Color.FromArgb(35, 40, 60);
            pnlExtra.Controls.Add(txtSearch);
            pnlExtra.Controls.Add(grpFilter);
            pnlExtra.Controls.Add(grpSort);
            pnlExtra.Dock = DockStyle.Right;
            pnlExtra.Location = new Point(707, 0);
            pnlExtra.Name = "pnlExtra";
            pnlExtra.Size = new Size(257, 754);
            pnlExtra.TabIndex = 1;
            // 
            // ViewAllVehicles
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(964, 754);
            Controls.Add(flpDisplay);
            Controls.Add(pnlExtra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewAllVehicles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewAllVehicles";
            grpFilter.ResumeLayout(false);
            grpSort.ResumeLayout(false);
            grpSort.PerformLayout();
            pnlExtra.ResumeLayout(false);
            pnlExtra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpDisplay;
        private GroupBox grpFilter;
        private Button btnApply;
        private Button btnClear;
        private GroupBox grpSort;
        private Button button1;
        private Button button2;
        private RadioButton rbtnDescending;
        private RadioButton rbtnAscending;
        private Label label1;
        private TextBox txtSearch;
        private Panel pnlExtra;
    }
}