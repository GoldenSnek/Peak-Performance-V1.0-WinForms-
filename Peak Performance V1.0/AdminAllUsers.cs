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
    public partial class AdminAllUsers : Form, IAdminAllUsers
    {
        private OleDbConnection connection;
        public AdminAllUsers()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadData();
        }

        public void LoadData() //METHOD: Load database to datagridview
        {
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;  //background color
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;      //text color
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Copperplate Gothic", 12, FontStyle.Bold); //font style
            dgvData.RowHeadersDefaultCellStyle.BackColor = Color.Black;  //background color
            dgvData.RowHeadersDefaultCellStyle.ForeColor = Color.Orange;      //text color
            dgvData.RowHeadersDefaultCellStyle.Font = new Font("Copperplate Gothic", 12, FontStyle.Bold); //font style

            string query = "SELECT * FROM Users";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvData.DataSource = dt;
        }

        public void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
