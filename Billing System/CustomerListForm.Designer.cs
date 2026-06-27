namespace Billing_System
{
    partial class CustomerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListForm));
            lblTitle = new Label();
            dgvCustomers = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnAnalytics = new Button();
            btnExportExcel = new Button();
            btnExportPdf = new Button();
            btnAuditLog = new Button();
            btnManagePermissions = new Button();
            statusStrip1 = new StatusStrip();
            lblStatusUser = new ToolStripStatusLabel();
            lblStatusSep = new ToolStripStatusLabel();
            lblStatusTime = new ToolStripStatusLabel();
            statusTimer = new System.Windows.Forms.Timer(components);
            pnlTop = new Panel();
            btnChangePass = new Button();
            pnlBottom = new Panel();
            btnUserMgt = new Button();
            btnView = new Button();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            statusStrip1.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(38, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CUSTOMER LIST";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Address, ContactNumber, Email, Balance });
            dgvCustomers.Location = new Point(38, 42);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(828, 477);
            dgvCustomers.TabIndex = 2;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // CustomerID
            // 
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // ContactNumber
            // 
            ContactNumber.DataPropertyName = "ContactNumber";
            ContactNumber.HeaderText = "Contact No.";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.DataPropertyName = "Balance";
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(872, 83);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 30);
            btnAdd.TabIndex = 3;
            toolTip.SetToolTip(btnAdd, "Add New Customer");
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(872, 124);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(30, 30);
            btnDelete.TabIndex = 4;
            toolTip.SetToolTip(btnDelete, "Delete Customer");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(3, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(30, 30);
            btnLogout.TabIndex = 5;
            toolTip.SetToolTip(btnLogout, "Logout");
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(320, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(25, 25);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(38, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(276, 27);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnalytics.BackColor = Color.Transparent;
            btnAnalytics.BackgroundImage = (Image)resources.GetObject("btnAnalytics.BackgroundImage");
            btnAnalytics.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Location = new Point(872, 247);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(30, 30);
            btnAnalytics.TabIndex = 6;
            toolTip.SetToolTip(btnAnalytics, "Analytics");
            btnAnalytics.UseVisualStyleBackColor = false;
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportExcel.BackColor = Color.Transparent;
            btnExportExcel.BackgroundImage = (Image)resources.GetObject("btnExportExcel.BackgroundImage");
            btnExportExcel.BackgroundImageLayout = ImageLayout.Stretch;
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Location = new Point(872, 288);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(30, 30);
            btnExportExcel.TabIndex = 5;
            toolTip.SetToolTip(btnExportExcel, "Export to Excel");
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btn_ExportExcel_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportPdf.BackColor = Color.Transparent;
            btnExportPdf.BackgroundImage = (Image)resources.GetObject("btnExportPdf.BackgroundImage");
            btnExportPdf.BackgroundImageLayout = ImageLayout.Stretch;
            btnExportPdf.FlatAppearance.BorderSize = 0;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Location = new Point(872, 329);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(30, 30);
            btnExportPdf.TabIndex = 7;
            toolTip.SetToolTip(btnExportPdf, "Export To PDF");
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnAuditLog
            // 
            btnAuditLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAuditLog.BackColor = Color.Transparent;
            btnAuditLog.BackgroundImage = (Image)resources.GetObject("btnAuditLog.BackgroundImage");
            btnAuditLog.BackgroundImageLayout = ImageLayout.Stretch;
            btnAuditLog.FlatAppearance.BorderSize = 0;
            btnAuditLog.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAuditLog.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAuditLog.FlatStyle = FlatStyle.Flat;
            btnAuditLog.Location = new Point(872, 206);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Size = new Size(30, 30);
            btnAuditLog.TabIndex = 8;
            toolTip.SetToolTip(btnAuditLog, "Audit Logs");
            btnAuditLog.UseVisualStyleBackColor = false;
            btnAuditLog.Click += btnAuditLog_Click;
            // 
            // btnManagePermissions
            // 
            btnManagePermissions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnManagePermissions.BackgroundImage = (Image)resources.GetObject("btnManagePermissions.BackgroundImage");
            btnManagePermissions.BackgroundImageLayout = ImageLayout.Stretch;
            btnManagePermissions.FlatAppearance.BorderSize = 0;
            btnManagePermissions.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnManagePermissions.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnManagePermissions.FlatStyle = FlatStyle.Flat;
            btnManagePermissions.Location = new Point(872, 165);
            btnManagePermissions.Name = "btnManagePermissions";
            btnManagePermissions.Size = new Size(30, 30);
            btnManagePermissions.TabIndex = 9;
            toolTip.SetToolTip(btnManagePermissions, "Manage Permissions");
            btnManagePermissions.UseVisualStyleBackColor = true;
            btnManagePermissions.Click += btnManagePermissions_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusUser, lblStatusSep, lblStatusTime });
            statusStrip1.Location = new Point(0, 587);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(921, 26);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(204, 20);
            lblStatusUser.Text = "User: [username] | Role: [role]";
            // 
            // lblStatusSep
            // 
            lblStatusSep.Name = "lblStatusSep";
            lblStatusSep.Size = new Size(595, 20);
            lblStatusSep.Spring = true;
            // 
            // lblStatusTime
            // 
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(107, 20);
            lblStatusTime.Text = "Date and Time";
            // 
            // statusTimer
            // 
            statusTimer.Enabled = true;
            statusTimer.Interval = 1000;
            statusTimer.Tick += statusTimer_Tick;
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.Controls.Add(btnChangePass);
            pnlTop.Controls.Add(btnLogout);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(921, 45);
            pnlTop.TabIndex = 11;
            // 
            // btnChangePass
            // 
            btnChangePass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangePass.BackgroundImage = (Image)resources.GetObject("btnChangePass.BackgroundImage");
            btnChangePass.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Location = new Point(872, 9);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(30, 30);
            btnChangePass.TabIndex = 6;
            toolTip.SetToolTip(btnChangePass, "Change Password");
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBottom.Controls.Add(btnUserMgt);
            pnlBottom.Controls.Add(btnView);
            pnlBottom.Controls.Add(txtSearch);
            pnlBottom.Controls.Add(dgvCustomers);
            pnlBottom.Controls.Add(btnAdd);
            pnlBottom.Controls.Add(btnManagePermissions);
            pnlBottom.Controls.Add(btnDelete);
            pnlBottom.Controls.Add(btnAuditLog);
            pnlBottom.Controls.Add(btnExportExcel);
            pnlBottom.Controls.Add(btnExportPdf);
            pnlBottom.Controls.Add(btnSearch);
            pnlBottom.Controls.Add(btnAnalytics);
            pnlBottom.Location = new Point(0, 45);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(921, 539);
            pnlBottom.TabIndex = 12;
            // 
            // btnUserMgt
            // 
            btnUserMgt.BackgroundImage = (Image)resources.GetObject("btnUserMgt.BackgroundImage");
            btnUserMgt.BackgroundImageLayout = ImageLayout.Stretch;
            btnUserMgt.FlatAppearance.BorderSize = 0;
            btnUserMgt.FlatStyle = FlatStyle.Flat;
            btnUserMgt.Location = new Point(872, 365);
            btnUserMgt.Name = "btnUserMgt";
            btnUserMgt.Size = new Size(30, 30);
            btnUserMgt.TabIndex = 11;
            btnUserMgt.Text = "button1";
            btnUserMgt.UseVisualStyleBackColor = true;
            btnUserMgt.Click += btnUserMgt_Click;
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnView.BackgroundImage = (Image)resources.GetObject("btnView.BackgroundImage");
            btnView.BackgroundImageLayout = ImageLayout.Stretch;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Location = new Point(872, 42);
            btnView.Name = "btnView";
            btnView.Size = new Size(30, 30);
            btnView.TabIndex = 10;
            toolTip.SetToolTip(btnView, "View Billing History");
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 613);
            ControlBox = false;
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            Controls.Add(statusStrip1);
            Name = "CustomerListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BILLING SYSTEM - CUSTOMER LIST";
            Load += CustomerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnLogout;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Balance;
        private Button btnAnalytics;
        private Button btnExportExcel;
        private Button btnExportPdf;
        private Button btnAuditLog;
        private Button btnManagePermissions;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusUser;
        private ToolStripStatusLabel lblStatusSep;
        private ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer statusTimer;
        private Panel pnlTop;
        private Panel pnlBottom;
        private Button btnChangePass;
        private Button btnView;
        private ToolTip toolTip;
        private Button btnUserMgt;
    }
}