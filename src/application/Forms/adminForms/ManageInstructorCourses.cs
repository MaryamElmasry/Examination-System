using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using application.Models;
using Microsoft.EntityFrameworkCore;

namespace application.Forms.adminForms
{
    public partial class ManageInstructorCourses : Form
    {
        int instructorId;
        iti_ExamContext db = new iti_ExamContext();
        public ManageInstructorCourses(int instructorId)
        {
            InitializeComponent();
            this.instructorId = instructorId;
            //Populate the list boxes
            populateListBoxes();
        }


        private void populateListBoxes()
        {
            //Get all courses in the instructor's branch by using db.Database.SqlQuery
            var allCourses =db.Database.SqlQuery<CourseResult>($"exec GetAllCoursesInBranchByInstructorID {instructorId}").ToList();
            listBoxBranchCourses.DataSource = allCourses;
            listBoxBranchCourses.DisplayMember = "CourseName";
            listBoxBranchCourses.ValueMember = "CourseID";

            //Get all courses the instructor is enrolled in by using db.Database.SqlQuery
            var insCourses = db.Database.SqlQuery<CourseResult>($"exec GetCoursesByInstructorID {instructorId}").ToList();
            listBoxInsCourses.DataSource = insCourses;
            listBoxInsCourses.DisplayMember = "CourseName";
            listBoxInsCourses.ValueMember = "CourseID";

            

        }

       private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //Add the selected course to the instructor's courses
            
            try
            {
                int courseID = (int)listBoxBranchCourses.SelectedValue;
                db.Database.ExecuteSql($"exec AddInstructorToCourse {courseID}, {instructorId}");
                populateListBoxes();
            }
            catch 
            {
                MessageBox.Show("Already Enrolled");
            }
           



        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
           try
            {
                int courseID = (int)listBoxInsCourses.SelectedValue;
                db.Database.ExecuteSql($"exec RemoveInstructorFromCourse {courseID}, {instructorId}");
                populateListBoxes();
            }
            catch 
            {
                MessageBox.Show("No Course is selected");
            }

        }
    }
    public class CourseResult
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    }
}
