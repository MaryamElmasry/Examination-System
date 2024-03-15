using application.instructorDialog;
using application.Models;
using Microsoft.EntityFrameworkCore;


namespace application.TeacherUserControls
{
    public partial class ExamsControlcs : UserControl
    {
        public ExamsControlcs()
        {
            InitializeComponent();
        }

        private void GenerateExam_Click(object sender, EventArgs e)
        {

            new GenerateExamDialog(1,1).Show();
        }

        private void ExamsControlcs_Load(object sender, EventArgs e)
        {
            using (var ctx = new iti_ExamContext())
            {
                comboBox1.DataSource = ctx.Departments.FromSqlRaw("EXEC GetAllDepartments").ToList();
                comboBox1.SelectedIndex = 0;
                comboBox2.DataSource = ctx.Courses.ToList(); ;
                comboBox2.SelectedIndex = 0;
                comboBox1.DisplayMember = "DeptName";
                comboBox1.ValueMember = "DeptId";
                comboBox2.ValueMember = "CourseID";
                comboBox2.DisplayMember = "CourseName";
            }
        }
    }
}
