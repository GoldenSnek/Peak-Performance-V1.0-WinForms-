namespace Peak_Performance_V1._0
{
    partial class AdminAllUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvData = new DataGridView();
            btnRemove = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToResizeColumns = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvData.BackgroundColor = Color.FromArgb(35, 40, 60);
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 40, 50);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            dgvData.GridColor = Color.FromArgb(255, 128, 0);
            dgvData.Location = new Point(0, 0);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowTemplate.Height = 40;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(964, 600);
            dgvData.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRemove.AutoSize = false;
            btnRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemove.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemove.Depth = 0;
            btnRemove.HighEmphasis = true;
            btnRemove.Icon = null;
            btnRemove.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRemove.Location = new Point(334, 635);
            btnRemove.Margin = new Padding(4, 6, 4, 6);
            btnRemove.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRemove.Name = "btnRemove";
            btnRemove.NoAccentTextColor = Color.Empty;
            btnRemove.Size = new Size(297, 36);
            btnRemove.TabIndex = 47;
            btnRemove.Text = "Remove user and all their vehicles";
            btnRemove.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemove.UseAccentColor = false;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // AdminAllUsers
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(964, 704);
            Controls.Add(btnRemove);
            Controls.Add(dgvData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAllUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminAllUsers";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private ReaLTaiizor.Controls.MaterialButton btnRemove;
    }
}