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
        private readonly int _deptid;
        private readonly int _crsid;
        
        public GenerateExamDialog(int deptid , int crsid)
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            _deptid = deptid;
            _crsid = crsid;
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
            using(var ctx = new iti_ExamContext())
            {
                string dateTimeString = dateTimePicker1.Value.ToString();
                string[] parts = dateTimeString.Split(' ');
                string result = string.Join(" ", parts.Take(parts.Length - 1));

                ctx.Database.ExecuteSql($"EXEC GenerateExam {_deptid},{_crsid},{result},{mcqNo} , {tfno},{duration}");
                this.Close();
                MessageBox.Show("Exam Generated Successfully Please Reselect the course from the course list to refersh the page ");
                
            }
        }
    }
}
