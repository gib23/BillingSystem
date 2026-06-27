namespace Billing_System
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            label1 = new Label();
            btnClose = new Button();
            dgvUsers = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDisable = new Button();
            chkDisabled = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 18);
            label1.Name = "label1";
            label1.Size = new Size(242, 31);
            label1.TabIndex = 0;
            label1.Text = "USER MANAGEMENT";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(12, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { UserID, Username, FullName, Role, Status, CreatedAt });
            dgvUsers.Location = new Point(38, 71);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(987, 352);
            dgvUsers.TabIndex = 2;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "User ID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // CreatedAt
            // 
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "Date Created";
            CreatedAt.MinimumWidth = 6;
            CreatedAt.Name = "CreatedAt";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(1040, 71);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 30);
            btnAdd.TabIndex = 1;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(1040, 117);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(30, 30);
            btnEdit.TabIndex = 1;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDisable
            // 
            btnDisable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDisable.BackgroundImage = (Image)resources.GetObject("btnDisable.BackgroundImage");
            btnDisable.BackgroundImageLayout = ImageLayout.Stretch;
            btnDisable.FlatAppearance.BorderSize = 0;
            btnDisable.FlatStyle = FlatStyle.Flat;
            btnDisable.Location = new Point(1040, 163);
            btnDisable.Name = "btnDisable";
            btnDisable.Size = new Size(30, 30);
            btnDisable.TabIndex = 1;
            btnDisable.UseVisualStyleBackColor = true;
            btnDisable.Click += btnDisable_Click;
            // 
            // chkDisabled
            // 
            chkDisabled.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chkDisabled.AutoSize = true;
            chkDisabled.Location = new Point(856, 429);
            chkDisabled.Name = "chkDisabled";
            chkDisabled.Size = new Size(169, 24);
            chkDisabled.TabIndex = 3;
            chkDisabled.Text = "Show Disabled Users";
            chkDisabled.UseVisualStyleBackColor = true;
            chkDisabled.CheckedChanged += chkDisabled_CheckedChanged;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 453);
            Controls.Add(chkDisabled);
            Controls.Add(dgvUsers);
            Controls.Add(btnDisable);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Name = "UserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserManagement";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private DataGridView dgvUsers;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDisable;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn CreatedAt;
        private CheckBox chkDisabled;
    }
}