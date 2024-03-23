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
using static CrystalReportGenerator.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace application.Forms
{
    public partial class ReportsForm : Form
    {
        iti_ExamContext db = new iti_ExamContext();
        public ReportsForm()
        {
            InitializeComponent();
        }
        private void btnSR_Click_1(object sender, EventArgs e)
        {

            try
            {
                int DeptID = int.Parse(txtDeptID.Text);
                ReportGenerator.DisplayDeptReport(DeptID);
            }
            catch
            {
                MessageBox.Show("DeptID is Required and Must be Int Value");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int StudentID = int.Parse(textBoxGrade.Text);

                string StudentName = db.Database.SqlQuery<string>($"exec GetStudentName {StudentID}").AsEnumerable().FirstOrDefault();

                ReportGenerator.DisplayGradesReport(StudentID,StudentName);
            }
            catch
            {
                MessageBox.Show("StudentID is Required and Must be Int Value");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }
    }

}
