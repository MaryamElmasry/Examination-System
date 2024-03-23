namespace application.Forms
{
    partial class ReportsForm
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
            btnSR = new Button();
            label1 = new Label();
            txtDeptID = new TextBox();
            textBoxGrade = new TextBox();
            label2 = new Label();
            btnGrades = new Button();
            SuspendLayout();
            // 
            // btnSR
            // 
            btnSR.BackColor = Color.Teal;
            btnSR.FlatAppearance.BorderSize = 0;
            btnSR.FlatStyle = FlatStyle.Flat;
            btnSR.Font = new Font("Segoe UI", 11F);
            btnSR.ForeColor = SystemColors.ButtonFace;
            btnSR.Location = new Point(439, 51);
            btnSR.Name = "btnSR";
            btnSR.Size = new Size(234, 36);
            btnSR.TabIndex = 6;
            btnSR.Text = "Generate Students Report";
            btnSR.UseVisualStyleBackColor = false;
            btnSR.Click += btnSR_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 58);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 7;
            label1.Text = "Department ID";
            // 
            // txtDeptID
            // 
            txtDeptID.Location = new Point(182, 58);
            txtDeptID.Name = "txtDeptID";
            txtDeptID.Size = new Size(216, 23);
            txtDeptID.TabIndex = 8;
            // 
            // textBoxGrade
            // 
            textBoxGrade.Location = new Point(182, 160);
            textBoxGrade.Name = "textBoxGrade";
            textBoxGrade.Size = new Size(216, 23);
            textBoxGrade.TabIndex = 11;
            textBoxGrade.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(27, 158);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 10;
            label2.Text = "Student ID";
            // 
            // btnGrades
            // 
            btnGrades.BackColor = Color.Teal;
            btnGrades.FlatAppearance.BorderSize = 0;
            btnGrades.FlatStyle = FlatStyle.Flat;
            btnGrades.Font = new Font("Segoe UI", 11F);
            btnGrades.ForeColor = SystemColors.ButtonFace;
            btnGrades.Location = new Point(439, 151);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(234, 36);
            btnGrades.TabIndex = 9;
            btnGrades.Text = "Generate Students Grades \r\n";
            btnGrades.UseVisualStyleBackColor = false;
            btnGrades.Click += button1_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textBoxGrade);
            Controls.Add(label2);
            Controls.Add(btnGrades);
            Controls.Add(txtDeptID);
            Controls.Add(label1);
            Controls.Add(btnSR);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GenerateForm";
            Load += ReportsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSR;
        private Label label1;
        private TextBox txtDeptID;
        private TextBox textBoxGrade;
        private Label label2;
        private Button btnGrades;
    }
}