namespace Billing_System
{
    partial class frmViewBillingHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBillingHistory));
            dgvBillingHistory = new DataGridView();
            BillingMonth = new DataGridViewTextBoxColumn();
            PreviousReading = new DataGridViewTextBoxColumn();
            PresentReading = new DataGridViewTextBoxColumn();
            Consumption = new DataGridViewTextBoxColumn();
            RatePerCubic = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvBillingHistory
            // 
            dgvBillingHistory.AllowUserToAddRows = false;
            dgvBillingHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBillingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillingHistory.Columns.AddRange(new DataGridViewColumn[] { BillingMonth, PreviousReading, PresentReading, Consumption, RatePerCubic, TotalAmount, Status });
            dgvBillingHistory.Location = new Point(12, 75);
            dgvBillingHistory.Name = "dgvBillingHistory";
            dgvBillingHistory.RowHeadersVisible = false;
            dgvBillingHistory.RowHeadersWidth = 51;
            dgvBillingHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBillingHistory.Size = new Size(938, 366);
            dgvBillingHistory.TabIndex = 0;
            // 
            // BillingMonth
            // 
            BillingMonth.DataPropertyName = "BillingMonth";
            BillingMonth.HeaderText = "Billing Month";
            BillingMonth.MinimumWidth = 6;
            BillingMonth.Name = "BillingMonth";
            // 
            // PreviousReading
            // 
            PreviousReading.DataPropertyName = "PreviousReading";
            PreviousReading.HeaderText = "Previous Reading";
            PreviousReading.MinimumWidth = 6;
            PreviousReading.Name = "PreviousReading";
            // 
            // PresentReading
            // 
            PresentReading.DataPropertyName = "PresentReading";
            PresentReading.HeaderText = "Present Reading";
            PresentReading.MinimumWidth = 6;
            PresentReading.Name = "PresentReading";
            // 
            // Consumption
            // 
            Consumption.DataPropertyName = "Consumption";
            Consumption.HeaderText = "Consumption";
            Consumption.MinimumWidth = 6;
            Consumption.Name = "Consumption";
            // 
            // RatePerCubic
            // 
            RatePerCubic.DataPropertyName = "RatePerCubic";
            RatePerCubic.HeaderText = "Rate";
            RatePerCubic.MinimumWidth = 6;
            RatePerCubic.Name = "RatePerCubic";
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(48, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(396, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Billing History - <Customer Name>";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(12, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmViewBillingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 453);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(dgvBillingHistory);
            Name = "frmViewBillingHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing History";
            Load += frmViewBillingHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBillingHistory;
        private Label lblTitle;
        private Button btnClose;
        private DataGridViewTextBoxColumn BillingMonth;
        private DataGridViewTextBoxColumn PreviousReading;
        private DataGridViewTextBoxColumn PresentReading;
        private DataGridViewTextBoxColumn Consumption;
        private DataGridViewTextBoxColumn RatePerCubic;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn Status;
    }
}