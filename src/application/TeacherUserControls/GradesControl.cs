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
    public partial class GradesControl : UserControl
    {
        private int selecteditem;
        private int studentitem;
        public GradesControl()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxstdId.Text.Trim(), out int stdId))
            {
                MessageBox.Show("Error: Student ID must be a valid Number.");
                return;
            }

            if (!int.TryParse(textBoxExamId.Text.Trim(), out int ExamId))
            {
                MessageBox.Show("Error: Exam ID must be a valid Number.");
                return;
            }
            try
            {

                using (var ctx = new iti_ExamContext())
                {
                    var result = ctx.Database.SqlQueryRaw<DetailedExam>($"EXEC GetExamForStdReport {ExamId}, {stdId}").ToList();
                    //Data.FromSql($"EXEC GetExamForStdReport {ExamId}, {stdId}").ToList();
                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //int examid = 1;
            //int stdid = 2;
            if (!int.TryParse(textBoxstdId.Text.Trim(), out int stdId))
            {
                MessageBox.Show("Error: Student ID must be a valid Number.");
                return;
            }

            if (!int.TryParse(textBoxExamId.Text.Trim(), out int ExamId))
            {
                MessageBox.Show("Error: Exam ID must be a valid Number.");
                return;
            }
            new PrintForm(ExamId, stdId, "detailedExam").Show();
        }
    }
}
