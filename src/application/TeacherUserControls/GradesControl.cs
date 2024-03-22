using application.Models;
using application.projectionEntities;
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

namespace application.TeacherUserControls
{
    public partial class GradesControl : UserControl
    {
        private int selecteditem;
        private int studentitem;
        public GradesControl()
        {
            InitializeComponent();

        }

        private void GradesControl_Load(object sender, EventArgs e)
        {
            using (var ctx = new iti_ExamContext())
            {
                var depts = ctx.Departments.FromSqlRaw("EXEC GetDeptsforIns 1").ToList();
                DeptsList.DataSource = depts;
                DeptsList.DisplayMember = "DeptName";
                DeptsList.ValueMember = "DeptId";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdatecrsList(object sender, EventArgs e)
        {
            using (var ctx = new iti_ExamContext())
            {
                dynamic deptitem = DeptsList.SelectedItem;
                var crs = ctx.Courses.FromSqlRaw($"EXEC GetAllDeptCourses {deptitem.DeptId}").ToList();
                CoursesList.DataSource = crs;
                CoursesList.DisplayMember = "CourseName";
                CoursesList.ValueMember = "CourseID";
            }
        }

        private void UpdateStudents(object sender, EventArgs e)
        {
            dynamic dept = DeptsList.SelectedItem;
            using (var ctx = new iti_ExamContext())
            {
                StudentsGV.DataSource = ctx.Database.SqlQueryRaw<PStudent>($"EXEC GetStudentsByDept {dept.DeptId}").ToList();

            }
            studentitem = -1;
        }

        private void UpdateExamGrid(object sender, EventArgs e)
        {
            dynamic dept = DeptsList.SelectedItem;
            dynamic crs = CoursesList.SelectedItem;
            using (var ctx = new iti_ExamContext())
            {
                ExamsGV.DataSource = ctx.Database.SqlQueryRaw<ExamView>($"EXEC GetExamsDeptCourse {dept.DeptId} , {crs.CourseId}").ToList();
            }
            selecteditem = -1;
            if(StudentsGV.SelectedRows.Count > 0)
            {
                studentitem = int.Parse(StudentsGV.SelectedRows[0].Cells[0].FormattedValue.ToString());

            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
          if(selecteditem != -1 && studentitem != -1) {
          


          }

        }

        private void updateSelectedItem(object sender, EventArgs e)
        {
            if (StudentsGV.SelectedRows.Count > 0)
            {
                studentitem = int.Parse(StudentsGV.SelectedRows[0].Cells[0].FormattedValue.ToString());
            }
        }
    }
}
