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
        bool edit = false;
        Student student = null;
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
            edit = true;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            //UserName Validation only alpha alllowed
            if (txtName.Text == null || txtName.Text.Length < 2 || !txtName.Text.All(char.IsLetter))
            {
                MessageBox.Show("Name must be at least 2 characters and only alphabets", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Email Validation to be yahoo or gmail only
            if (txtEmail.Text == null || !txtEmail.Text.Contains
                ("@gmail.com") && !txtEmail.Text.Contains("@yahoo.com"))
            {
                MessageBox.Show("Email must be gmail or yahoo", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Password Validation
            if (txtPassword.Text == null || txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Address Validation
            if (txtAddress.Text == null || txtAddress.Text.Length < 5)
            {
                MessageBox.Show("Address must be at least 5 characters", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Gender Validation
            if (!M.Checked && !F.Checked)
            {
                MessageBox.Show("Please select the gender", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            if (cbDept.SelectedItem == null)
            {
                MessageBox.Show("You must select a Deparment for the Student", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (edit)
            {
                int StudentID = student.StudentID;
                //check the uniqness of the Email
                var duplicatedEmails = db.Users.FromSql($"exec GetUserByEmail_edit @UserId={StudentID}, @Email ='{txtEmail.Text}'").ToList();
                if (duplicatedEmails.Count > 0)
                {
                    MessageBox.Show("A Student with the same email already exists", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Database.ExecuteSqlRaw($"exec UpdateStudent {StudentID}, '{txtName.Text}', '{txtEmail.Text}', '{txtAddress.Text}', '{txtPassword.Text}', '{txtNumber.Text}', '{(M.Checked ? 'M' : 'F')}', {cbDept.SelectedValue}");
                MessageBox.Show("Student updated successfully", "Updating Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
