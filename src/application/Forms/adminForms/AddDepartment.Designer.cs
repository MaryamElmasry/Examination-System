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
            btnAddDepartment.Location = new Point(205, 232);
            btnAddDepartment.Margin = new Padding(3, 4, 3, 4);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(175, 48);
            btnAddDepartment.TabIndex = 5;
            btnAddDepartment.Text = "Add department";
            btnAddDepartment.UseVisualStyleBackColor = false;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(39, 85);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 4;
            label1.Text = "Department Name";
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(205, 88);
            txtDeptName.Margin = new Padding(3, 4, 3, 4);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(246, 27);
            txtDeptName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(39, 153);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 7;
            label2.Text = "Branch name";
            // 
            // cbBranches
            // 
            cbBranches.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBranches.FormattingEnabled = true;
            cbBranches.Location = new Point(205, 156);
            cbBranches.Margin = new Padding(3, 4, 3, 4);
            cbBranches.Name = "cbBranches";
            cbBranches.Size = new Size(246, 28);
            cbBranches.TabIndex = 8;
            // 
            // AddDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 337);
            Controls.Add(cbBranches);
            Controls.Add(label2);
            Controls.Add(btnAddDepartment);
            Controls.Add(label1);
            Controls.Add(txtDeptName);
            Margin = new Padding(3, 4, 3, 4);
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