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
            dgvData.Columns[12].Visible = false;
            dgvData.Columns[13].Visible = false;
            dgvData.Columns[14].Visible = false;
        }

        public void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                using (ErrorMessage errorForm = new ErrorMessage($"Please select an account to remove"))
                {
                    errorForm.ShowDialog();
                }
                return;
            }

            string verifyQuery = "SELECT ClientID, OwnerID FROM RentalDetails";
            using (OleDbCommand cmd = new OleDbCommand(verifyQuery, connection))
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int clientID = Convert.ToInt32(reader["ClientID"]);
                    int ownerID = Convert.ToInt32(reader["OwnerID"]);
                    if (Convert.ToInt32(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value) == clientID || Convert.ToInt32(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value) == ownerID)
                    {
                        using (ErrorMessage errorForm = new ErrorMessage($"You cannot deactivate this account as they currently have a rental process in progress."))
                        {
                            errorForm.ShowDialog();
                        }
                        connection.Close();
                        return;
                    }
                }
                connection.Close();
            }

            string deleteVehiclesQuery = "DELETE FROM Vehicles WHERE OwnerID = @userID";
            string deleteUserQuery = "DELETE FROM Users WHERE UserID = @userID";

            if (Convert.ToInt32(dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value) == 1)
            {
                using (ErrorMessage errorForm = new ErrorMessage($"You cannot deactivate the admin account!"))
                {
                    errorForm.ShowDialog();
                }
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

                    using (ErrorMessage errorForm = new ErrorMessage($"User and associated vehicles are removed successfully!"))
                    {
                        errorForm.ShowDialog();
                    }

                    LoadData();
                }
                catch (Exception ex)
                {
                    using (ErrorMessage errorForm = new ErrorMessage($"Error removing: {ex.Message}"))
                    {
                        errorForm.ShowDialog();
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
