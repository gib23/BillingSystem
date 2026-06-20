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
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Billing_System
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            Reset();
            lblCkCurrent.Text = "";
            lblCkNew.Text = "";
            lblCkRetype.Text = "";
        }
        private void Reset()
        {
            btnCurrent.BackgroundImage = Properties.Resources.eye_open;
            btnNew.BackgroundImage = Properties.Resources.eye_open;
            btnRetype.BackgroundImage = Properties.Resources.eye_open;

            txtCurrent.PasswordChar = '*';
            txtNewPass.PasswordChar = '*';
            txtRetype.PasswordChar = '*';
        }
        private void btnCurrent_Click(object sender, EventArgs e)
        {
            tmrShow.Start();

            if (txtCurrent.PasswordChar == '*')
            {
                txtCurrent.PasswordChar = '\0';
            }
            else
            {
                txtCurrent.PasswordChar = '*';
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tmrShow.Start();

            if (txtNewPass.PasswordChar == '*')
            {
                txtNewPass.PasswordChar = '\0';
            }
            else
            {
                txtNewPass.PasswordChar = '*';
            }
        }

        private void btnRetype_Click(object sender, EventArgs e)
        {
            tmrShow.Start();
            if (txtRetype.PasswordChar == '*')
            {
                txtRetype.PasswordChar = '\0';
            }
            else
            {
                txtRetype.PasswordChar = '*';
            }
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            tmrShow.Stop();
            Reset();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Any changes will not be saved\nLeave?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check if current pass word is match to database
            DialogResult dialogResult = MessageBox.Show("Sure Ka Na?", "G?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) 
            {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Password FROM billingdb.users WHERE userID = @UserID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", AppSession.CurrentUserID);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            string dbPass = result.ToString();
                            if (txtCurrent.Text == dbPass)
                            {
                                if (ValidatePass() == true && ValidatePassMatch() == true)
                                {
                                    UpdatePass();
                                    ClearFields();
                                }
                            }
                            else
                            {
                                lblCkCurrent.Text = "Reentry Current Password";
                                txtCurrent.Focus();
                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Checking Current Password:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            //else do nothing >//<

        }

        private void txtRetype_TextChanged(object sender, EventArgs e)
        {
            ValidatePassMatch();   
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            ValidatePass();
            ValidatePassMatch();
        }

        private bool ValidatePassMatch()
        {
            if (txtRetype.Text == "")
            {
                return false;
            }
            if (txtRetype.Text == txtNewPass.Text)
            {
                txtRetype.BackColor = Color.LightGreen;
                lblCkRetype.Text = "Password Match";

                return true;
            }
            else
            {
                txtRetype.BackColor = Color.Pink;
                lblCkRetype.Text = "Password Not Match";

                return false;
            }
        }
        private bool ValidatePass()
        {
            string password = txtNewPass.Text;

            bool hasMinL = password.Length >= 8;
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpec = Regex.IsMatch(password, @"[^a-zA-Z0-9]");

            lblHasMin.ForeColor     = hasMinL   ? Color.Green : Color.Red;
            lblHasUpper.ForeColor   = hasUpper  ? Color.Green : Color.Red;
            lblHasLower.ForeColor   = hasLower  ? Color.Green : Color.Red;
            lblHasDig.ForeColor     = hasDigit  ? Color.Green : Color.Red;
            lblHasSpec.ForeColor    = hasSpec   ? Color.Green : Color.Red;

            bool isValid = hasMinL && hasUpper && hasLower && hasDigit && hasSpec;

            if (isValid)
            {
                lblCkNew.Text = "Password is Valid";
                return true;
            }
            return false;
        }
        private void UpdatePass()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE billingdb.users
                           SET    Password      = @Password
                           WHERE  userID        = @userID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", txtNewPass.Text.Trim());
                        cmd.Parameters.AddWithValue("@userID", AppSession.CurrentUserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.",
                                "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Update failed.",
                                "What a Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating password:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txtCurrent.Text = "";
            txtNewPass.Text = "";
            txtRetype.Text = "";
            lblCkCurrent.Text = "";
            lblCkNew.Text = "";
            lblCkRetype.Text = "";
            lblHasDig.ForeColor = SystemColors.ControlText;
            lblHasLower.ForeColor = SystemColors.ControlText;
            lblHasMin.ForeColor = SystemColors.ControlText;
            lblHasSpec.ForeColor = SystemColors.ControlText;
            lblHasUpper.ForeColor = SystemColors.ControlText;
            txtCurrent.BackColor = Color.Empty;
            txtNewPass.BackColor = Color.Empty;
            txtRetype.BackColor = Color.Empty;
        }
    }
}
