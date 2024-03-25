using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using application.instructorDialog;
using application.Models;
using Microsoft.EntityFrameworkCore;


namespace application.TeacherUserControls
{
    public partial class TopicsControl : UserControl
    {
        int courseId;
        public Instructor ins;
        public TopicsControl()
        {
            InitializeComponent();
        }

        private void LoadCourseNames()
        {
            try
            {
                using (var ctx = new iti_ExamContext())
                {

                    var coursesList = ctx.Courses.FromSqlRaw($"EXEC GetCourseList {ins.InstructorID} ").ToList();
                    comboBoxClass.DataSource = coursesList;
                    comboBoxClass.ValueMember = "CourseID";
                    comboBoxClass.DisplayMember = "CourseName";
                    displayTopics();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        public void displayTopics()
        {
            if (comboBoxClass.SelectedValue != null)
            {
                string x = comboBoxClass.SelectedValue.ToString();

                if (int.TryParse(x, out courseId))
                {
                    using (var ctx = new iti_ExamContext())
                    {
                        var topics = ctx.CourseTopics.FromSqlRaw($"exec GetCourseTopics {courseId} ").ToList();

                        foreach (var item in topics)
                        {
                            dataGridView.Rows.Add(item.Topic);
                        }
                    }
                }
            }
        }

        private void comboBoxClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            displayTopics();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

            new PrintForm(courseId, "LoadTopics", 1).Show();
        }

        private void TopicsControl_Load(object sender, EventArgs e)
        {
            LoadCourseNames();

        }
    }
}
