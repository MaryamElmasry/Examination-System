using application.instructorDialog;
using application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System.Diagnostics;


namespace application.TeacherUserControls
{
    public partial class ExamsControlcs : UserControl
    {
        private int selectedRow;
        public ExamsControlcs()
        {
            InitializeComponent();
            selectedRow = -1;
        }

        private void GenerateExam_Click(object sender, EventArgs e)
        {

            if ((int)DeptList.SelectedValue != -1 && (int)crsList.SelectedValue != -1)
                new GenerateExamDialog((int)DeptList.SelectedValue, (int)crsList.SelectedValue).Show();
        }

        private void ExamsControlcs_Load(object sender, EventArgs e)
        {
            using (var ctx = new iti_ExamContext())
            {
                DeptList.DataSource = ctx.Departments.FromSqlRaw("EXEC GetAllDepartments").ToList();
                DeptList.SelectedItem = 0;
                crsList.DataSource = ctx.Courses.FromSqlRaw($"EXEC GetAllDeptCourses {(DeptList.SelectedItem as Department).DeptID}").ToList();
                DeptList.DisplayMember = "DeptName";
                DeptList.ValueMember = "DeptID";
                crsList.ValueMember = "CourseID";
                crsList.DisplayMember = "CourseName";
            }


        }
        private void populateExamGv()
        {
            using (var ctx = new iti_ExamContext())
            {
                if (crsList.SelectedItem != null && DeptList.SelectedItem != null)
                {
                    var exams = ctx.Exams.FromSqlRaw($"EXEC getExam {((Department)DeptList.SelectedItem).DeptID} , {((Course)crsList.SelectedItem).CourseID}").ToList().Select(e => new { e.ExamID, e.ExamDate, e.Duration }).ToList();

                    ExamsGV.DataSource = exams;
                    ExamsGV.Refresh();
                }

            }

        }
        private void DeptListChanged(object sender, EventArgs e)
        {
            using (var ctx = new iti_ExamContext())
            {
                var selectedDept = DeptList.SelectedItem as Department;

                if (selectedDept != null)
                {
                    var courses = ctx.Courses.FromSqlRaw($"EXEC GetAllDeptCourses {selectedDept.DeptID}").ToList();

                    if (courses.Any())
                    {
                        crsList.DataSource = courses;
                        crsList.ValueMember = "CourseID";
                        crsList.DisplayMember = "CourseName";
                    }
                    else
                    {
                        crsList.DataSource = null;
                        crsList.Items.Clear();
                        crsList.SelectedValue = -1;
                        crsList.Text = string.Empty;
                    }
                }
                else
                {
                    crsList.DataSource = null;
                    crsList.Items.Clear();
                    crsList.SelectedValue = -1;
                    crsList.Text = string.Empty;
                }
            }
        }

        private void updateGV(object sender, EventArgs e)
        {
            populateExamGv();
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            var Crow = ((DataGridView)sender).SelectedRows.Count;
            if (Crow == 1)
            {
                dynamic row = ((DataGridView)sender).SelectedRows[0].DataBoundItem;
                selectedRow = row.ExamId;

            }
            else
            {
                selectedRow = -1;

            }

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if(selectedRow != -1)
            {
                var deptname = ((Department)DeptList.SelectedItem).DeptName;
                var crsname = ((Course)crsList.SelectedItem).CourseName;
                new PrintForm(selectedRow,deptname,crsname).Show();
            }
        }
    }
}
