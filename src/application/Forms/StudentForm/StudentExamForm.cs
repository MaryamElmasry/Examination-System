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
    public partial class StudentExamForm : Form
    {
        iti_ExamContext db = new iti_ExamContext();
        public XmlSerializer serializer;
        // Import the necessary Windows API methods
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public int studentID;
        public StudentExamForm()
        {
            InitializeComponent();
            fillGVBranches();
        }
        public StudentExamForm(int studentID)
        {
            this.studentID = studentID;
            InitializeComponent();
            fillGVBranches();
        }

        void fillGVBranches()
        {
            /* //Bind the grid view to a list in order to allow the deleting
             List<Models.Branch> branchesList = db.Branches.FromSql($"exec GetAllBranches").ToList();
             IList<Models.Branch> branches = branchesList.ToList();

             // Create a BindingList<T> using the IList<T>
             BindingList<Models.Branch> bindingList = new BindingList<Models.Branch>(branches);
             gvBranches.DataSource = bindingList;
             gvBranches.Columns[2].Visible = false;
             //Make the grid view editable
             gvBranches.ReadOnly = false;
             gvBranches.EditMode = DataGridViewEditMode.EditOnEnter;
             //Make the id column read only
             gvBranches.Columns[0].ReadOnly = true;*/
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {/*
            // Check if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                // Release capture to enable normal mouse operation like clicking on buttons
                ReleaseCapture();

                // Send the message to move the form
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }*/
        }

        private void btnDisplayBranches_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            /* AddNewBranch addNewBranch = new AddNewBranch();
             addNewBranch.ShowDialog();
             fillGVBranches();*/
        }

        private void gvBranches_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /* string branchName = "";
             if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
             {
                 branchName = gvBranches.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
             }
             if (branchName.Trim().Length > 1)
             {
                 int branchID = int.Parse(gvBranches.Rows[e.RowIndex].Cells[0].Value.ToString());

                 SqlParameter branchIdParameter = new SqlParameter("@id", branchID);
                 var oldBranchName = db.Database.SqlQuery<string>($"exec getBranchName {branchIdParameter}").AsEnumerable().FirstOrDefault();
                 if (oldBranchName != null && branchName != oldBranchName)
                 {
                     var branchesWithSameName = db.Branches.FromSql($"exec getBranchByName {branchName}").ToList();

                     if (branchesWithSameName.Count > 0)
                     {
                         gvBranches.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = oldBranchName;
                         MessageBox.Show("Branch with the same name already exists", "Duplicated Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     else
                     {
                         int result = db.Database.ExecuteSqlRaw($"exec updateBranchName {branchID}, {branchName}");
                         if (result != 0)
                         {
                             MessageBox.Show("Branch updated successfully", "success update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                         else
                         {
                             MessageBox.Show("No branch was updated", "Failed update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         }
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Branch name can't be less than 2 characters", "Failed message", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/

        }

        private void gvBranches_KeyDown(object sender, KeyEventArgs e)
        {
            /*
                        // Check if the pressed key is the Delete key
                        if (e.KeyCode.ToString() == "Delete")
                        {
                            int result = 0;
                            // Remove the selected row(s)
                            foreach (DataGridViewRow row in gvBranches.SelectedRows)
                            {
                                if (!row.IsNewRow) // Skip the new row if present
                                {
                                    //check if the branch has departments then don't remove it
                                    //get the branch id
                                    var branchID = (int)row.Cells[0].Value;
                                    //get the branches departments
                                    var branchDeptartments = db.Departments.FromSql($"exec getBranchesDepartments {branchID}").ToList();
                                    if (branchDeptartments.Count == 0)
                                    {
                                        try
                                        {
                                            result = db.Database.ExecuteSqlRaw($"exec DeleteBranch {branchID}");
                                            gvBranches.Rows.Remove(row);
                                            fillGVBranches();
                                        }
                                        catch
                                        {
                                            MessageBox.Show($"Can't delete branch with id ${branchID}", "Deleting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Branch with id {branchID} has departments", "Can't delete branch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            if (result != 0)
                            {
                                MessageBox.Show($"Branch(es) deleted successfully", "Success deleting", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }*/
        }

        private void btnDisplayDepartments_Click(object sender, EventArgs e)
        {
            /* btnDisplayDepartments.ForeColor = Color.White;
             Departments departments = new Departments();
             departments.ShowDialog();
             btnDisplayDepartments.ForeColor = Color.DarkGray;*/
        }

        private void panelShowReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void StudentExamForm_Load(object sender, EventArgs e)
        {
            var ExamTable = await db.GetProcedures().GetCourseExamsAsync(3);
            foreach(var item in ExamTable)
            {
                dataGridView1.Rows.Add(item.ExamID, item.CourseName, item.ExamDate, item.Duration);
            }


        }
    }
}
