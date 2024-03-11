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
    public partial class AddDepartment : Form
    {
        iti_ExamContext db;
        public AddDepartment()
        {
            InitializeComponent();
            db = new iti_ExamContext();
            //filling the combo box with the branches names
            var branches = db.Branches.FromSql($"exec GetAllBranches").ToList();
            cbBranches.DataSource = branches;
            cbBranches.DisplayMember = "BranchName";
            cbBranches.ValueMember = "BranchID";
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (txtDeptName.Text == null || txtDeptName.Text.Length < 2)
            {
                MessageBox.Show("Department name must be at least 2 characters", "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbBranches.SelectedItem == null)
            {
                MessageBox.Show("You must select a branch for the department", "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //check the uniqness of the department
                var duplicatedDepts = db.Departments.FromSql($"exec GetDepartmentByNameAndBranchID {txtDeptName.Text}, {cbBranches.SelectedValue}").ToList();

                if (duplicatedDepts.Count > 0)
                {
                    MessageBox.Show("A department with the same name and branch already exists", "Duplicated department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Database.ExecuteSqlRaw($"exec AddNewDepartment {txtDeptName.Text}, {cbBranches.SelectedValue}");
                MessageBox.Show("Branch added successfully", "Adding Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
