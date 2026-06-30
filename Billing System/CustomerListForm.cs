using Billing_System.Utils;
using BillingSystem.Database;
using BillingSystem.Utils;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.Utils;
using System.Runtime.InteropServices;

namespace Billing_System
{
    public partial class CustomerListForm : Form
    {
        // Stores the CustomerID of the currently selected row.
        // 0 means no customer is currently selected.
        private int _selectedCustomerId = 0;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;


        public CustomerListForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog(this);
            LoadCustomers();
        }
        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            LoadCustomers();
            ApplyPermissions();
            InitStatusStrip();
            SendMessage(txtSearch.Handle, EM_SETCUEBANNER, 0, "Search by Name, Address, or Contact No.");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();


            if (string.IsNullOrEmpty(keyword))
            {
                // Empty search box → show all customers again
                LoadCustomers();
            }
            else
            {
                SearchCustomers(keyword);
            }

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                btnSearch_Click(sender, e);
            }

        }
        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            // If no row is selected (e.g., grid is empty), do nothing
            if (dgvCustomers.CurrentRow == null) { _selectedCustomerId = 0; return; }

            // Read the CustomerID value from the selected row
            var idCell = dgvCustomers.CurrentRow.Cells["CustomerID"].Value;

            if (idCell != null && int.TryParse(idCell.ToString(), out int id))
            {
                _selectedCustomerId = id;
            }
        }
        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.RowIndex is -1 when the header row is double-clicked — ignore it
            if (e.RowIndex < 0) return;

            OpenEditForm();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Step 1: Make sure a customer is selected
            if (_selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 2: Confirm before deleting — this cannot be undone
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this customer?\n" +
                "All billing records for this customer will also be deleted.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Step 3: Only delete if the user clicked Yes
            if (confirm == DialogResult.Yes)
            {
                DeleteCustomer(_selectedCustomerId);
            }
            // If the user clicked No, do nothing — the record is preserved

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {


            DialogResult logmeout = MessageBox.Show(
                "Are you sure to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logmeout == DialogResult.Yes)
            {



                AuditLogger.Log("LOGOUT", $"{AppSession.CurrentFullName} ({AppSession.CurrentRole}) logged out.");
                AppSession.Clear();

                this.Close();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            frmAnalytics anl = new frmAnalytics();

            AuditLogger.Log("VIEW_ANALYTICS", $"{AppSession.CurrentUsername} opened the Analytics Dashboard.");

            anl.ShowDialog(this);
        }
        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            // Make sure there is something to export
            if (dgvCustomers.Rows.Count == 0)
            {
                MessageBox.Show("There are no records to export.",
                    "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Let the user choose where to save the file
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveDialog.FileName = "CustomerList.xlsx";

                if (saveDialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Customers");

                        // Write column headers in row 1
                        for (int col = 0; col < dgvCustomers.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col + 1).Value = dgvCustomers.Columns[col].HeaderText;
                            worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                        }

                        // Write each data row starting from row 2
                        for (int row = 0; row < dgvCustomers.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgvCustomers.Columns.Count; col++)
                            {
                                var cellValue = dgvCustomers.Rows[row].Cells[col].Value;
                                worksheet.Cell(row + 2, col + 1).Value = cellValue?.ToString() ?? "";
                            }
                        }

                        // Auto-adjust column widths to fit the content
                        worksheet.Columns().AdjustToContents();

                        workbook.SaveAs(saveDialog.FileName);
                    }

                    AuditLogger.Log("EXPORT_EXCEL", $"{AppSession.CurrentUsername} exported customer list to Excel.");

                    MessageBox.Show("Customer list exported successfully to Excel.",
                        "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting to Excel:\n{ex.Message}",
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            // Make sure there is something to export
            if (dgvCustomers.Rows.Count == 0)
            {
                MessageBox.Show("There are no records to export.",
                    "Export to PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF Document (*.pdf)|*.pdf";
                saveDialog.FileName = "CustomerList.pdf";

                if (saveDialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (PdfDocument document = new PdfDocument())
                    {
                        // Create a new page set to Landscape orientation
                        PdfPage page = document.AddPage();
                        page.Orientation = PdfSharpCore.PageOrientation.Landscape;

                        using (XGraphics gfx = XGraphics.FromPdfPage(page))
                        {
                            XFont titleFont = new XFont("Arial", 16, XFontStyle.Bold);
                            XFont headerFont = new XFont("Arial", 10, XFontStyle.Bold);
                            XFont cellFont = new XFont("Arial", 9, XFontStyle.Regular);

                            // Title
                            gfx.DrawString("Customer List Report", titleFont, XBrushes.Black,
                                new XRect(0, 20, page.Width, 30), XStringFormats.TopCenter);

                            int columnCount = dgvCustomers.Columns.Count;
                            double margin = 30;
                            double tableWidth = page.Width - (margin * 2);
                            double colWidth = tableWidth / columnCount;
                            double rowHeight = 22;
                            double y = 60;

                            // Draw column headers
                            double x = margin;
                            for (int col = 0; col < columnCount; col++)
                            {
                                gfx.DrawString(dgvCustomers.Columns[col].HeaderText, headerFont,
                                    XBrushes.Black, new XRect(x, y, colWidth, rowHeight),
                                    XStringFormats.CenterLeft);
                                x += colWidth;
                            }

                            y += rowHeight;
                            gfx.DrawLine(XPens.Black, margin, y, page.Width - margin, y);

                            // Draw each data row
                            foreach (DataGridViewRow row in dgvCustomers.Rows)
                            {
                                x = margin;
                                y += rowHeight;

                                // Start a new page if we run out of vertical space
                                if (y > page.Height - margin)
                                {
                                    page = document.AddPage();
                                    page.Orientation = PdfSharpCore.PageOrientation.Landscape;
                                    gfx.Dispose();
                                    y = 40;
                                }

                                for (int col = 0; col < columnCount; col++)
                                {
                                    string text = row.Cells[col].Value?.ToString() ?? "";
                                    gfx.DrawString(text, cellFont, XBrushes.Black,
                                        new XRect(x, y, colWidth, rowHeight),
                                        XStringFormats.CenterLeft);
                                    x += colWidth;
                                }
                            }
                        }

                        document.Save(saveDialog.FileName);
                    }

                    AuditLogger.Log("EXPORT_PDF", $"{AppSession.CurrentUsername} exported customer list to PDF.");

                    MessageBox.Show("Customer list exported successfully to PDF.",
                        "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting to PDF:\n{ex.Message}",
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void btnAuditLog_Click(object sender, EventArgs e)
        {
            frmAuditLogs auditForm = new frmAuditLogs();
            auditForm.ShowDialog(this);
        }
        private void btnManagePermissions_Click(object sender, EventArgs e)
        {
            frmManagePermissions permForm = new frmManagePermissions();
            permForm.ShowDialog(this);
        }
        private void statusTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass changePass = new frmChangePass();
            changePass.ShowDialog(this);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmViewBillingHistory viewBillingHistory = new frmViewBillingHistory(_selectedCustomerId);
            viewBillingHistory.ShowDialog(this);
        }
        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.Rows.Count == 0 || _selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer to archive.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to archive {dgvCustomers.CurrentRow.Cells["FullName"].Value.ToString()}?\n" +
                "Archived customers will not appear in the main list.",
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
                                   SET isarchive = 1
                                   WHERE CustomerID = @CustomerID;";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", _selectedCustomerId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer archived successfully.",
                                    "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AuditLogger.Log("ARCHIVE_CUSTOMER", $"Customer ID {_selectedCustomerId} archived by {AppSession.CurrentUsername}.");

                                LoadCustomers();
                            }
                            else
                            {
                                MessageBox.Show("Customer could not be archived. It may no longer exist.",
                                    "Archive Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error archiving customer:\n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void viewArchiveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchivedCustomer archivedCustomer = new ArchivedCustomer();
            archivedCustomer.ShowDialog(this);
            LoadCustomers();
        }
        private void dgvCustomers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Clear any rows the user had previously highlighted
                dgvCustomers.ClearSelection();

                // Simultaneously select the row that was just right-clicked
                dgvCustomers.Rows[e.RowIndex].Selected = true;

                // (Optional) Move the active cell focus to the clicked cell
                dgvCustomers.CurrentCell = dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Now show your context menu exactly where the mouse is
                cmsArchive.Show(Cursor.Position);
            }
        }
        private void btnUserMgt_Click(object sender, EventArgs e)
        {
            UserManagement usrmgt = new UserManagement();
            usrmgt.ShowDialog(this);
        }


        // METHODS AHEAD //
        private void LoadCustomers()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // SELECT all customers, most recently added first
                    string sql = @"SELECT CustomerID,
                                  FullName,
                                  Address,
                                  ContactNumber,
                                  Email,
                                  Balance,
                                  Status
                           FROM   Customers
                           WHERE isarchive = 0
                           ORDER  BY FullName ASC;";

                    using (var adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the grid
                        dgvCustomers.DataSource = dt;

                        // Improve column headers for readability
                        if (dgvCustomers.Columns.Count > 0)
                        {
                            dgvCustomers.Columns["CustomerID"].HeaderText = "ID";
                            dgvCustomers.Columns["CustomerID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                            dgvCustomers.Columns["FullName"].HeaderText = "Full Name";
                            dgvCustomers.Columns["FullName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            dgvCustomers.Columns["ContactNumber"].HeaderText = "Contact No.";
                            dgvCustomers.Columns["ContactNumber"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            dgvCustomers.Columns["Balance"].HeaderText = "Balance (₱)";
                            dgvCustomers.Columns["Balance"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgvCustomers.Columns["Balance"].DefaultCellStyle.Format = "N2";  // Format as number with 2 decimal places
                            dgvCustomers.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                        }

                        lblTitle.Text = $"CUSTOMER LIST - ({dt.Rows.Count} record(s))";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchCustomers(string keyword)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized SELECT with WHERE ... LIKE
                    string sql = @"SELECT CustomerID,
                                  FullName,
                                  Address,
                                  ContactNumber,
                                  Email,
                                  Balance,
                                  Status
                           FROM   Customers
                           WHERE  FullName      LIKE @keyword
                              OR  Address       LIKE @keyword
                              OR  ContactNumber LIKE @keyword
                           ORDER  BY FullName ASC;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        // %keyword% matches the search text anywhere in the column
                        cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvCustomers.DataSource = dt;
                            lblTitle.Text = $"Customer List  ({dt.Rows.Count} result(s))";

                            if (dt.Rows.Count == 0)
                            {
                                _selectedCustomerId = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching customers:\n{ex.Message}",
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureDataGridView()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.Columns["CustomerID"].DataPropertyName = "CustomerID";
            dgvCustomers.Columns["FullName"].DataPropertyName = "FullName";
            dgvCustomers.Columns["Address"].DataPropertyName = "Address";
            dgvCustomers.Columns["ContactNumber"].DataPropertyName = "ContactNumber";
            dgvCustomers.Columns["Email"].DataPropertyName = "Email";
            dgvCustomers.Columns["Balance"].DataPropertyName = "Balance";
        }
        private void OpenEditForm()
        {
            if (_selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open AddCustomerForm in EDIT mode, passing the selected CustomerID
            AddCustomerForm editForm = new AddCustomerForm(_selectedCustomerId);

            // Refresh the grid automatically once the edit form closes
            editForm.FormClosed += (s, args) => LoadCustomers();

            editForm.ShowDialog(this);
        }
        private void DeleteCustomer(int customerId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized DELETE — removes exactly one row
                    string sql = "DELETE FROM Customers WHERE CustomerID = @CustomerID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully.",
                                "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AuditLogger.Log("DELETE_CUSTOMER", $"Customer ID {customerId} deleted by {AppSession.CurrentUsername}.");

                            LoadCustomers();   // Refresh the grid
                            _selectedCustomerId = 0;   // Clear selection tracker
                        }
                        else
                        {
                            MessageBox.Show("Customer could not be deleted. It may no longer exist.",
                                "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyPermissions()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT PermissionName, IsAllowed
                           FROM   UserPermissions
                           WHERE  Role = @Role;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Role", AppSession.CurrentRole);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string permName = reader.GetString("PermissionName");
                                bool isAllowed = reader.GetBoolean("IsAllowed");

                                switch (permName)
                                {
                                    case "AddCustomer":
                                        btnAdd.Visible = isAllowed; break;
                                    case "EditCustomer":
                                        // Edit is triggered by double-click — disable
                                        // it by blocking the CellDoubleClick handler
                                        dgvCustomers.ReadOnly = !isAllowed;
                                        break;
                                    case "DeleteCustomer":
                                        btnDelete.Visible = isAllowed; break;
                                    case "Analytics":
                                        btnAnalytics.Visible = isAllowed; break;
                                    case "ExportExcel":
                                        btnExportExcel.Visible = isAllowed; break;
                                    case "ExportPdf":
                                        btnExportPdf.Visible = isAllowed; break;
                                    case "AuditLogs":
                                        btnAuditLog.Visible = isAllowed; break;
                                    case "ManagePermissions":
                                        btnManagePermissions.Visible = isAllowed; break;
                                    case "UserManagement":
                                        btnUserMgt.Visible = isAllowed; break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading permissions:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitStatusStrip()
        {
            lblStatusUser.Text =
                $"User: {AppSession.CurrentFullName}  |  Role: {AppSession.CurrentRole}";
            UpdateClock();
        }
        private void UpdateClock()
        {
            lblStatusTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy   hh:mm:ss tt");
        }
        private void ApplyTheme()
        {
            // Form background
            this.BackColor = AppTheme.BackgroundColor;

            // Top panel (header bar)
            pnlTop.BackColor = AppTheme.PrimaryColor;
            pnlBottom.BackColor = Color.FromArgb(242, 242, 242);

            // Action buttons
            //btnAdd.BackColor = AppTheme.SuccessColor;
            //btnAdd.ForeColor = Color.White;
            //btnDelete.BackColor = AppTheme.DangerColor;
            //btnDelete.ForeColor = Color.White;
            //btnAnalytics.BackColor = AppTheme.PrimaryColor;
            //btnAnalytics.ForeColor = Color.White;
            //btnExportExcel.BackColor = AppTheme.SecondaryColor;
            //btnExportExcel.ForeColor = Color.White;
            //btnExportPdf.BackColor = AppTheme.SecondaryColor;
            //btnExportPdf.ForeColor = Color.White;
            //btnAuditLog.BackColor = AppTheme.SecondaryColor;
            //btnAuditLog.ForeColor = Color.White;
            //btnManagePermissions.BackColor = AppTheme.DangerColor;
            //btnManagePermissions.ForeColor = Color.White;

            // DataGridView header colors
            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = AppTheme.PrimaryColor;
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9f, FontStyle.Bold);

            // Alternating row colors
            dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = AppTheme.GridRowAlt;
        }


    }

}
