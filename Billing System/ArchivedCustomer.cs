using Billing_System.Utils;
using BillingSystem.Database;
using BillingSystem.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class ArchivedCustomer : Form
    {
        private static int _selectedCustomerId = 0;
        public ArchivedCustomer()
        {
            InitializeComponent();
        }
        //METHODS
        private void LoadCustomers()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT CustomerID, FullName, Address, Status
                                   FROM   customers
                                   WHERE  isarchive = 1
                                   ORDER  BY FullName ASC;";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvArchivedCustomers.DataSource = dt;

                            if (dgvArchivedCustomers.Columns.Count > 0)
                            {
                                dgvArchivedCustomers.Columns["CustomerID"].HeaderText = "ID";
                                dgvArchivedCustomers.Columns["CustomerID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                                dgvArchivedCustomers.Columns["FullName"].HeaderText = "Full Name";
                                dgvArchivedCustomers.Columns["FullName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                                dgvArchivedCustomers.Columns["Address"].HeaderText = "Address";
                                dgvArchivedCustomers.Columns["Address"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                                //dgvArchivedCustomers.Columns["Email"].HeaderText = "Email";
                                //dgvArchivedCustomers.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                                //dgvArchivedCustomers.Columns["ContactNumber"].HeaderText = "Contact No.";
                                //dgvArchivedCustomers.Columns["ContactNumber"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                                //dgvArchivedCustomers.Columns["Balance"].HeaderText = "Balance (₱)";
                                //dgvArchivedCustomers.Columns["Balance"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                //dgvArchivedCustomers.Columns["Balance"].DefaultCellStyle.Format = "N2";  // Format as number with 2 decimal places
                                //dgvArchivedCustomers.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                                dgvArchivedCustomers.Columns["Status"].HeaderText = "Status";
                                dgvArchivedCustomers.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            }
                            if(dgvArchivedCustomers.Rows.Count == 0)
                            {
                                MessageBox.Show("Customers archived is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                            lblTitle.Text =
                                $"ARCHIVED CUSTOMERS - ({dt.Rows.Count} record(s))";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading archived customers:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //EVENTS
        private void unarchivedCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_selectedCustomerId == 0 || dgvArchivedCustomers.Rows.Count == 0)
            {
                MessageBox.Show("Please select a customer to unarchive.",
                    "No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   

            DialogResult result = MessageBox.Show(
               $"Unarchive {dgvArchivedCustomers.CurrentRow.Cells["FullName"].Value.ToString()}?",
               "Confirm Archive",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        string sql = @"UPDATE Customers
                                   SET isarchive = 0
                                   WHERE CustomerID = @CustomerID;";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", _selectedCustomerId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer unarchived successfully.",
                                    "Unarchived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AuditLogger.Log("UNARCHIVE_CUSTOMER", $"Customer ID {_selectedCustomerId} unarchived by {AppSession.CurrentUsername}.");

                                LoadCustomers();
                            }
                            else
                            {
                                MessageBox.Show("Customer could not be unarchived. It may no longer exist.",
                                    "Unarchive Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error unarchiving customer:\n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvArchivedCustomers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Clear any rows the user had previously highlighted
                dgvArchivedCustomers.ClearSelection();

                // Simultaneously select the row that was just right-clicked
                dgvArchivedCustomers.Rows[e.RowIndex].Selected = true;

                // (Optional) Move the active cell focus to the clicked cell
                dgvArchivedCustomers.CurrentCell = dgvArchivedCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Now show your context menu exactly where the mouse is
                cmsUnarchived.Show(Cursor.Position);
            }
        }

        private void dgvArchivedCustomers_SelectionChanged(object sender, EventArgs e)
        {
            // If no row is selected (e.g., grid is empty), do nothing
            if (dgvArchivedCustomers.CurrentRow == null) { _selectedCustomerId = 0; return; }

            // Read the CustomerID value from the selected row
            var idCell = dgvArchivedCustomers.CurrentRow.Cells["CustomerID"].Value;

            if (idCell != null && int.TryParse(idCell.ToString(), out int id))
            {
                _selectedCustomerId = id;
            }
        }

        private void ArchivedCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
