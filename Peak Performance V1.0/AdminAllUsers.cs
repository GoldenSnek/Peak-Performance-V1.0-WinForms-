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

            dgvData.Columns[2].Visible = false;
            dgvData.Columns[10].Visible = false;
            dgvData.Columns[13].Visible = false;
            dgvData.Columns[14].Visible = false;
        }

        public void btnRemove_Click(object sender, EventArgs e)
        {
            string deleteVehiclesQuery = "DELETE FROM Vehicles WHERE OwnerID = @userID";
            string deleteUserQuery = "DELETE FROM Users WHERE UserID = @userID";


            if (Convert.ToInt32(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value) == 1)
            {
                MessageBox.Show("You cannot delete the admin account!", "NO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (OleDbCommand cmd = new OleDbCommand(deleteVehiclesQuery, connection))
            {
                cmd.Parameters.AddWithValue("@userID", Convert.ToInt32(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value)); 

                try
                {
                    connection.Open();

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = deleteUserQuery;
                    cmd.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("User and associated vehicles removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();  // Reload the data after deletion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
