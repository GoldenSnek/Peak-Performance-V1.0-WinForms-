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
            pnlExtra = new Panel();
            txtSearch = new ReaLTaiizor.Controls.ForeverTextBox();
            grpSort = new ReaLTaiizor.Controls.ParrotGroupBox();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            grpFilter = new ReaLTaiizor.Controls.ParrotGroupBox();
            btnApply = new ReaLTaiizor.Controls.MaterialButton();
            btnClear = new ReaLTaiizor.Controls.MaterialButton();
            pnlExtra.SuspendLayout();
            grpSort.SuspendLayout();
            grpFilter.SuspendLayout();
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
            // pnlExtra
            // 
            pnlExtra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlExtra.AutoScroll = true;
            pnlExtra.BackColor = Color.FromArgb(35, 40, 60);
            pnlExtra.Controls.Add(txtSearch);
            pnlExtra.Controls.Add(grpSort);
            pnlExtra.Controls.Add(grpFilter);
            pnlExtra.Location = new Point(707, 0);
            pnlExtra.Name = "pnlExtra";
            pnlExtra.Size = new Size(257, 754);
            pnlExtra.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BaseColor = Color.FromArgb(255, 224, 192);
            txtSearch.BorderColor = Color.FromArgb(255, 128, 0);
            txtSearch.FocusOnHover = false;
            txtSearch.Font = new Font("Arial Rounded MT Bold", 12F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(13, 12);
            txtSearch.MaxLength = 32767;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.ReadOnly = false;
            txtSearch.Size = new Size(215, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.UseSystemPasswordChar = false;
            // 
            // grpSort
            // 
            grpSort.BorderColor = Color.FromArgb(255, 128, 0);
            grpSort.BorderWidth = 1;
            grpSort.Controls.Add(materialButton1);
            grpSort.Controls.Add(materialButton2);
            grpSort.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSort.Location = new Point(13, 514);
            grpSort.Name = "grpSort";
            grpSort.ShowText = true;
            grpSort.Size = new Size(215, 450);
            grpSort.TabIndex = 1;
            grpSort.TabStop = false;
            grpSort.Text = "Sort";
            grpSort.TextColor = Color.White;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(133, 404);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(75, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Apply";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton2.Location = new Point(7, 404);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(75, 36);
            materialButton2.TabIndex = 2;
            materialButton2.Text = "Clear";
            materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // grpFilter
            // 
            grpFilter.BorderColor = Color.FromArgb(255, 128, 0);
            grpFilter.BorderWidth = 1;
            grpFilter.Controls.Add(btnApply);
            grpFilter.Controls.Add(btnClear);
            grpFilter.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpFilter.Location = new Point(13, 58);
            grpFilter.Name = "grpFilter";
            grpFilter.ShowText = true;
            grpFilter.Size = new Size(215, 450);
            grpFilter.TabIndex = 0;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filters";
            grpFilter.TextColor = Color.White;
            // 
            // btnApply
            // 
            btnApply.AutoSize = false;
            btnApply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApply.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnApply.Depth = 0;
            btnApply.HighEmphasis = true;
            btnApply.Icon = null;
            btnApply.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnApply.Location = new Point(133, 404);
            btnApply.Margin = new Padding(4, 6, 4, 6);
            btnApply.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnApply.Name = "btnApply";
            btnApply.NoAccentTextColor = Color.Empty;
            btnApply.Size = new Size(75, 36);
            btnApply.TabIndex = 3;
            btnApply.Text = "Apply";
            btnApply.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnApply.UseAccentColor = false;
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = false;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnClear.Location = new Point(7, 404);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(75, 36);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
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
            pnlExtra.ResumeLayout(false);
            grpSort.ResumeLayout(false);
            grpSort.PerformLayout();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpDisplay;
        private Button button1;
        private Button button2;
        private RadioButton rbtnDescending;
        private RadioButton rbtnAscending;
        private Label label1;
        private Panel pnlExtra;
        private ReaLTaiizor.Controls.ParrotGroupBox grpFilter;
        private ReaLTaiizor.Controls.MaterialButton btnApply;
        private ReaLTaiizor.Controls.MaterialButton btnClear;
        private ReaLTaiizor.Controls.ParrotGroupBox grpSort;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.ForeverTextBox txtSearch;
    }
}