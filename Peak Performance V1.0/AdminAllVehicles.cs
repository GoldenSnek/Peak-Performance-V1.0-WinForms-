using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peak_Performance_V1._0
{
    public partial class AdminAllVehicles : Form
    {
        private OleDbConnection connection;
        public AdminAllVehicles()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadData();
        }

        private void LoadData() //INITIAL EVENT: Load database to datagridview
        {
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;  // Background color
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;      // Text color
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Copperplate Gothic", 12, FontStyle.Bold); // Font style
            dgvData.RowHeadersDefaultCellStyle.BackColor = Color.Black;  // Background color
            dgvData.RowHeadersDefaultCellStyle.ForeColor = Color.Orange;      // Text color
            dgvData.RowHeadersDefaultCellStyle.Font = new Font("Copperplate Gothic", 12, FontStyle.Bold); // Font style

            string query = "SELECT * FROM Vehicles";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvData.DataSource = dt;

            dgvData.Columns[14].Visible = false;
        }
    }
}
