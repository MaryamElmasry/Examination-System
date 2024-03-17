namespace application.TeacherUserControls
{
    partial class ExamsControlcs
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
            ExamsGV = new DataGridView();
            crsList = new ComboBox();
            DeptList = new ComboBox();
            Courses = new Label();
            label2 = new Label();
            EditExam = new Button();
            DeleteExam = new Button();
            GenerateExam = new Button();
            PrintBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ExamsGV).BeginInit();
            SuspendLayout();
            // 
            // ExamsGV
            // 
            ExamsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExamsGV.Location = new Point(3, 66);
            ExamsGV.Name = "ExamsGV";
            ExamsGV.RowHeadersWidth = 51;
            ExamsGV.Size = new Size(760, 330);
            ExamsGV.TabIndex = 0;
            ExamsGV.SelectionChanged += SelectionChanged;
            // 
            // crsList
            // 
            crsList.FormattingEnabled = true;
            crsList.Location = new Point(612, 18);
            crsList.Name = "crsList";
            crsList.Size = new Size(151, 28);
            crsList.TabIndex = 1;
            crsList.SelectedIndexChanged += updateGV;
            crsList.DataSourceChanged += updateGV;
            // 
            // DeptList
            // 
            DeptList.FormattingEnabled = true;
            DeptList.Location = new Point(378, 18);
            DeptList.Name = "DeptList";
            DeptList.Size = new Size(151, 28);
            DeptList.TabIndex = 2;
            DeptList.SelectedIndexChanged += DeptListChanged;
            // 
            // Courses
            // 
            Courses.AutoSize = true;
            Courses.Location = new Point(546, 21);
            Courses.Name = "Courses";
            Courses.Size = new Size(60, 20);
            Courses.TabIndex = 3;
            Courses.Text = "Courses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 21);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "Departments";
            // 
            // EditExam
            // 
            EditExam.Location = new Point(481, 423);
            EditExam.Name = "EditExam";
            EditExam.Size = new Size(94, 29);
            EditExam.TabIndex = 5;
            EditExam.Text = "Edit Exam";
            EditExam.UseVisualStyleBackColor = true;
            // 
            // DeleteExam
            // 
            DeleteExam.Location = new Point(581, 423);
            DeleteExam.Name = "DeleteExam";
            DeleteExam.Size = new Size(159, 29);
            DeleteExam.TabIndex = 6;
            DeleteExam.Text = "Delete Exam";
            DeleteExam.UseVisualStyleBackColor = true;
            // 
            // GenerateExam
            // 
            GenerateExam.Location = new Point(317, 423);
            GenerateExam.Name = "GenerateExam";
            GenerateExam.Size = new Size(158, 29);
            GenerateExam.TabIndex = 7;
            GenerateExam.Text = "Generate Exam";
            GenerateExam.UseVisualStyleBackColor = true;
            GenerateExam.Click += GenerateExam_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.Location = new Point(217, 423);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(94, 29);
            PrintBtn.TabIndex = 8;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // ExamsControlcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PrintBtn);
            Controls.Add(GenerateExam);
            Controls.Add(DeleteExam);
            Controls.Add(EditExam);
            Controls.Add(label2);
            Controls.Add(Courses);
            Controls.Add(DeptList);
            Controls.Add(crsList);
            Controls.Add(ExamsGV);
            Name = "ExamsControlcs";
            Size = new Size(766, 482);
            Load += ExamsControlcs_Load;
            ((System.ComponentModel.ISupportInitialize)ExamsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ExamsGV;
        private ComboBox crsList;
        private ComboBox DeptList;
        private Label Courses;
        private Label label2;
        private Button EditExam;
        private Button DeleteExam;
        private Button GenerateExam;
        private Button PrintBtn;
    }
}
