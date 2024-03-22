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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            StudentsGV = new DataGridView();
            ExamsGV = new DataGridView();
            DeptsList = new ComboBox();
            CoursesList = new ComboBox();
            label1 = new Label();
            Departments = new Label();
            printBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentsGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExamsGV).BeginInit();
            SuspendLayout();
            // 
            // StudentsGV
            // 
            StudentsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            StudentsGV.DefaultCellStyle = dataGridViewCellStyle1;
            StudentsGV.Location = new Point(19, 116);
            StudentsGV.Name = "StudentsGV";
            StudentsGV.RowHeadersWidth = 51;
            StudentsGV.Size = new Size(345, 226);
            StudentsGV.TabIndex = 0;
            StudentsGV.SelectionChanged += UpdateExamGrid;
            // 
            // ExamsGV
            // 
            ExamsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExamsGV.Location = new Point(383, 116);
            ExamsGV.Name = "ExamsGV";
            ExamsGV.RowHeadersWidth = 51;
            ExamsGV.Size = new Size(367, 226);
            ExamsGV.TabIndex = 1;
            ExamsGV.SelectionChanged += updateSelectedItem;
            // 
            // DeptsList
            // 
            DeptsList.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeptsList.FormattingEnabled = true;
            DeptsList.Location = new Point(282, 15);
            DeptsList.Name = "DeptsList";
            DeptsList.Size = new Size(151, 39);
            DeptsList.TabIndex = 2;
            DeptsList.SelectedIndexChanged += UpdatecrsList;
            // 
            // CoursesList
            // 
            CoursesList.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            CoursesList.FormattingEnabled = true;
            CoursesList.Location = new Point(599, 15);
            CoursesList.Name = "CoursesList";
            CoursesList.Size = new Size(151, 39);
            CoursesList.TabIndex = 3;
            CoursesList.SelectedValueChanged += UpdateStudents;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(497, 18);
            label1.Name = "label1";
            label1.Size = new Size(96, 31);
            label1.TabIndex = 4;
            label1.Text = "Courses";
            label1.Click += label1_Click;
            // 
            // Departments
            // 
            Departments.AutoSize = true;
            Departments.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Departments.Location = new Point(126, 18);
            Departments.Name = "Departments";
            Departments.Size = new Size(150, 31);
            Departments.TabIndex = 5;
            Departments.Text = "Departments";
            // 
            // printBtn
            // 
            printBtn.Font = new Font("Segoe UI", 15F);
            printBtn.Location = new Point(640, 402);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(110, 47);
            printBtn.TabIndex = 6;
            printBtn.Text = "print";
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // GradesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(printBtn);
            Controls.Add(Departments);
            Controls.Add(label1);
            Controls.Add(CoursesList);
            Controls.Add(DeptsList);
            Controls.Add(ExamsGV);
            Controls.Add(StudentsGV);
            Name = "GradesControl";
            Size = new Size(766, 482);
            Load += GradesControl_Load;
            ((System.ComponentModel.ISupportInitialize)StudentsGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExamsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentsGV;
        private DataGridView ExamsGV;
        private ComboBox DeptsList;
        private ComboBox CoursesList;
        private Label label1;
        private Label Departments;
        private Button printBtn;
    }
}
