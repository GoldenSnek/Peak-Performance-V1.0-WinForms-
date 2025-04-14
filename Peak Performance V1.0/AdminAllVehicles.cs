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
    public partial class AdminAllVehicles : Form, IAdminAllVehicles
    {
        private OleDbConnection connection;
        public AdminAllVehicles()
        {
            connection = SystemManager.GetConnection();
            InitializeComponent();
            LoadData();
        }

        public void LoadData() //METHOD: Load database to datagridview
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

            dgvData.Columns[17].Visible = false;
            dgvData.Columns[20].Visible = false;
            dgvData.Columns[21].Visible = false;
        }

        public void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                using (ErrorMessage errorForm = new ErrorMessage($"Please select a vehicle to delete"))
                {
                    errorForm.ShowDialog();
                }
                return;
            }

            string verifyQuery = "SELECT VehicleID FROM RentalDetails";
            using (OleDbCommand cmd = new OleDbCommand(verifyQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int vehicleID = Convert.ToInt32(reader["VehicleID"]);
                    if (Convert.ToInt32(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value) == vehicleID)
                    {
                        using (ErrorMessage errorForm = new ErrorMessage($"You cannot remove this vehicle as it is currently being rented."))
                        {
                            errorForm.ShowDialog();
                        }
                        connection.Close();
                        return;
                    }
                }
                connection.Close();
            }

            string deleteQuery = "DELETE FROM Vehicles WHERE VehicleID = @vehicleID";
            using (OleDbCommand cmd = new OleDbCommand(deleteQuery, connection))
            {
                cmd.Parameters.AddWithValue("@vehicleID", Convert.ToInt32(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value));

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    using (ErrorMessage errorForm = new ErrorMessage($"Vehicle removed successfully!"))
                    {
                        errorForm.ShowDialog();
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    using (ErrorMessage errorForm = new ErrorMessage($"Error deleting: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                    return;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
