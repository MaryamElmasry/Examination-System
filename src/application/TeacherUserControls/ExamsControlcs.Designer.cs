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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            Courses = new Label();
            label2 = new Label();
            EditExam = new Button();
            DeleteExam = new Button();
            GenerateExam = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 330);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(612, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(378, 18);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 2;
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
            // ExamsControlcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GenerateExam);
            Controls.Add(DeleteExam);
            Controls.Add(EditExam);
            Controls.Add(label2);
            Controls.Add(Courses);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "ExamsControlcs";
            Size = new Size(766, 482);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label Courses;
        private Label label2;
        private Button EditExam;
        private Button DeleteExam;
        private Button GenerateExam;
    }
}
