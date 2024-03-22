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
    public partial class Admin2 : Form
    {
        iti_ExamContext db = new iti_ExamContext();

        public Admin2()
        {
            InitializeComponent();
            loadDepartments();
            loadStudents();    
        }
        private void loadDepartments()
        {
            #region Fill Departments ComboBox
            var departments = db.Departments.FromSql($"exec GetAllDepartments").ToList();
            cbDepts.DataSource = departments;
            cbDepts.DisplayMember = "DeptName";
            cbDepts.ValueMember = "DeptID";
            #endregion
        }
        private void loadStudents()
        {
            gvStudents.Rows.Clear();
            #region Fill Students Grid
            int deptID = (int)cbDepts.SelectedValue;
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

            if (e.ColumnIndex == 7)
            {
                int studentID = (int)gvStudents.Rows[e.RowIndex].Cells[0].Value;
                var student = db.Students.Include(s => s.StudentNavigation).Where(s => s.StudentID == studentID).FirstOrDefault();
                AddStudent addStudent = new AddStudent(student);
                addStudent.ShowDialog();
            }
            if (e.ColumnIndex == 8)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                   MessageBox.Show("Student Deleted Successfully", "Delete Student", MessageBoxButtons.OK);

                }
               
            }
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
