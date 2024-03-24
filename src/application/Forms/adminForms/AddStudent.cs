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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace application.Forms.adminForms
{
    public partial class AddStudent : Form
    {
        iti_ExamContext db;
        public AddStudent()
        {
            InitializeComponent();
            db = new iti_ExamContext();
            //filling the combo box with the branches names
            var branches = db.Departments.FromSql($"exec GetAllDepartments").ToList();
            cbDept.DataSource = branches;
            cbDept.DisplayMember = "DeptName";
            cbDept.ValueMember = "DeptID";
        }
        //Make Constructor to use the same form for Update
        public AddStudent(Student student)
        {
            this.Text = "Update Student";

            this.SuspendLayout();

            InitializeComponent();
            db = new iti_ExamContext();
            //filling the combo box with the branches names
            var branches = db.Departments.FromSql($"exec GetAllDepartments").ToList();

            cbDept.DataSource = branches;
            cbDept.DisplayMember = "DeptName";
            cbDept.ValueMember = "DeptID";

            txtName.Text = student.StudentNavigation.UserName;
            txtEmail.Text = student.StudentNavigation.Email;
            txtAddress.Text = student.StudentNavigation.Address;
            txtPassword.Text = student.StudentNavigation.Password;
            txtNumber.Text = student.StudentNavigation.Phone;
            if (student.StudentNavigation.Gender == "M")
                M.Checked = true;
            else
                F.Checked = true;
            cbDept.SelectedValue = student.DeptID;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null || txtName.Text.Length < 2)
            {
                MessageBox.Show("Student name must be at least 2 characters", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbDept.SelectedItem == null)
            {
                MessageBox.Show("You must select a Deparment for the Student", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //check the uniqness of the Email
                var duplicatedEmails = db.Users.FromSql($"exec GetUserByEmail {txtEmail.Text}").ToList();
                if (duplicatedEmails.Count > 0)
                {
                    MessageBox.Show("email already exists", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.Database.ExecuteSqlRaw($"exec AddStudent '{txtName.Text}', '{txtEmail.Text}', '{txtAddress.Text}', '{txtPassword.Text}', '{txtNumber.Text}', '{(M.Checked ? 'M' : 'F')}', {cbDept.SelectedValue}");

                MessageBox.Show("Student added successfully", "Adding Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
