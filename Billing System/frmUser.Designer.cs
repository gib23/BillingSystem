namespace Billing_System
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            lblTitle = new Label();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblHasSpec = new Label();
            lblHasDig = new Label();
            lblHasLower = new Label();
            lblHasUpper = new Label();
            lblHasMin = new Label();
            label6 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            txtConfirm = new TextBox();
            cmbRole = new ComboBox();
            chkStatus = new CheckBox();
            btnShow1 = new Button();
            btnShow2 = new Button();
            btnSave = new Button();
            lblCkRetype = new Label();
            lblCkNew = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            trmShow = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(48, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(202, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "{ADD/EDIT} USER";
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
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 104);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 151);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 201);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 251);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 2;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 292);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 2;
            label5.Text = "Status";
            // 
            // lblHasSpec
            // 
            lblHasSpec.AutoSize = true;
            lblHasSpec.Location = new Point(48, 444);
            lblHasSpec.Name = "lblHasSpec";
            lblHasSpec.Size = new Size(431, 20);
            lblHasSpec.TabIndex = 7;
            lblHasSpec.Text = "5. Must contain at least one (1) special character (e.g. !@#$%^&*)";
            // 
            // lblHasDig
            // 
            lblHasDig.AutoSize = true;
            lblHasDig.Location = new Point(48, 422);
            lblHasDig.Name = "lblHasDig";
            lblHasDig.Size = new Size(340, 20);
            lblHasDig.TabIndex = 8;
            lblHasDig.Text = "4. Must contain at least one (1) numeric digit (0-9)";
            // 
            // lblHasLower
            // 
            lblHasLower.AutoSize = true;
            lblHasLower.Location = new Point(48, 400);
            lblHasLower.Name = "lblHasLower";
            lblHasLower.Size = new Size(356, 20);
            lblHasLower.TabIndex = 9;
            lblHasLower.Text = "3. Must contain at least one (1) lowercase letter (a-z)";
            // 
            // lblHasUpper
            // 
            lblHasUpper.AutoSize = true;
            lblHasUpper.Location = new Point(48, 378);
            lblHasUpper.Name = "lblHasUpper";
            lblHasUpper.Size = new Size(362, 20);
            lblHasUpper.TabIndex = 10;
            lblHasUpper.Text = "2. Must contain at least one (1) uppercase letter (A-Z)";
            // 
            // lblHasMin
            // 
            lblHasMin.AutoSize = true;
            lblHasMin.Location = new Point(48, 356);
            lblHasMin.Name = "lblHasMin";
            lblHasMin.Size = new Size(246, 20);
            lblHasMin.TabIndex = 11;
            lblHasMin.Text = "1. Must be at least 8 characters long";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 333);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 12;
            label6.Text = "Password Must Have:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(168, 100);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(245, 27);
            txtUser.TabIndex = 13;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(168, 147);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(245, 27);
            txtPass.TabIndex = 13;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(168, 197);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(245, 27);
            txtConfirm.TabIndex = 13;
            txtConfirm.TextChanged += txtConfirm_TextChanged;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(168, 247);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(281, 28);
            cmbRole.TabIndex = 14;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(168, 289);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(72, 24);
            chkStatus.TabIndex = 15;
            chkStatus.Text = "Active";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnShow1
            // 
            btnShow1.BackgroundImage = Properties.Resources.eye_open;
            btnShow1.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow1.FlatAppearance.BorderSize = 0;
            btnShow1.FlatStyle = FlatStyle.Flat;
            btnShow1.Location = new Point(419, 145);
            btnShow1.Name = "btnShow1";
            btnShow1.Size = new Size(30, 30);
            btnShow1.TabIndex = 16;
            btnShow1.UseVisualStyleBackColor = true;
            btnShow1.Click += btnShow1_Click;
            // 
            // btnShow2
            // 
            btnShow2.BackgroundImage = Properties.Resources.eye_open;
            btnShow2.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow2.FlatAppearance.BorderSize = 0;
            btnShow2.FlatStyle = FlatStyle.Flat;
            btnShow2.Location = new Point(419, 193);
            btnShow2.Name = "btnShow2";
            btnShow2.Size = new Size(30, 30);
            btnShow2.TabIndex = 16;
            btnShow2.UseVisualStyleBackColor = true;
            btnShow2.Click += btnShow2_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(105, 483);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(293, 48);
            btnSave.TabIndex = 17;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblCkRetype
            // 
            lblCkRetype.AutoSize = true;
            lblCkRetype.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic);
            lblCkRetype.Location = new Point(168, 228);
            lblCkRetype.Name = "lblCkRetype";
            lblCkRetype.Size = new Size(0, 17);
            lblCkRetype.TabIndex = 18;
            // 
            // lblCkNew
            // 
            lblCkNew.AutoSize = true;
            lblCkNew.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic);
            lblCkNew.Location = new Point(168, 177);
            lblCkNew.Name = "lblCkNew";
            lblCkNew.Size = new Size(0, 17);
            lblCkNew.TabIndex = 19;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(62, 57);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(168, 53);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(245, 27);
            txtFullName.TabIndex = 13;
            // 
            // trmShow
            // 
            trmShow.Interval = 2500;
            trmShow.Tick += trmShow_Tick;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 553);
            ControlBox = false;
            Controls.Add(lblCkRetype);
            Controls.Add(lblCkNew);
            Controls.Add(btnSave);
            Controls.Add(btnShow2);
            Controls.Add(btnShow1);
            Controls.Add(chkStatus);
            Controls.Add(cmbRole);
            Controls.Add(txtConfirm);
            Controls.Add(txtPass);
            Controls.Add(txtFullName);
            Controls.Add(txtUser);
            Controls.Add(lblHasSpec);
            Controls.Add(lblHasDig);
            Controls.Add(lblHasLower);
            Controls.Add(lblHasUpper);
            Controls.Add(lblHasMin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "USER";
            Load += frmUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblHasSpec;
        private Label lblHasDig;
        private Label lblHasLower;
        private Label lblHasUpper;
        private Label lblHasMin;
        private Label label6;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtConfirm;
        private ComboBox cmbRole;
        private CheckBox chkStatus;
        private Button btnShow1;
        private Button btnShow2;
        private Button btnSave;
        private Label lblCkRetype;
        private Label lblCkNew;
        private Label lblFullName;
        private TextBox txtFullName;
        private System.Windows.Forms.Timer trmShow;
    }
}