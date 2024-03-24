using application.Forms.adminForms;
using application.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace application.Forms
{
    public partial class StudentExamForm : Form
    {
        iti_ExamContext db = new iti_ExamContext();

        public int studentID;

        public StudentExamForm(int studentID)
        {
            this.studentID = studentID;
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void panelShowReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void StudentExamForm_Load(object sender, EventArgs e)
        {
            var ExamTable = await db.GetProcedures().GetCourseExamsAsync(1);
            foreach (var item in ExamTable)
            {
                dataGridView1.Rows.Add(item.ExamID, item.CourseName, item.ExamDate, item.Duration);
            }

            string StudentName = db.Database.SqlQuery<string>($"exec GetStudentName {studentID}").AsEnumerable().FirstOrDefault();
            lblUserName.Text = StudentName;

        }

        private void btnDisplayExams_Click(object sender, EventArgs e)
        {
            StudentGrades studentGrades = new StudentGrades(studentID);
            studentGrades.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int ExamId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                int CourseID = db.Database.SqlQuery<int>($"exec GetCourseIdByExamID {ExamId}").AsEnumerable().FirstOrDefault();
                int Duration = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                string Date = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateTime ExamDate = DateTime.Parse(Date);


                StartExamPage startExamPage = new StartExamPage(ExamId, studentID, CourseID, ExamDate, Duration);
                startExamPage.ShowDialog();


            }
            return;

            
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
           /* string UserName;

            int StudentName = db.Database.SqlQuery<string>($"exec GetStudentName {UserName}").FirstOrDefault();*/
        }
    }
}
