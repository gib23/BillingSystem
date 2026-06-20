namespace Billing_System
{
    partial class frmManagePermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePermissions));
            lblTitle = new Label();
            lblRole = new Label();
            cmbRole = new ComboBox();
            chkAddCustomer = new CheckBox();
            grpPermissions = new GroupBox();
            chkAuditLogs = new CheckBox();
            chkExportPdf = new CheckBox();
            chkAnalytics = new CheckBox();
            chkEditCustomer = new CheckBox();
            chkExportExcel = new CheckBox();
            chkDeleteCustomer = new CheckBox();
            btnClose = new Button();
            btnSave = new Button();
            grpPermissions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(31, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(205, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Permissions";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(12, 58);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(86, 20);
            lblRole.TabIndex = 0;
            lblRole.Text = "Select Role:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(116, 55);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(232, 28);
            cmbRole.TabIndex = 1;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // chkAddCustomer
            // 
            chkAddCustomer.AutoSize = true;
            chkAddCustomer.Font = new Font("Segoe UI", 10.8F);
            chkAddCustomer.Location = new Point(45, 26);
            chkAddCustomer.Name = "chkAddCustomer";
            chkAddCustomer.Size = new Size(150, 29);
            chkAddCustomer.TabIndex = 2;
            chkAddCustomer.Text = "Add Customer";
            chkAddCustomer.UseVisualStyleBackColor = true;
            // 
            // grpPermissions
            // 
            grpPermissions.Controls.Add(chkAuditLogs);
            grpPermissions.Controls.Add(chkExportPdf);
            grpPermissions.Controls.Add(chkAnalytics);
            grpPermissions.Controls.Add(chkEditCustomer);
            grpPermissions.Controls.Add(chkExportExcel);
            grpPermissions.Controls.Add(chkDeleteCustomer);
            grpPermissions.Controls.Add(chkAddCustomer);
            grpPermissions.Location = new Point(12, 89);
            grpPermissions.Name = "grpPermissions";
            grpPermissions.Size = new Size(408, 312);
            grpPermissions.TabIndex = 3;
            grpPermissions.TabStop = false;
            grpPermissions.Text = "Permissions";
            // 
            // chkAuditLogs
            // 
            chkAuditLogs.AutoSize = true;
            chkAuditLogs.Font = new Font("Segoe UI", 10.8F);
            chkAuditLogs.Location = new Point(45, 260);
            chkAuditLogs.Name = "chkAuditLogs";
            chkAuditLogs.Size = new Size(120, 29);
            chkAuditLogs.TabIndex = 2;
            chkAuditLogs.Text = "Audit Logs";
            chkAuditLogs.UseVisualStyleBackColor = true;
            // 
            // chkExportPdf
            // 
            chkExportPdf.AutoSize = true;
            chkExportPdf.Font = new Font("Segoe UI", 10.8F);
            chkExportPdf.Location = new Point(45, 221);
            chkExportPdf.Name = "chkExportPdf";
            chkExportPdf.Size = new Size(144, 29);
            chkExportPdf.TabIndex = 2;
            chkExportPdf.Text = "Export to PDF";
            chkExportPdf.UseVisualStyleBackColor = true;
            // 
            // chkAnalytics
            // 
            chkAnalytics.AutoSize = true;
            chkAnalytics.Font = new Font("Segoe UI", 10.8F);
            chkAnalytics.Location = new Point(45, 143);
            chkAnalytics.Name = "chkAnalytics";
            chkAnalytics.Size = new Size(104, 29);
            chkAnalytics.TabIndex = 2;
            chkAnalytics.Text = "Analytics";
            chkAnalytics.UseVisualStyleBackColor = true;
            // 
            // chkEditCustomer
            // 
            chkEditCustomer.AutoSize = true;
            chkEditCustomer.Font = new Font("Segoe UI", 10.8F);
            chkEditCustomer.Location = new Point(45, 65);
            chkEditCustomer.Name = "chkEditCustomer";
            chkEditCustomer.Size = new Size(146, 29);
            chkEditCustomer.TabIndex = 2;
            chkEditCustomer.Text = "Edit Customer";
            chkEditCustomer.UseVisualStyleBackColor = true;
            // 
            // chkExportExcel
            // 
            chkExportExcel.AutoSize = true;
            chkExportExcel.Font = new Font("Segoe UI", 10.8F);
            chkExportExcel.Location = new Point(45, 182);
            chkExportExcel.Name = "chkExportExcel";
            chkExportExcel.Size = new Size(150, 29);
            chkExportExcel.TabIndex = 2;
            chkExportExcel.Text = "Export to Excel";
            chkExportExcel.UseVisualStyleBackColor = true;
            // 
            // chkDeleteCustomer
            // 
            chkDeleteCustomer.AutoSize = true;
            chkDeleteCustomer.Font = new Font("Segoe UI", 10.8F);
            chkDeleteCustomer.Location = new Point(45, 104);
            chkDeleteCustomer.Name = "chkDeleteCustomer";
            chkDeleteCustomer.Size = new Size(166, 29);
            chkDeleteCustomer.TabIndex = 2;
            chkDeleteCustomer.Text = "Delete Customer";
            chkDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(4, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(380, 53);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(30, 30);
            btnSave.TabIndex = 5;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmManagePermissions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 413);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(grpPermissions);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmManagePermissions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Permissions";
            Load += frmManagePermissions_Load;
            grpPermissions.ResumeLayout(false);
            grpPermissions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRole;
        private ComboBox cmbRole;
        private CheckBox chkAddCustomer;
        private GroupBox grpPermissions;
        private Button btnClose;
        private Button btnSave;
        private CheckBox chkAuditLogs;
        private CheckBox chkExportPdf;
        private CheckBox chkAnalytics;
        private CheckBox chkEditCustomer;
        private CheckBox chkExportExcel;
        private CheckBox chkDeleteCustomer;
    }
}