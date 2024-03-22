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

namespace application.Forms.adminForms
{

    public partial class Departments : Form
    {
        BindingSource departmentsDB;
        iti_ExamContext db = new iti_ExamContext();
        BindingNavigator navigator;
        public Departments()
        {
            InitializeComponent();
            fillTheDepartmentsList();

            //fill the combo box with the branch names
            var branches = db.Branches.FromSql($"exec GetAllBranches").ToList();
            cbBranch.DataSource = branches;
            cbBranch.DisplayMember = "BranchName";
            cbBranch.ValueMember = "BranchID";
        }

        public Departments(int selectedListIndex)
        {
            InitializeComponent();
            fillTheDepartmentsList();
            lstDepts.SelectedIndex = selectedListIndex;

            //fill the combo box with the branch names
            var branches = db.Branches.FromSql($"exec GetAllBranches").ToList();
            cbBranch.DataSource = branches;
            cbBranch.DisplayMember = "BranchName";
            cbBranch.ValueMember = "BranchID";
        }

        public void fillTheDepartmentsList()
        {
            List<Department> departments = db.Departments.FromSql($"exec GetAllDepartments").ToList();
            lstDepts.DataSource = departments;
            lstDepts.DisplayMember = "deptName";
            lstDepts.ValueMember = "deptId";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedID;
            if ((lstDepts.SelectedValue as Department) != null)
            {
                selectedID = int.Parse((lstDepts.SelectedValue as Department).DeptId.ToString());
            }
            else
            {
                selectedID = int.Parse(lstDepts.SelectedValue.ToString());
            }
            var dept = db.Departments
                        .SingleOrDefault(d => d.DeptId == selectedID);
            txtDeptName.Text = dept.DeptName.ToString();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.ShowDialog();
            fillTheDepartmentsList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if the department has any realtions then don't delete it
            try
            {
                db.Database.ExecuteSqlRaw($"exec DeleteDepartmentById {lstDepts.SelectedValue}");
                fillTheDepartmentsList();
                MessageBox.Show("Department deleted successfully", "Deleting succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Department can't be deleted, it may have other dependencies", "Deleting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //delete the department if it has no realtions
        }

        private void btnEditDept_Click(object sender, EventArgs e)
        {
            if (txtDeptName.Text == null || txtDeptName.Text.Length < 2)
            {
                MessageBox.Show("Department name must be at least 2 characters", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbBranch.SelectedItem == null)
            {
                MessageBox.Show("You must select a branch for the department", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //check the uniqness of the department
                var duplicatedDepts = db.Departments.FromSql($"exec GetDepartmentByNameAndBranchID {txtDeptName.Text}, {cbBranch.SelectedValue}").ToList();

                if (duplicatedDepts.Count > 0)
                {
                    MessageBox.Show("A department with the same name and branch already exists", "Duplicated department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int selectedIndexForUpdatedValue = lstDepts.SelectedIndex;
                db.Database.ExecuteSqlRaw($"exec UpdateDepartment {lstDepts.SelectedValue}, {txtDeptName.Text}, {cbBranch.SelectedValue}");
                MessageBox.Show("Branch updated successfully", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Departments departments = new Departments(selectedIndexForUpdatedValue);
                departments.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDeptName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
