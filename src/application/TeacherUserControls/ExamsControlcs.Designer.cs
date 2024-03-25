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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ExamsGV = new DataGridView();
            crsList = new ComboBox();
            DeptList = new ComboBox();
            Courses = new Label();
            label2 = new Label();
            DeleteExam = new Button();
            GenerateExam = new Button();
            PrintBtn = new Button();
            Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)ExamsGV).BeginInit();
            SuspendLayout();
            // 
            // ExamsGV
            // 
            ExamsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ExamsGV.DefaultCellStyle = dataGridViewCellStyle1;
            ExamsGV.Location = new Point(3, 66);
            ExamsGV.Name = "ExamsGV";
            ExamsGV.RowHeadersWidth = 51;
            ExamsGV.Size = new Size(760, 330);
            ExamsGV.TabIndex = 0;
            ExamsGV.SelectionChanged += SelectionChanged;
            // 
            // crsList
            // 
            crsList.Font = new Font("Segoe UI Semibold", 9F);
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
            DeptList.Font = new Font("Segoe UI Semibold", 9F);
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
            Courses.Font = new Font("Segoe UI Semibold", 9F);
            Courses.Location = new Point(546, 21);
            Courses.Name = "Courses";
            Courses.Size = new Size(62, 20);
            Courses.TabIndex = 3;
            Courses.Text = "Courses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F);
            label2.Location = new Point(277, 21);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 4;
            label2.Text = "Departments";
            // 
            // DeleteExam
            // 
            DeleteExam.BackColor = Color.Red;
            DeleteExam.Font = new Font("Segoe UI Semibold", 11F);
            DeleteExam.Location = new Point(481, 423);
            DeleteExam.Name = "DeleteExam";
            DeleteExam.Size = new Size(159, 38);
            DeleteExam.TabIndex = 6;
            DeleteExam.Text = "Delete Exam";
            DeleteExam.UseVisualStyleBackColor = false;
            DeleteExam.Click += DeleteExam_Click;
            // 
            // GenerateExam
            // 
            GenerateExam.BackColor = SystemColors.ActiveCaption;
            GenerateExam.Font = new Font("Segoe UI Semibold", 11F);
            GenerateExam.Location = new Point(317, 423);
            GenerateExam.Name = "GenerateExam";
            GenerateExam.Size = new Size(158, 38);
            GenerateExam.TabIndex = 7;
            GenerateExam.Text = "Generate Exam";
            GenerateExam.UseVisualStyleBackColor = false;
            GenerateExam.Click += GenerateExam_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = SystemColors.ActiveCaption;
            PrintBtn.Font = new Font("Segoe UI Semibold", 11F);
            PrintBtn.Location = new Point(217, 423);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(94, 38);
            PrintBtn.TabIndex = 8;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.CornflowerBlue;
            Refresh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            Refresh.Location = new Point(117, 428);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(94, 33);
            Refresh.TabIndex = 9;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // ExamsControlcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Refresh);
            Controls.Add(PrintBtn);
            Controls.Add(GenerateExam);
            Controls.Add(DeleteExam);
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
        private Button DeleteExam;
        private Button GenerateExam;
        private Button PrintBtn;
        private Button Refresh;
    }
}
