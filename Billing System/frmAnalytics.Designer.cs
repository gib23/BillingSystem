namespace Billing_System
{
    partial class frmAnalytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTotalCustomers = new Label();
            lblTotalRevenue = new Label();
            lblTotalUnpaid = new Label();
            lblTop5Title = new Label();
            plotMonthlyRevenue = new ScottPlot.WinForms.FormsPlot();
            dgvTop5 = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            TotalConsumption = new DataGridViewTextBoxColumn();
            TotalBilled = new DataGridViewTextBoxColumn();
            plotPaidUnpaid = new ScottPlot.WinForms.FormsPlot();
            btnCloseAnalytics = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(913, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ANALYTICS DASHBOARD";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Location = new Point(3, 0);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(298, 40);
            lblTotalCustomers.TabIndex = 0;
            lblTotalCustomers.Text = "Total Customers: \r\n0";
            lblTotalCustomers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.Anchor = AnchorStyles.Top;
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(399, 0);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(113, 40);
            lblTotalRevenue.TabIndex = 0;
            lblTotalRevenue.Text = "Total Revenue:  \r\n₱0.00";
            lblTotalRevenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalUnpaid
            // 
            lblTotalUnpaid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalUnpaid.AutoSize = true;
            lblTotalUnpaid.Location = new Point(611, 0);
            lblTotalUnpaid.Name = "lblTotalUnpaid";
            lblTotalUnpaid.Size = new Size(299, 40);
            lblTotalUnpaid.TabIndex = 0;
            lblTotalUnpaid.Text = "Total Unpaid:  \r\n₱0.00";
            lblTotalUnpaid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTop5Title
            // 
            lblTop5Title.AutoSize = true;
            lblTop5Title.Location = new Point(3, 299);
            lblTop5Title.Name = "lblTop5Title";
            lblTop5Title.Size = new Size(231, 20);
            lblTop5Title.TabIndex = 0;
            lblTop5Title.Text = "Top 5 Customers by Consumption";
            // 
            // plotMonthlyRevenue
            // 
            plotMonthlyRevenue.Dock = DockStyle.Fill;
            plotMonthlyRevenue.Location = new Point(3, 3);
            plotMonthlyRevenue.Name = "plotMonthlyRevenue";
            plotMonthlyRevenue.Size = new Size(450, 187);
            plotMonthlyRevenue.TabIndex = 1;
            // 
            // dgvTop5
            // 
            dgvTop5.AllowUserToAddRows = false;
            dgvTop5.AllowUserToResizeRows = false;
            dgvTop5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop5.Columns.AddRange(new DataGridViewColumn[] { FullName, TotalConsumption, TotalBilled });
            dgvTop5.Dock = DockStyle.Fill;
            dgvTop5.Location = new Point(3, 332);
            dgvTop5.Name = "dgvTop5";
            dgvTop5.ReadOnly = true;
            dgvTop5.RowHeadersVisible = false;
            dgvTop5.RowHeadersWidth = 51;
            dgvTop5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTop5.Size = new Size(913, 194);
            dgvTop5.TabIndex = 2;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // TotalConsumption
            // 
            TotalConsumption.DataPropertyName = "TotalConsumption";
            TotalConsumption.HeaderText = "Total Consumption";
            TotalConsumption.MinimumWidth = 6;
            TotalConsumption.Name = "TotalConsumption";
            TotalConsumption.ReadOnly = true;
            // 
            // TotalBilled
            // 
            TotalBilled.DataPropertyName = "TotalBilled";
            TotalBilled.HeaderText = "Total Billed";
            TotalBilled.MinimumWidth = 6;
            TotalBilled.Name = "TotalBilled";
            TotalBilled.ReadOnly = true;
            // 
            // plotPaidUnpaid
            // 
            plotPaidUnpaid.Dock = DockStyle.Fill;
            plotPaidUnpaid.Location = new Point(459, 3);
            plotPaidUnpaid.Name = "plotPaidUnpaid";
            plotPaidUnpaid.Size = new Size(451, 187);
            plotPaidUnpaid.TabIndex = 1;
            // 
            // btnCloseAnalytics
            // 
            btnCloseAnalytics.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCloseAnalytics.Location = new Point(708, 547);
            btnCloseAnalytics.Name = "btnCloseAnalytics";
            btnCloseAnalytics.Size = new Size(247, 44);
            btnCloseAnalytics.TabIndex = 3;
            btnCloseAnalytics.Text = "CLOSE ANALYTICS";
            btnCloseAnalytics.UseVisualStyleBackColor = true;
            btnCloseAnalytics.Click += btnCloseAnalytics_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(plotPaidUnpaid, 1, 0);
            tableLayoutPanel1.Controls.Add(plotMonthlyRevenue, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 103);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(913, 193);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel2.Controls.Add(lblTop5Title, 0, 3);
            tableLayoutPanel2.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(dgvTop5, 0, 4);
            tableLayoutPanel2.Location = new Point(36, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(919, 529);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(lblTotalRevenue, 1, 0);
            tableLayoutPanel3.Controls.Add(lblTotalCustomers, 0, 0);
            tableLayoutPanel3.Controls.Add(lblTotalUnpaid, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 53);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(913, 44);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // frmAnalytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(btnCloseAnalytics);
            Name = "frmAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Analytics Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += frmAnalytics_Load;
            KeyDown += frmAnalytics_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblTotalCustomers;
        private Label lblTotalRevenue;
        private Label lblTotalUnpaid;
        private Label lblTop5Title;
        private ScottPlot.WinForms.FormsPlot plotMonthlyRevenue;
        private DataGridView dgvTop5;
        private ScottPlot.WinForms.FormsPlot plotPaidUnpaid;
        private Button btnCloseAnalytics;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn TotalConsumption;
        private DataGridViewTextBoxColumn TotalBilled;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}