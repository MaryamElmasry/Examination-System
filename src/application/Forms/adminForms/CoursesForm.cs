using application.Models;
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

namespace application.Forms.adminForms
{

    public partial class CoursesForm : Form
    {
        iti_ExamContext db = new iti_ExamContext();
        List<Course> courses;
        public CoursesForm()
        {
            InitializeComponent();
            populateCourseList();
            populateCourseDepartments((int)lstCourses.SelectedValue);
        }

        public void populateCourseList()
        {
            //populate the list with the courses
            lstCourses.DataSource = db
                        .Courses
                        .FromSql($"exec getAllCourses").ToList();
            lstCourses.DisplayMember = "CourseName";
            lstCourses.ValueMember = "CourseID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear all the stored unchecked departments 
            uncheckedDepartments.Clear();
            //get the course id
            int selectedID = getSelectedCourseID();

            txtCourseName.Text = db
                                    .Courses
                                    .SingleOrDefault(c => c.CourseID == selectedID).CourseName.ToString();


            //get the course topics and populate them to the checkedlist
            populateCourseTopics(selectedID);

            //populate course departments
            populateCourseDepartments(selectedID);

            //populate course instructors
            populateCourseInstructors(selectedID);
        }

        private void populateCourseInstructors(int courseID)
        {
            //get the selected departments
            var selectedDepts = clCourseDepts.CheckedItems;

            var allInstructorsInDepartments = new List<User>();

            //get all instructors in the selected depts
            foreach (Department dept in selectedDepts)
            {
                //get the instructors within that dept
                List<User> instructors = db.Users.FromSql($"exec getInstructorsOfDepartments {dept.DeptID}").ToList();
                allInstructorsInDepartments.AddRange(instructors);
            }
            //var allInstructors = db.Users.FromSql($"exec getAllInstructors").ToList();
            var courseInstructors = db.Users.FromSql($"exec getCourseInstructorsInfo {courseID}").ToList();

            cLInstructors.DataSource = allInstructorsInDepartments;
            cLInstructors.DisplayMember = "UserName";
            cLInstructors.ValueMember = "UserID";

            for (int i = 0; i < cLInstructors.Items.Count; i++)
            {
                cLInstructors.SetItemChecked(i, false);
            }

            if (cLInstructors.Items.Count > 0)
            {
                if (courseInstructors != null)
                {
                    foreach (var item in courseInstructors)
                    {
                        int itemIndex = cLInstructors.Items.IndexOf(item);
                        if (cLInstructors.Items.Contains(item))
                        {
                            cLInstructors.SetItemChecked(itemIndex, true);
                        }

                    }
                }

            }

        }

        private int getSelectedCourseID()
        {
            int selectedID;
            if ((lstCourses.SelectedValue as Course) != null)
            {
                selectedID = int.Parse((lstCourses.SelectedValue as Course).CourseID.ToString());
            }
            else
            {
                selectedID = int.Parse(lstCourses.SelectedValue.ToString());
            }
            return selectedID;
        }

        private void populateCourseDepartments(int courseID)
        {
            //get all departments and populate them in the departments list
            clCourseDepts.DataSource = db
                                       .Departments
                                       .FromSql($"exec GetAllDepartments")
                                       .ToList();
            clCourseDepts.DisplayMember = "DeptName";
            clCourseDepts.ValueMember = "DeptID";
            //get Course departments
            int courseId = getSelectedCourseID();
            var courseDepts = db
                                .Departments
                                .FromSql($"exec getCourseDepartmentsAllInfo {courseId}")
                                .ToList();


            //uncheck all the items
            foreach (var itemIndex in Enumerable.Range(0, clCourseDepts.Items.Count))
            {
                clCourseDepts.SetItemChecked(itemIndex, false);
            }
            //select the course departments
            foreach (var item in courseDepts)
            {
                clCourseDepts.SetItemChecked(clCourseDepts.Items.IndexOf(item), true);
            }
        }

        private void populateCourseTopics(int courseID)
        {
            //get the course topics and populate them to the checkedlist
            var courseTopics = db.CourseTopics.FromSql($"exec getCourseTopics {courseID}").ToList();
            cLTopics.DataSource = courseTopics;
            cLTopics.DisplayMember = "Topic";
            cLTopics.ValueMember = "CourseID";
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            //get the topic name and validate it
            string topicName = txtTopic.Text;
            if (topicName.Length > 1)
            {
                try
                {
                    //Add the course topic to the database
                    int courseId = int.Parse(lstCourses.SelectedValue.ToString());
                    //check if the topic exists with the same name
                    var topicsWithSameName = db.CourseTopics.FromSql($"exec getTopicByNameAndCourseID {courseId}, {topicName}").ToList();
                    if (topicsWithSameName.Count > 0)
                    {
                        MessageBox.Show("A topic with the same name already exists", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    db.Database.ExecuteSqlRaw($"exec addCourseTopic {courseId}, {topicName}");
                    //populate the topics with the new topic
                    populateCourseTopics(courseId);
                    MessageBox.Show("Topic added successfully", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Can't add topic", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Topic name can't be less than 2 characters", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            if (cLTopics.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a topic first", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //get the course topic
            int courseID = int.Parse(cLTopics.SelectedValue.ToString());
            string courseTopicName = (cLTopics.SelectedItem as CourseTopic).Topic;

            try
            {
                db.Database.ExecuteSqlRaw($"exec deleteCourseTopic {courseID}, {courseTopicName}");
                populateCourseTopics(courseID);
                MessageBox.Show("Topic deleted successfully", "delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Can't delete topic", "delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Department> uncheckedDepartments = new List<Department>();
        private void button1_Click(object sender, EventArgs e)
        {
            int itemAdded = 0;
            int itemDeleted = 0;
            //get the selectedCourseID
            int selectedCourseID = getSelectedCourseID();
            //get the checked departments
            var checkedDepartments = clCourseDepts
                                        .CheckedItems;
            //add the checked departments to the course
            foreach (var item in checkedDepartments)
            {
                //check if the coursedepartment already exists
                var duplicatedCourseDepartments = db.Course_Depts.FromSql($"exec getCourseDepartment {selectedCourseID}, {(item as Department).DeptID}").ToList();
                if (duplicatedCourseDepartments.Count > 0) continue;

                db.Database.ExecuteSqlRaw($"exec addCourseDepartment {selectedCourseID}, {(item as Department).DeptID}");
                itemAdded++;
            }
            //Remove the checked departments from the course
            foreach (var item in uncheckedDepartments)
            {
                db.Database.ExecuteSqlRaw($"exec deleteCourseDepartment {selectedCourseID}, {(item as Department).DeptID}");
                itemDeleted++;
            }

            if (itemAdded > 0 || itemDeleted > 0)
            {
                MessageBox.Show("Departments saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clCourseDepts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                // Handle the event for when an item is unchecked
                Department uncheckedItem = clCourseDepts.Items[e.Index] as Department;
                uncheckedDepartments.Add(uncheckedItem);
            }
            else
            {
                // Handle the event for when an item is checked
                Department checkedItem = clCourseDepts.Items[e.Index] as Department;
                uncheckedDepartments.Remove(checkedItem);
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            //get the course
            int courseID = getSelectedCourseID();
            //get the course name
            string courseName = txtCourseName.Text.ToString();
            if (courseName.Length < 2)
            {
                MessageBox.Show("Course name can't be less than 2 characters", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var coursesWithSameName = db.Courses.FromSql($"exec getCourseByName {courseName}").ToList();
                if (coursesWithSameName.Count > 0)
                {
                    MessageBox.Show("Course name already exists", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    db.Database.ExecuteSqlRaw("exec changeCourseName {0}, {1}", courseID, courseName);
                    MessageBox.Show("Course name updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateCourseList();

                }
                catch
                {
                    MessageBox.Show("Course name can't be changed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clCourseDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateCourseInstructors((int)lstCourses.SelectedValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedCrsID = (int)lstCourses.SelectedValue;
            //get the courseInstructors from the database
            List<Instructor_Course> instructor_Courses = db.Instructor_Courses.FromSql($"exec getCourseInstructorsByCourseID {selectedCrsID}").ToList();
            //get all the checked instructors
            var CheckedInstructors = cLInstructors.CheckedItems;
            var checkedInstructorsIds = new List<int>();
            foreach (User item in CheckedInstructors)
            {
                checkedInstructorsIds.Add(item.UserID);
            }
            //check if each instructor in the courseInstructors doesn't exist in the cekecked list then delte it from the database
            foreach (var item in instructor_Courses)
            {
                if (!checkedInstructorsIds.Contains(item.InstructorID))
                {
                    db.Database.ExecuteSqlRaw($"exec deleteCourseInstructorByInstructorIDAndCourseID {selectedCrsID}, {item.InstructorID}");
                }
            }
            //add the checked instructors to the database
            foreach (int item in checkedInstructorsIds)
            {
                db.Database.ExecuteSqlRaw($"exec addInstructorCourse {selectedCrsID}, {item}");
            }

            //Refresh the course instructors
            populateCourseInstructors(selectedCrsID);
            //Done
            MessageBox.Show("Instructors updated successfully", "Updating success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //get the course name
            string crsName = txtCrs.Text;
            //check if the course name is not empty and more than 2 characters
            if (crsName.Length < 2)
            {
                MessageBox.Show("Course name can't be less than 2 characters", "Adding fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //check if the name is not unique then display an error message
            var courses = db.Courses.FromSql($"exec getCourseByName {crsName}").AsEnumerable().ToList();
            if (courses.Any())
            {
                MessageBox.Show($"A course with the name {crsName} already exists", "Adding fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //try to add the course in the database using a stored procedure (Display a success message if done)
            try
            {
                db.Database.ExecuteSqlRaw($"exec AddCourse {crsName}");
                populateCourseList();
                MessageBox.Show("Course added successfully", "Adding success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An unknown error occured", "Adding fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
