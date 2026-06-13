namespace Billing_System
{
    partial class AddCustomerForm
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
            label1 = new Label();
            lblFullName = new Label();
            lblAddress = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblBalance = new Label();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtBalance = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW CUSTOMER";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(24, 62);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(79, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(24, 101);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(24, 140);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(121, 20);
            lblContact.TabIndex = 1;
            lblContact.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 179);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(24, 218);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(105, 20);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Initial Balance:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(184, 58);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(195, 27);
            txtFullName.TabIndex = 1;
            txtFullName.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(184, 98);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(195, 27);
            txtAddress.TabIndex = 2;
            txtAddress.TextAlign = HorizontalAlignment.Right;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(184, 138);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(195, 27);
            txtContact.TabIndex = 3;
            txtContact.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 178);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(184, 218);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(195, 27);
            txtBalance.TabIndex = 5;
            txtBalance.Text = "0.00";
            txtBalance.TextAlign = HorizontalAlignment.Right;
            txtBalance.KeyPress += txtBalance_KeyPress;
            txtBalance.MouseUp += txtBalance_MouseUp;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(24, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 44);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(147, 281);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 44);
            btnClear.TabIndex = 7;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(270, 281);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(123, 44);
            btnBack.TabIndex = 8;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 373);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtBalance);
            Controls.Add(txtContact);
            Controls.Add(txtFullName);
            Controls.Add(lblBalance);
            Controls.Add(lblEmail);
            Controls.Add(lblContact);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BILLING SYSTEM - ADD CUSTOMER";
            Load += AddCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblContact;
        private Label lblEmail;
        private Label lblBalance;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtBalance;
        private Button btnSave;
        private Button btnClear;
        private Button btnBack;
    }
}