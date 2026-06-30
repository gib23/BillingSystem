namespace Billing_System
{
    partial class ArchivedCustomer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivedCustomer));
            dgvArchivedCustomers = new DataGridView();
            cmsUnarchived = new ContextMenuStrip(components);
            unarchivedCustomerToolStripMenuItem = new ToolStripMenuItem();
            lblTitle = new Label();
            btnBack = new Button();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvArchivedCustomers).BeginInit();
            cmsUnarchived.SuspendLayout();
            SuspendLayout();
            // 
            // dgvArchivedCustomers
            // 
            dgvArchivedCustomers.AllowUserToAddRows = false;
            dgvArchivedCustomers.AllowUserToDeleteRows = false;
            dgvArchivedCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArchivedCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArchivedCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchivedCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Address, Status });
            dgvArchivedCustomers.ContextMenuStrip = cmsUnarchived;
            dgvArchivedCustomers.Location = new Point(12, 48);
            dgvArchivedCustomers.MultiSelect = false;
            dgvArchivedCustomers.Name = "dgvArchivedCustomers";
            dgvArchivedCustomers.ReadOnly = true;
            dgvArchivedCustomers.RowHeadersVisible = false;
            dgvArchivedCustomers.RowHeadersWidth = 51;
            dgvArchivedCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArchivedCustomers.Size = new Size(652, 390);
            dgvArchivedCustomers.TabIndex = 0;
            dgvArchivedCustomers.CellMouseDown += dgvArchivedCustomers_CellMouseDown;
            dgvArchivedCustomers.SelectionChanged += dgvArchivedCustomers_SelectionChanged;
            // 
            // cmsUnarchived
            // 
            cmsUnarchived.ImageScalingSize = new Size(20, 20);
            cmsUnarchived.Items.AddRange(new ToolStripItem[] { unarchivedCustomerToolStripMenuItem });
            cmsUnarchived.Name = "cmsUnarchived";
            cmsUnarchived.Size = new Size(220, 28);
            // 
            // unarchivedCustomerToolStripMenuItem
            // 
            unarchivedCustomerToolStripMenuItem.Name = "unarchivedCustomerToolStripMenuItem";
            unarchivedCustomerToolStripMenuItem.Size = new Size(219, 24);
            unarchivedCustomerToolStripMenuItem.Text = "Unarchived Customer";
            unarchivedCustomerToolStripMenuItem.Click += unarchivedCustomerToolStripMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(48, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(394, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ARCHIVED CUSTOMERS - {get data}";
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 2;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CustomerID
            // 
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.FillWeight = 106.951874F;
            CustomerID.HeaderText = "ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.FillWeight = 97.68271F;
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.FillWeight = 97.68271F;
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.FillWeight = 97.68271F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // ArchivedCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(dgvArchivedCustomers);
            Name = "ArchivedCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ArchivedCustomer";
            Load += ArchivedCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArchivedCustomers).EndInit();
            cmsUnarchived.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArchivedCustomers;
        private Label lblTitle;
        private Button btnBack;
        private ContextMenuStrip cmsUnarchived;
        private ToolStripMenuItem unarchivedCustomerToolStripMenuItem;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Status;
    }
}