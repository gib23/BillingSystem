using Billing_System.Utils;
using BillingSystem.Database;
using BillingSystem.Utils;
using MySql.Data.MySqlClient;
using ScottPlot.MultiplotLayouts;
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
    public partial class UserManagement : Form
    {
        private int _selectedUser = 0;
        private DataTable _dtUsers;
        public UserManagement()
        {
            InitializeComponent();
        }


        //METHODS
        private void LoadUsers()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT 
                                    UserID,
                                    Username,
                                    FullName,
                                    Role, 
                                    Status,
                                    CreatedAt
                                FROM users
                                ORDER BY FullName ASC";
                    using (var adapter = new MySqlDataAdapter(sql, conn))
                    {
                        _dtUsers = new DataTable();
                        adapter.Fill(_dtUsers);

                        ApplyUserFilter();

                        //dgvUsers.DataSource = _dtUsers;

                        if (dgvUsers.Rows.Count > 0)
                        {
                            dgvUsers.Columns["UserID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvUsers.Columns["Username"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvUsers.Columns["FullName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvUsers.Columns["Role"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvUsers.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvUsers.Columns["CreatedAt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ApplyUserFilter()
        {
            // Safety check in case the database hasn't been loaded yet
            if (_dtUsers == null) return;

            // Get the default view of our cached memory table
            DataView dv = _dtUsers.DefaultView;

            if (chkDisabled.Checked)
            {
                // Clear filter to show everyone (Active, Disabled, Pending, etc.)
                dv.RowFilter = string.Empty;
            }
            else
            {
                // Filter out disabled users. 
                // NOTE: Adjust 'Active' to whatever string your MySQL database uses for active users (e.g., '1', 'True', 'Active')
                dv.RowFilter = "Status = 1";
            }

            // Bind the filtered view to your grid
            dgvUsers.DataSource = dv;
        }

        //EVENTS
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUser addUserForm = new frmUser();
            addUserForm.FormClosed += (s, args) => LoadUsers(); // Refresh the user list when the form is closed
            addUserForm.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(_selectedUser == 0)
            {
                MessageBox.Show("Please select a user to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmUser addUserForm = new frmUser(_selectedUser);
            addUserForm.FormClosed += (s, args) => LoadUsers(); // Refresh the user list when the form is closed
            addUserForm.ShowDialog(this);
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            // If no row is selected (e.g., grid is empty), do nothing
            if (dgvUsers.CurrentRow == null) return;

            // Read the CustomerID value from the selected row
            var idCell = dgvUsers.CurrentRow.Cells["UserID"].Value;
            //MessageBox.Show($"Selected UserID: {idCell}"); // Debugging line to show the selected UserID

            if (idCell != null && int.TryParse(idCell.ToString(), out int id))
            {
                _selectedUser = id;
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if(dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to disable.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedUser == AppSession.CurrentUserID)
            {
                MessageBox.Show("You cannot disable your own account.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if(Convert.ToInt32(dgvUsers.CurrentRow.Cells["Status"].Value) == 0)
            {
                DialogResult result = MessageBox.Show($"User '{dgvUsers.CurrentRow.Cells["Username"].Value.ToString()}'is already disabled. \nDo you want to activate this account?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = DatabaseConnection.GetConnection())
                        {
                            conn.Open();
                            string sql = "UPDATE users SET Status = 1 WHERE UserID = @UserID";

                            using (var cmd = new MySqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@UserID", _selectedUser);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("User reactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    AuditLogger.Log("REACTIVATE_USER", $"User ID {_selectedUser} reactivated by {AppSession.CurrentUsername}.");

                                    LoadUsers(); // Refresh the DataGridView after disabling the user
                                    _selectedUser = 0;
                                }
                                else
                                {
                                    MessageBox.Show("No user was disabled. Please ensure a user is selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                return;
            }
            if (MessageBox.Show($"Are you sure you want to disable {dgvUsers.CurrentRow.Cells["Username"].Value.ToString()}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        string sql = "UPDATE users SET Status = 0 WHERE UserID = @UserID";

                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", _selectedUser);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User disabled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AuditLogger.Log("DISABLE_USER", $"User ID {_selectedUser} disabled by {AppSession.CurrentUsername}.");

                                LoadUsers(); // Refresh the DataGridView after disabling the user
                                _selectedUser = 0;
                            }
                            else
                            {
                                MessageBox.Show("No user was disabled. Please ensure a user is selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkDisabled_CheckedChanged(object sender, EventArgs e)
        {
            ApplyUserFilter();
        }
    }
}
