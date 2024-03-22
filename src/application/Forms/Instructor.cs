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
        public InstructorForm(Instructor instructor):this()
        {
            
            this.instructor = instructor;
            examsControlcs1.ins = this.instructor;
            questionsControl1.ins = this.instructor;
            myCoursesControl1.ins = this.instructor;

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
           

        }
 

        private void topicsControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
