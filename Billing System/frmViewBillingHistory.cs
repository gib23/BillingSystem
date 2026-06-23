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
    public partial class frmViewBillingHistory : Form
    {
        private int _viewBillingHistory = 0;
        public frmViewBillingHistory(int customerid)
        {
            InitializeComponent();
            _viewBillingHistory = customerid;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewBillingHistory_Load(object sender, EventArgs e)
        {
            LoadBillingHistory();
        }
        private void LoadBillingHistory()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string CustomerName = @"SELECT 
                                            FullName
                                            FROM billingdb.customers
                                            WHERE CustomerID = @CustomerID;";

                    using (var cmd = new MySqlCommand(CustomerName, conn)) 
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", _viewBillingHistory);
                        var result = cmd.ExecuteScalar();

                        lblTitle.Text = result != null ? "Billing History - " + result.ToString() : "Customer Not Found";
                    }

                    string sql = @"SELECT 
                                    BillingID,
                                    CustomerID,
                                    BillingMonth,
                                    PreviousReading,
                                    PresentReading,
                                    Consumption,
                                    RatePerCubic,
                                    TotalAmount,
                                    Status
                                    FROM billingdb.billing
                                    WHERE CustomerID = @CustomerID
                                    ORDER BY STR_TO_DATE(BillingMonth, '%M %Y') ASC;";
                    using (var adapter = new MySqlDataAdapter(sql, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", _viewBillingHistory);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvBillingHistory.DataSource = dt;
                        dgvBillingHistory.Columns["BillingID"].Visible = false;
                        dgvBillingHistory.Columns["CustomerID"].Visible = false;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No Billing Records Found", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading billing history:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
