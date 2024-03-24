namespace application.TeacherUserControls
{
    partial class GradesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage1 = new TabPage();
            button1 = new Button();
            panel2 = new Panel();
            textBoxExamId = new TextBox();
            textBoxstdId = new TextBox();
            dataGridView1 = new DataGridView();
            Courses = new Label();
            panel1 = new Panel();
            label1 = new Label();
            tabControlGrades = new TabControl();
            PrintBtn = new Button();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControlGrades.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(PrintBtn);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(textBoxExamId);
            tabPage1.Controls.Add(textBoxstdId);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(Courses);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(662, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Student Details";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            button1.Location = new Point(558, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Font = new Font("Century Gothic", 10.2F);
            panel2.Location = new Point(42, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 2);
            panel2.TabIndex = 10;
            // 
            // textBoxExamId
            // 
            textBoxExamId.BorderStyle = BorderStyle.None;
            textBoxExamId.Location = new Point(42, 36);
            textBoxExamId.Name = "textBoxExamId";
            textBoxExamId.Size = new Size(204, 17);
            textBoxExamId.TabIndex = 9;
            // 
            // textBoxstdId
            // 
            textBoxstdId.BorderStyle = BorderStyle.None;
            textBoxstdId.Location = new Point(309, 34);
            textBoxstdId.Name = "textBoxstdId";
            textBoxstdId.Size = new Size(204, 17);
            textBoxstdId.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(501, 214);
            dataGridView1.TabIndex = 8;
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            Courses.Location = new Point(45, 19);
            Courses.Name = "Courses";
            Courses.Size = new Size(63, 17);
            Courses.TabIndex = 7;
            Courses.Text = "Exam Id";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Font = new Font("Century Gothic", 10.2F);
            panel1.Location = new Point(309, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 2);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.Location = new Point(312, 17);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 1;
            label1.Text = "Student Id";
            // 
            // tabControlGrades
            // 
            tabControlGrades.Alignment = TabAlignment.Bottom;
            tabControlGrades.Controls.Add(tabPage1);
            tabControlGrades.Font = new Font("Century Gothic", 10.2F);
            tabControlGrades.Location = new Point(0, 2);
            tabControlGrades.Name = "tabControlGrades";
            tabControlGrades.SelectedIndex = 0;
            tabControlGrades.Size = new Size(670, 359);
            tabControlGrades.TabIndex = 1;
            // 
            // PrintBtn
            // 
            PrintBtn.Location = new Point(558, 300);
            PrintBtn.Margin = new Padding(3, 2, 3, 2);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(82, 22);
            PrintBtn.TabIndex = 14;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // GradesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tabControlGrades);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GradesControl";
            Size = new Size(670, 362);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControlGrades.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private Button button1;
        private Panel panel2;
        private TextBox textBoxExamId;
        private TextBox textBoxstdId;
        private DataGridView dataGridView1;
        private Label Courses;
        private Panel panel1;
        private Label label1;
        private TabControl tabControlGrades;
        private Button PrintBtn;
    }
}
