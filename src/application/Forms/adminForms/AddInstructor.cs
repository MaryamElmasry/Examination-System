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
    public partial class AddInstructor : Form
    {
        iti_ExamContext db;
        bool edit = false;
        Instructor Instructor=null;

        public AddInstructor()
        {
            InitializeComponent();
            db = new iti_ExamContext();
            //filling the combo box with the branches names
            var branches = db.Branches.FromSql($"exec GetAllBranches").ToList();
            cbBranches.DataSource = branches;
            cbBranches.DisplayMember = "BranchName";
            cbBranches.ValueMember = "BranchID";
        }
        //Make Constructor to use the same form for Update

        public AddInstructor(Instructor Instructor)
        {
            InitializeComponent();
            this.Instructor = Instructor;
            db = new iti_ExamContext();
            //filling the combo box with the branches names
            var branches = db.Branches.FromSql($"exec GetAllBranches").ToList();
            cbBranches.DataSource = branches;
            cbBranches.DisplayMember = "BranchName";
            cbBranches.ValueMember = "BranchID";

            txtName.Text = Instructor.InstructorNavigation.UserName;
            txtEmail.Text = Instructor.InstructorNavigation.Email;
            txtAddress.Text = Instructor.InstructorNavigation.Address;
            txtPassword.Text = Instructor.InstructorNavigation.Password;
            txtNumber.Text = Instructor.InstructorNavigation.Phone;
            if (Instructor.InstructorNavigation.Gender == "M")
                M.Checked = true;
            else
                F.Checked = true;

            cbBranches.SelectedValue = Instructor.BranchID;

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
            if (txtPassword.Text == null || txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Address Validation
            if (txtAddress.Text == null || txtAddress.Text.Length < 8)
            {
                MessageBox.Show("Address must be at least 8 characters", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Gender Validation
            if (!M.Checked && !F.Checked)
            {
                MessageBox.Show("Please select the gender", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
   
            //Phone Validation to be 010 or 011 or 012 or 015 egyptian numbers only and total of 11 digits
            if (txtNumber.Text == null || txtNumber.Text.Length != 11 || !txtNumber.Text.StartsWith("010") && !txtNumber.Text.StartsWith("011") && !txtNumber.Text.StartsWith("012") && !txtNumber.Text.StartsWith("015"))
            {
                MessageBox.Show("Phone must be 11 digits and starts with 010 or 011 or 012 or 015", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           if(edit)
            {
                int InstructorID = Instructor.InstructorID;
                //check the uniqness of the Email
                var duplicatedEmails = db.Users.FromSql($"exec GetUserByEmail_edit @UserId={InstructorID}, @Email ='{txtEmail.Text}'").ToList();
                if (duplicatedEmails.Count > 0)
                {
                    MessageBox.Show("A Instructor with the same email already exists", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Database.ExecuteSqlRaw($"exec UpdateInstructor {InstructorID}, '{txtName.Text}', '{txtEmail.Text}', '{txtAddress.Text}', '{txtPassword.Text}', '{txtNumber.Text}', '{(M.Checked ? 'M' : 'F')}', {cbBranches.SelectedValue}");
                MessageBox.Show("Instructor updated successfully", "Updating Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
      
            try
            {
                //check the uniqness of the Email
                var duplicatedEmails = db.Users.FromSql($"exec GetUserByEmail {txtEmail.Text}").ToList();
                if (duplicatedEmails.Count > 0)
                {
                    MessageBox.Show("A Instructor with the same email already exists", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.Database.ExecuteSqlRaw($"exec AddInstructor '{txtName.Text}', '{txtEmail.Text}', '{txtAddress.Text}', '{txtPassword.Text}', '{txtNumber.Text}', '{(M.Checked ? 'M' : 'F')}', {cbBranches.SelectedValue}");

                MessageBox.Show("Instructor added successfully", "Adding Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
