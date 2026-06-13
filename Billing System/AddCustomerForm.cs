using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;


namespace Billing_System
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Step 1: Validate input before touching the database
            if (!ValidateInputs()) return;

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized INSERT — safe from SQL injection
                    string sql = @"INSERT INTO Customers
                               (FullName, Address, ContactNumber, Email, Balance, Status)
                           VALUES
                               (@FullName, @Address, @ContactNumber, @Email, @Balance, @Status);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        // Each @parameter safely carries one value from the form
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Balance", decimal.Parse(txtBalance.Text));
                        cmd.Parameters.AddWithValue("@Status", "Active");

                        // ExecuteNonQuery runs INSERT/UPDATE/DELETE and
                        // returns the number of rows affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer saved successfully.",
                                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //METHODS AHEAD//
        private bool ValidateInputs()
        {
            // Check Full Name
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            // Check Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            // Check Contact Number
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Contact Number is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return false;
            }

            // Check Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Check Balance is a valid number
            if (!decimal.TryParse(txtBalance.Text, out _))
            {
                MessageBox.Show("Initial Balance must be a valid number (e.g. 0.00).",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBalance.Focus();
                return false;
            }

            return true;
        }
        private void ClearFields()
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtBalance.Text = "0.00";
            txtFullName.Focus();
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            // 1. Always allow control keys (Backspace, Delete, Left/Right Arrows)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // 2. Handle the decimal point
            if (e.KeyChar == '.')
            {
                // Reject if a period already exists
                if (tb.Text.Contains("."))
                {
                    e.Handled = true;
                }
                return;
            }

            // 3. Handle digits (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                // Check if there is already a decimal point in the text
                int decimalIndex = tb.Text.IndexOf('.');
                if (decimalIndex != -1)
                {
                    // Check if the cursor is positioned *after* the decimal point
                    if (tb.SelectionStart > decimalIndex)
                    {
                        // Count how many digits are currently after the decimal point
                        string decimalPart = tb.Text.Substring(decimalIndex + 1);

                        // If there are already 2 digits, and the user hasn't highlighted text to overwrite it
                        if (decimalPart.Length >= 2 && tb.SelectionLength == 0)
                        {
                            e.Handled = true; // Reject the keystroke
                        }
                    }
                }
                return;
            }

            // Reject everything else (letters, symbols, extra periods)
            e.Handled = true;
        }

        private void txtBalance_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            // This prevents the mouse click from clearing the selection 
            // we just made in the Enter event
            if (tb.SelectionLength == 0)
            {
                tb.SelectAll();
            }
        }
    }
}
