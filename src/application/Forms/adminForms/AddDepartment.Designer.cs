namespace application.Forms.adminForms
{
    partial class AddDepartment
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
            btnAddDepartment = new Button();
            label1 = new Label();
            txtDeptName = new TextBox();
            label2 = new Label();
            cbBranches = new ComboBox();
            SuspendLayout();
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.BackColor = Color.Teal;
            btnAddDepartment.FlatAppearance.BorderSize = 0;
            btnAddDepartment.FlatStyle = FlatStyle.Flat;
            btnAddDepartment.Font = new Font("Segoe UI", 11F);
            btnAddDepartment.ForeColor = SystemColors.ButtonFace;
            btnAddDepartment.Location = new Point(242, 174);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(153, 36);
            btnAddDepartment.TabIndex = 5;
            btnAddDepartment.Text = "Add department";
            btnAddDepartment.UseVisualStyleBackColor = false;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 64);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 4;
            label1.Text = "Department Name";
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(179, 66);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(216, 23);
            txtDeptName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 115);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 7;
            label2.Text = "Branch name";
            // 
            // cbBranches
            // 
            cbBranches.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranches.FormattingEnabled = true;
            cbBranches.Location = new Point(179, 117);
            cbBranches.Name = "cbBranches";
            cbBranches.Size = new Size(216, 23);
            cbBranches.TabIndex = 8;
            // 
            // AddDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 253);
            Controls.Add(cbBranches);
            Controls.Add(label2);
            Controls.Add(btnAddDepartment);
            Controls.Add(label1);
            Controls.Add(txtDeptName);
            Name = "AddDepartment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDepartment;
        private Label label1;
        private TextBox txtDeptName;
        private Label label2;
        private ComboBox cbBranches;
    }
}