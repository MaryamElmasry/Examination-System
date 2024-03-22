namespace application.Forms
{
    partial class InstructorForm
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
            panel1 = new Panel();
            Questionsbtn = new Button();
            Topicsbtn = new Button();
            GradesBtn = new Button();
            Examsbtn = new Button();
            MyCoursesbtn = new Button();
            gradesControl1 = new TeacherUserControls.GradesControl();
            myCoursesControl1 = new TeacherUserControls.MyCoursesControl();
            examsControlcs1 = new TeacherUserControls.ExamsControlcs();
            questionsControl1 = new TeacherUserControls.QuestionsControl();
            topicsControl1 = new TeacherUserControls.TopicsControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Questionsbtn);
            panel1.Controls.Add(Topicsbtn);
            panel1.Controls.Add(GradesBtn);
            panel1.Controls.Add(Examsbtn);
            panel1.Controls.Add(MyCoursesbtn);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 426);
            panel1.TabIndex = 0;
            // 
            // Questionsbtn
            // 
            Questionsbtn.BackColor = SystemColors.ActiveCaption;
            Questionsbtn.Font = new Font("Segoe UI Semibold", 12F);
            Questionsbtn.Location = new Point(3, 294);
            Questionsbtn.Name = "Questionsbtn";
            Questionsbtn.Size = new Size(203, 49);
            Questionsbtn.TabIndex = 4;
            Questionsbtn.Text = "Questions";
            Questionsbtn.UseVisualStyleBackColor = false;
            Questionsbtn.Click += Questionsbtn_Click;
            // 
            // Topicsbtn
            // 
            Topicsbtn.BackColor = SystemColors.ActiveCaption;
            Topicsbtn.Font = new Font("Segoe UI Semibold", 12F);
            Topicsbtn.Location = new Point(3, 239);
            Topicsbtn.Name = "Topicsbtn";
            Topicsbtn.Size = new Size(203, 49);
            Topicsbtn.TabIndex = 3;
            Topicsbtn.Text = "Topics";
            Topicsbtn.UseVisualStyleBackColor = false;
            Topicsbtn.Click += Topicsbtn_Click;
            // 
            // GradesBtn
            // 
            GradesBtn.BackColor = SystemColors.ActiveCaption;
            GradesBtn.Font = new Font("Segoe UI Semibold", 12F);
            GradesBtn.Location = new Point(3, 184);
            GradesBtn.Name = "GradesBtn";
            GradesBtn.Size = new Size(203, 49);
            GradesBtn.TabIndex = 2;
            GradesBtn.Text = "Grades";
            GradesBtn.UseVisualStyleBackColor = false;
            GradesBtn.Click += GradesBtn_Click;
            // 
            // Examsbtn
            // 
            Examsbtn.BackColor = SystemColors.ActiveCaption;
            Examsbtn.Font = new Font("Segoe UI Semibold", 12F);
            Examsbtn.Location = new Point(3, 129);
            Examsbtn.Name = "Examsbtn";
            Examsbtn.Size = new Size(203, 49);
            Examsbtn.TabIndex = 1;
            Examsbtn.Text = "Exams";
            Examsbtn.UseVisualStyleBackColor = false;
            Examsbtn.Click += Examsbtn_Click;
            // 
            // MyCoursesbtn
            // 
            MyCoursesbtn.BackColor = SystemColors.ActiveCaption;
            MyCoursesbtn.Font = new Font("Segoe UI Semibold", 12F);
            MyCoursesbtn.Location = new Point(3, 74);
            MyCoursesbtn.Name = "MyCoursesbtn";
            MyCoursesbtn.Size = new Size(203, 49);
            MyCoursesbtn.TabIndex = 0;
            MyCoursesbtn.Text = "MyCourses";
            MyCoursesbtn.UseVisualStyleBackColor = false;
            MyCoursesbtn.Click += MyCoursesbtn_Click;
            // 
            // gradesControl1
            // 
            gradesControl1.BackColor = SystemColors.ActiveCaption;
            gradesControl1.Location = new Point(224, 12);
            gradesControl1.Name = "gradesControl1";
            gradesControl1.Size = new Size(766, 482);
            gradesControl1.TabIndex = 5;
            // 
            // myCoursesControl1
            // 
            myCoursesControl1.Location = new Point(224, 12);
            myCoursesControl1.Name = "myCoursesControl1";
            myCoursesControl1.Size = new Size(766, 482);
            myCoursesControl1.TabIndex = 6;
            // 
            // examsControlcs1
            // 
            examsControlcs1.Location = new Point(224, 12);
            examsControlcs1.Name = "examsControlcs1";
            examsControlcs1.Size = new Size(766, 482);
            examsControlcs1.TabIndex = 7;
            // 
            // questionsControl1
            // 
            questionsControl1.Location = new Point(224, 12);
            questionsControl1.Name = "questionsControl1";
            questionsControl1.Size = new Size(766, 472);
            questionsControl1.TabIndex = 8;
            // 
            // topicsControl1
            // 
            topicsControl1.Location = new Point(221, 2);
            topicsControl1.Name = "topicsControl1";
            topicsControl1.Size = new Size(766, 482);
            topicsControl1.TabIndex = 9;
            topicsControl1.Load += topicsControl1_Load;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 486);
            Controls.Add(topicsControl1);
            Controls.Add(questionsControl1);
            Controls.Add(examsControlcs1);
            Controls.Add(myCoursesControl1);
            Controls.Add(gradesControl1);
            Controls.Add(panel1);
            Name = "InstructorForm";
            Text = "Instructor";
            Load += InstructorForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button MyCoursesbtn;
        private Button Examsbtn;
        private Button Questionsbtn;
        private Button Topicsbtn;
        private Button GradesBtn;
        private TeacherUserControls.GradesControl gradesControl1;
        private TeacherUserControls.MyCoursesControl myCoursesControl1;
        private TeacherUserControls.ExamsControlcs examsControlcs1;
        private TeacherUserControls.QuestionsControl questionsControl1;
        private TeacherUserControls.TopicsControl topicsControl1;
    }
}