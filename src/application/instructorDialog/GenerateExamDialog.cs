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

namespace application.instructorDialog
{
    public partial class GenerateExamDialog : Form
    {
        public GenerateExamDialog(int deptid , int crsid)
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mcqNo = 0, tfno = 0, duration = 0;
            try
            {
                 mcqNo = int.Parse(textBox1.Text);
                 tfno = int.Parse(textBox2.Text);
                 duration = int.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("please enter a valid number");
            }
            MessageBox.Show(this.Owner.Name.ToString());
            using(var ctx = new iti_ExamContext())
            {
                // @courseId int ,@deptId int, @date datetime , @mcqCount int, @TFcount int,@duration int
                ctx.Exams.FromSqlRaw($"EXEC GenerateExam {1},{1},{dateTimePicker1.Value},{mcqNo} , {tfno},{duration}");
            }
        }
    }
}
