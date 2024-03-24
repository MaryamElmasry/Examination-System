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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace application.Forms
{
    public partial class StudentsControlForm : Form
    {
        iti_ExamContext db = new iti_ExamContext();

        public StudentsControlForm()
        {
            InitializeComponent();
            StudentsControlForm_Load(null, null);
            loadStudents();
        }
        private void StudentsControlForm_Load(object sender, EventArgs e)
        {
            #region Fill Departments ComboBox
            var departments = db.Departments.FromSql($"exec GetAllDepartments").ToList();
            //clear cbDepts
            cbDeptsStudent.DataSource = departments;
            cbDeptsStudent.DisplayMember = "DeptName";
            cbDeptsStudent.ValueMember = "DeptID";
            #endregion
        }
        private void loadStudents()
        {
            gvStudents.Rows.Clear();
            #region Fill Students Grid
            int deptID = 1;
            var students = db.Database.SqlQuery<StudentResult>($"exec GetStudentsByDeptID {deptID}").ToList();
            foreach (var student in students)
            {
                gvStudents.Rows.Add(
                           student.UserID,
                           student.UserName,
                           student.Email,
                           student.password,
                           student.Phone,
                           student.Address,
                           student.Gender
                       );
            }
            #endregion
        }


        private void gvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadStudents();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            db.Database.CloseConnection();
            this.Close();

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();

        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstructorsControlForm instructorsControlForm = new InstructorsControlForm();
            instructorsControlForm.ShowDialog();
            this.Close();


        }
    }

    #region Project Models
    public class StudentResult
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public string password { get; set; }


        public string Phone { get; set; }


        public string Address { get; set; }

        public string Gender { get; set; }
    }
    #endregion
}
