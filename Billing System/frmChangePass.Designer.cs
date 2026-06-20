namespace Billing_System
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            btnBack = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCurrent = new TextBox();
            txtNewPass = new TextBox();
            txtRetype = new TextBox();
            btnCurrent = new Button();
            btnNew = new Button();
            btnRetype = new Button();
            tmrShow = new System.Windows.Forms.Timer(components);
            lblCkNew = new Label();
            lblCkRetype = new Label();
            lblCkCurrent = new Label();
            label5 = new Label();
            lblHasMin = new Label();
            lblHasUpper = new Label();
            lblHasLower = new Label();
            lblHasDig = new Label();
            lblHasSpec = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(12, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 0;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(427, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(30, 30);
            btnSave.TabIndex = 0;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 18);
            label1.Name = "label1";
            label1.Size = new Size(241, 31);
            label1.TabIndex = 1;
            label1.Text = "CHANGE PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 65);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Current Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 116);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 167);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 2;
            label4.Text = "Re-type New Password";
            // 
            // txtCurrent
            // 
            txtCurrent.Location = new Point(206, 62);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(215, 27);
            txtCurrent.TabIndex = 3;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(206, 113);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(215, 27);
            txtNewPass.TabIndex = 3;
            txtNewPass.TextChanged += txtNewPass_TextChanged;
            // 
            // txtRetype
            // 
            txtRetype.BackColor = SystemColors.Window;
            txtRetype.ForeColor = SystemColors.WindowText;
            txtRetype.Location = new Point(206, 164);
            txtRetype.Name = "txtRetype";
            txtRetype.Size = new Size(215, 27);
            txtRetype.TabIndex = 3;
            txtRetype.TextChanged += txtRetype_TextChanged;
            // 
            // btnCurrent
            // 
            btnCurrent.BackgroundImage = Properties.Resources.eye_open;
            btnCurrent.BackgroundImageLayout = ImageLayout.Stretch;
            btnCurrent.FlatAppearance.BorderSize = 0;
            btnCurrent.FlatStyle = FlatStyle.Flat;
            btnCurrent.Location = new Point(427, 61);
            btnCurrent.Name = "btnCurrent";
            btnCurrent.Size = new Size(30, 30);
            btnCurrent.TabIndex = 4;
            btnCurrent.UseVisualStyleBackColor = true;
            btnCurrent.Click += btnCurrent_Click;
            // 
            // btnNew
            // 
            btnNew.BackgroundImage = Properties.Resources.eye_open;
            btnNew.BackgroundImageLayout = ImageLayout.Stretch;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Location = new Point(427, 112);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(30, 30);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnRetype
            // 
            btnRetype.BackgroundImage = Properties.Resources.eye_open;
            btnRetype.BackgroundImageLayout = ImageLayout.Stretch;
            btnRetype.FlatAppearance.BorderSize = 0;
            btnRetype.FlatStyle = FlatStyle.Flat;
            btnRetype.Location = new Point(427, 163);
            btnRetype.Name = "btnRetype";
            btnRetype.Size = new Size(30, 30);
            btnRetype.TabIndex = 4;
            btnRetype.UseVisualStyleBackColor = true;
            btnRetype.Click += btnRetype_Click;
            // 
            // tmrShow
            // 
            tmrShow.Interval = 2500;
            tmrShow.Tick += tmrShow_Tick;
            // 
            // lblCkNew
            // 
            lblCkNew.AutoSize = true;
            lblCkNew.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic);
            lblCkNew.Location = new Point(206, 141);
            lblCkNew.Name = "lblCkNew";
            lblCkNew.Size = new Size(50, 17);
            lblCkNew.TabIndex = 5;
            lblCkNew.Text = "checker";
            // 
            // lblCkRetype
            // 
            lblCkRetype.AutoSize = true;
            lblCkRetype.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic);
            lblCkRetype.Location = new Point(206, 194);
            lblCkRetype.Name = "lblCkRetype";
            lblCkRetype.Size = new Size(50, 17);
            lblCkRetype.TabIndex = 5;
            lblCkRetype.Text = "checker";
            // 
            // lblCkCurrent
            // 
            lblCkCurrent.AutoSize = true;
            lblCkCurrent.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic);
            lblCkCurrent.Location = new Point(206, 90);
            lblCkCurrent.Name = "lblCkCurrent";
            lblCkCurrent.Size = new Size(50, 17);
            lblCkCurrent.TabIndex = 5;
            lblCkCurrent.Text = "checker";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 224);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 6;
            label5.Text = "Password Must Have:";
            // 
            // lblHasMin
            // 
            lblHasMin.AutoSize = true;
            lblHasMin.Location = new Point(53, 247);
            lblHasMin.Name = "lblHasMin";
            lblHasMin.Size = new Size(246, 20);
            lblHasMin.TabIndex = 6;
            lblHasMin.Text = "1. Must be at least 8 characters long";
            // 
            // lblHasUpper
            // 
            lblHasUpper.AutoSize = true;
            lblHasUpper.Location = new Point(53, 269);
            lblHasUpper.Name = "lblHasUpper";
            lblHasUpper.Size = new Size(362, 20);
            lblHasUpper.TabIndex = 6;
            lblHasUpper.Text = "2. Must contain at least one (1) uppercase letter (A-Z)";
            // 
            // lblHasLower
            // 
            lblHasLower.AutoSize = true;
            lblHasLower.Location = new Point(53, 291);
            lblHasLower.Name = "lblHasLower";
            lblHasLower.Size = new Size(356, 20);
            lblHasLower.TabIndex = 6;
            lblHasLower.Text = "3. Must contain at least one (1) lowercase letter (a-z)";
            // 
            // lblHasDig
            // 
            lblHasDig.AutoSize = true;
            lblHasDig.Location = new Point(53, 313);
            lblHasDig.Name = "lblHasDig";
            lblHasDig.Size = new Size(340, 20);
            lblHasDig.TabIndex = 6;
            lblHasDig.Text = "4. Must contain at least one (1) numeric digit (0-9)";
            // 
            // lblHasSpec
            // 
            lblHasSpec.AutoSize = true;
            lblHasSpec.Location = new Point(53, 335);
            lblHasSpec.Name = "lblHasSpec";
            lblHasSpec.Size = new Size(431, 20);
            lblHasSpec.TabIndex = 6;
            lblHasSpec.Text = "5. Must contain at least one (1) special character (e.g. !@#$%^&*)";
            // 
            // frmChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 375);
            ControlBox = false;
            Controls.Add(lblHasSpec);
            Controls.Add(lblHasDig);
            Controls.Add(lblHasLower);
            Controls.Add(lblHasUpper);
            Controls.Add(lblHasMin);
            Controls.Add(label5);
            Controls.Add(lblCkCurrent);
            Controls.Add(lblCkRetype);
            Controls.Add(lblCkNew);
            Controls.Add(btnRetype);
            Controls.Add(btnNew);
            Controls.Add(btnCurrent);
            Controls.Add(txtRetype);
            Controls.Add(txtNewPass);
            Controls.Add(txtCurrent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmChangePass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCurrent;
        private TextBox txtNewPass;
        private TextBox txtRetype;
        private Button btnCurrent;
        private Button btnNew;
        private Button btnRetype;
        private System.Windows.Forms.Timer tmrShow;
        private Label lblCkNew;
        private Label lblCkRetype;
        private Label lblCkCurrent;
        private Label label5;
        private Label lblHasMin;
        private Label lblHasUpper;
        private Label lblHasLower;
        private Label lblHasDig;
        private Label lblHasSpec;
    }
}