using Billing_System.Utils;
using BillingSystem.Database;
using BillingSystem.Utils;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class frmUser : Form
    {
        private int _selectedUser = 0;
        public frmUser()
        {
            InitializeComponent();
        }
        public frmUser(int userid)
        {
            InitializeComponent();
            _selectedUser = userid;
        }
        //METHODS
        private bool ValidatePass()
        {
            string password = txtPass.Text;

            bool hasMinL = password.Length >= 8;
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpec = Regex.IsMatch(password, @"[^a-zA-Z0-9]");

            lblHasMin.ForeColor = hasMinL ? Color.Green : Color.Red;
            lblHasUpper.ForeColor = hasUpper ? Color.Green : Color.Red;
            lblHasLower.ForeColor = hasLower ? Color.Green : Color.Red;
            lblHasDig.ForeColor = hasDigit ? Color.Green : Color.Red;
            lblHasSpec.ForeColor = hasSpec ? Color.Green : Color.Red;

            bool isValid = hasMinL && hasUpper && hasLower && hasDigit && hasSpec;

            if (isValid)
            {
                lblCkNew.Text = "Password is Valid";
                return true;
            }
            return false;
        }
        private bool ValidatePassMatch()
        {
            if (txtConfirm.Text == "")
            {
                lblCkRetype.Text = "Retype your password";
                return false;
            }
            if (txtConfirm.Text == txtPass.Text)
            {
                txtConfirm.BackColor = Color.LightGreen;
                lblCkRetype.Text = "Password Match";

                return true;
            }
            else
            {
                txtConfirm.BackColor = Color.Pink;
                lblCkRetype.Text = "Password Not Match";

                return false;
            }
        }
        private bool ValidateFields()
        {
            if(string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Username is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Role is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return false;
            }

            return true;
        }
        private void LoadUser(int uid)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT 
                                    UserID,
                                    Username,
                                    Password,
                                    FullName,
                                    Role, 
                                    Status
                                FROM users
                                WHERE UserID = @UserID";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", uid);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUser.Text = reader["Username"].ToString();
                                txtFullName.Text = reader["FullName"].ToString();
                                txtPass.Text = reader["Password"].ToString(); // Passwords should not be loaded for security reasons
                                txtConfirm.Text = reader["Password"].ToString();
                                cmbRole.SelectedItem = reader["Role"].ToString();
                                chkStatus.Checked = Convert.ToBoolean(reader["Status"]);
                            }
                            else
                            {
                                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch
            (Exception ex)
            {
                MessageBox.Show($"Error loading user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txtUser.Clear();
            txtPass.Clear();
            txtConfirm.Clear();
            txtFullName.Clear();
            cmbRole.SelectedIndex = -1;
            chkStatus.Checked = false;
            lblCkNew.Text = "";
            lblCkRetype.Text = "";

            lblHasDig.ForeColor = SystemColors.ControlText;
            lblHasLower.ForeColor = SystemColors.ControlText;
            lblHasMin.ForeColor = SystemColors.ControlText;
            lblHasSpec.ForeColor = SystemColors.ControlText;
            lblHasUpper.ForeColor = SystemColors.ControlText;

            txtPass.BackColor = Color.Empty;
            txtConfirm.BackColor = Color.Empty;
        }
        private void InsertUser()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized INSERT — safe from SQL injection
                    string sql = @"INSERT INTO users
                               (Username, Password, FullName, Role, Status)
                           VALUES
                               (@Username, @Password, @FullName, @Role, @Status);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        // Each @parameter safely carries one value from the form
                        cmd.Parameters.AddWithValue("@Username", txtUser.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", cmbRole.Text.Trim());
                        cmd.Parameters.AddWithValue("@Status", chkStatus.Checked ? 1 : 0);

                        // ExecuteNonQuery runs INSERT/UPDATE/DELETE and
                        // returns the number of rows affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User saved successfully.",
                                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AuditLogger.Log("ADD_USER", $"New user '{txtFullName.Text.Trim()}' added by {AppSession.CurrentUsername}.");

                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateUser()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE users
                           SET    FullName      = @FullName,
                                  Role          = @Role
                           WHERE  UserID        = @UserID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", cmbRole.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserID", _selectedUser);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.",
                                "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AuditLogger.Log("EDIT_CUSTOMER", $"Customer ID {_selectedUser} updated by {AppSession.CurrentUsername}.");

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. The record may no longer exist.",
                                "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //EVENTS
        private void frmUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "Admin", "Cashier" });

            if (_selectedUser > 0)
            {
                LoadUser(_selectedUser);
                lblTitle.Text = "EDIT USER";
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                txtConfirm.Enabled = false;
                lblCkNew.Text = "";
                lblCkRetype.Text = "";
                chkStatus.Enabled = false;
                btnShow1.Enabled = false;
                btnShow2.Enabled = false;



                label6.Visible = false;
                lblHasDig.Visible = false;
                lblHasLower.Visible = false;
                lblHasMin.Visible = false;
                lblHasSpec.Visible = false;
                lblHasUpper.Visible = false;

                btnSave.Location = new Point(105, 250);

                this.Size = new Size(450, 350);

            }
            else
            {
                this.Size = new Size(450, 450);
                lblTitle.Text = "ADD NEW USER";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            trmShow.Start();

            if (txtPass.PasswordChar == '*')
            {
                btnShow1.BackgroundImage = Properties.Resources.eye_close;
                txtPass.PasswordChar = '\0';
            }
            else
            {
                btnShow1.BackgroundImage = Properties.Resources.eye_open;
                txtPass.PasswordChar = '*';
            }
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            trmShow.Start();

            if (txtConfirm.PasswordChar == '*')
            {
                btnShow2.BackgroundImage = Properties.Resources.eye_close;
                txtConfirm.PasswordChar = '\0';
            }
            else
            {
                btnShow2.BackgroundImage = Properties.Resources.eye_open;
                txtConfirm.PasswordChar = '*';
            }
        }

        private void trmShow_Tick(object sender, EventArgs e)
        {
            trmShow.Stop();

            btnShow1.BackgroundImage = Properties.Resources.eye_open;
            btnShow2.BackgroundImage = Properties.Resources.eye_open;

            txtPass.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            ValidatePass();
            ValidatePassMatch();
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            ValidatePassMatch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidatePass())
            {
                MessageBox.Show("Password does not meet the required criteria.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!ValidatePassMatch())
            {                 
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateFields())
            {
                return;
            }
            if(_selectedUser == 0)
            {
                try
                {
                    using (var conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT EXISTS(SELECT 1 FROM users WHERE Username = @Username);";

                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", txtUser.Text.Trim());
                            int result = Convert.ToInt32(cmd.ExecuteScalar());

                            if (result == 1)
                            {
                                MessageBox.Show("Username already taken. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                InsertUser();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user:\n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (var conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();

                        string sql = @"SELECT COUNT(1) 
                           FROM users 
                           WHERE Role = 'Admin' 
                             AND Status = 1";

                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            int result = Convert.ToInt32(cmd.ExecuteScalar());
                            result += cmbRole.Text == "Admin" ? 1 : 0;

                            if (result < 2)
                            {
                                MessageBox.Show("There must be at least one active Admin user. Please ensure that at least one Admin remains active.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                UpdateUser();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user:\n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
