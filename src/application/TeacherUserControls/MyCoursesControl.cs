using application.instructorDialog;
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
    public partial class MyCoursesControl : UserControl
    {
        public Instructor ins;
        public MyCoursesControl()
        {
            InitializeComponent();



        }

        private void MyCoursesControl_Load(object sender, EventArgs e)
        {
            using (var ctx = new iti_ExamContext())
            {
                var nofstuds = ctx.Database.SqlQueryRaw<MyCoursesInfoP>($"EXEC getStudentsPerCourse {ins.InstructorId}").ToList();
                dataGridView1.DataSource = nofstuds;
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            new PrintForm(this.ins.InstructorId, "MyCoursesInfo").Show();
        }
    }
}
