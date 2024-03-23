namespace application.Forms.adminForms
{
    partial class AddStudent
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
            btnAddStudent = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            cbDept = new ComboBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            txtNumber = new TextBox();
            label6 = new Label();
            M = new RadioButton();
            F = new RadioButton();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.Teal;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI", 11F);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(151, 282);
            btnAddStudent.Margin = new Padding(3, 4, 3, 4);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(175, 48);
            btnAddStudent.TabIndex = 5;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddDepartment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 4;
            label1.Text = "UserName";
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 26);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 27);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(44, 249);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 7;
            label2.Text = "Deptartment";
            // 
            // cbDept
            // 
            cbDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDept.FormattingEnabled = true;
            cbDept.Location = new Point(190, 248);
            cbDept.Margin = new Padding(3, 4, 3, 4);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(246, 28);
            cbDept.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(44, 62);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 64);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 27);
            txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(44, 99);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(190, 102);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(246, 27);
            txtPassword.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(44, 137);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 14;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(190, 139);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(246, 27);
            txtAddress.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(44, 174);
            label7.Name = "label7";
            label7.Size = new Size(139, 28);
            label7.TabIndex = 16;
            label7.Text = "PhoneNumber";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(190, 177);
            txtNumber.Margin = new Padding(3, 4, 3, 4);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(246, 27);
            txtNumber.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(44, 212);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 17;
            label6.Text = "Gender";
            // 
            // M
            // 
            M.AutoSize = true;
            M.Location = new Point(199, 212);
            M.Margin = new Padding(2, 2, 2, 2);
            M.Name = "M";
            M.Size = new Size(63, 24);
            M.TabIndex = 18;
            M.TabStop = true;
            M.Text = "Male";
            M.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            F.AutoSize = true;
            F.Location = new Point(329, 212);
            F.Margin = new Padding(2, 2, 2, 2);
            F.Name = "F";
            F.Size = new Size(78, 24);
            F.TabIndex = 19;
            F.TabStop = true;
            F.Text = "Female";
            F.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 338);
            Controls.Add(F);
            Controls.Add(M);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtNumber);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(cbDept);
            Controls.Add(label2);
            Controls.Add(btnAddStudent);
            Controls.Add(label1);
            Controls.Add(txtName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddStudent";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private ComboBox cbDept;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtNumber;
        private Label label6;
        private RadioButton M;
        private RadioButton F;
    }
}