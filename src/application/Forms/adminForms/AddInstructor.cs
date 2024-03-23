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

            cbBranches.SelectedValue = Instructor.BranchId;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null || txtName.Text.Length < 2)
            {
                MessageBox.Show("Instructor name must be at least 2 characters", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbBranches.SelectedItem == null)
            {
                MessageBox.Show("You must select a Deparment for the Instructor", "Adding failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
