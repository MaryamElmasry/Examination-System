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
    public partial class Admin3 : Form
    {
        iti_ExamContext db = new iti_ExamContext();

        public Admin3()
        {
            InitializeComponent();
            loadDepartments();
            loadInstructors();
        }
        private void loadDepartments()
        {
            #region Fill Departments ComboBox
            var departments = db.Branches.FromSql($"exec getallbranches").ToList();
            cbBranches.DataSource = departments;
            cbBranches.DisplayMember = "BranchName";
            cbBranches.ValueMember = "BranchID";
            #endregion
        }
        private void loadInstructors()
        {
            gvInstructors.Rows.Clear();
            #region Fill Instructors Grid
            int branchID = (int)cbBranches.SelectedValue;
            var instructors = db.Database.SqlQuery<InstructorResult>($"exec GetInstructorsByBranchID {branchID}").ToList();
            foreach (var instructor in instructors)
            {
                gvInstructors.Rows.Add(
                           instructor.UserID,
                           instructor.UserName,
                           instructor.Email,
                           instructor.password,
                           instructor.Phone,
                           instructor.Address,
                           instructor.Gender
                       );
            }
            #endregion
        }


        private void gvInstructors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void cbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInstructors();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            db.Database.CloseConnection();
            this.Close();

        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            AddInstructor addInstructor = new AddInstructor();
            addInstructor.ShowDialog();

        }

        private void gvInstructors_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int InstructorID = (int)gvInstructors.Rows[e.RowIndex].Cells[0].Value;
                var Instructor = db.Instructors.Include(s => s.InstructorNavigation).Where(s => s.InstructorID == InstructorID).FirstOrDefault();
                AddInstructor addInstructor = new AddInstructor(Instructor);
                addInstructor.ShowDialog();
            }
            if (e.ColumnIndex == 8)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this instructor?", "Delete Instructor", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Instructor Deleted Successfully", "Delete Instructor", MessageBoxButtons.OK);

                }

            }

        }
    }

    #region Project Models
    public class InstructorResult
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
