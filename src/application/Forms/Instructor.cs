using application.Models;
using application.projectionEntities;
using application.TeacherUserControls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application.Forms
{
    public partial class InstructorForm : Form
    {
        public Instructor instructor;
        public Instructor owner;
        public InstructorForm()
        {
            InitializeComponent();

        }
        public InstructorForm(Instructor instructor)
        {
            InitializeComponent();
            this.instructor = instructor;
        }

        private void MyCoursesbtn_Click(object sender, EventArgs e)
        {
            myCoursesControl1.Visible = true;
            examsControlcs1.Visible = false;
            topicsControl1.Visible = false;
            gradesControl1.Visible = false;
            questionsControl1.Visible = false;
        }

        private void Examsbtn_Click(object sender, EventArgs e)
        {
            myCoursesControl1.Visible = false;
            examsControlcs1.Visible = true;
            topicsControl1.Visible = false;
            gradesControl1.Visible = false;
            questionsControl1.Visible = false;
        }

        private void GradesBtn_Click(object sender, EventArgs e)
        {
            myCoursesControl1.Visible = false;
            examsControlcs1.Visible = false;
            topicsControl1.Visible = false;
            gradesControl1.Visible = true;
            questionsControl1.Visible = false;
        }

        private void Topicsbtn_Click(object sender, EventArgs e)
        {
            myCoursesControl1.Visible = false;
            examsControlcs1.Visible = false;
            topicsControl1.Visible = true;
            gradesControl1.Visible = false;
            questionsControl1.Visible = false;
        }

        private void Questionsbtn_Click(object sender, EventArgs e)
        {
            myCoursesControl1.Visible = false;
            examsControlcs1.Visible = false;
            topicsControl1.Visible = false;
            gradesControl1.Visible = false;
            questionsControl1.Visible = true;
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new iti_ExamContext())
            {
                populateCourseList(ctx);
                populateQuestionGV(ctx);
            }

        }
        private void populateCourseList(iti_ExamContext ctx)
        {
            var courses = ctx.Courses.FromSqlRaw("EXEC GetCoursesIns {0}", 1).ToList();
            var combo = questionsControl1.Controls["courselst"] as ComboBox;
            combo.DataSource = courses;
            combo.DisplayMember = "CourseName";
            combo.ValueMember = "CourseID";
            combo.SelectedIndex = 0;

        }
        private void populateQuestionGV(iti_ExamContext ctx)
        {
            var questions = ctx.PCourses
             .FromSqlRaw("EXEC GetAllQuestions {0}", 4)
             .AsEnumerable()
             .ToList()

             ;

            var questionsGV = questionsControl1.Controls["QuestionsGV"] as DataGridView;
            questionsGV.DataSource = questions;
        }

        private void topicsControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
