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

namespace application.Forms
{
    public partial class AddNewBranch : Form
    {
        iti_ExamContext db = new iti_ExamContext();

        public AddNewBranch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBranchName.Text != null && txtBranchName.Text.Trim().Length > 1)
            {
                
                string branchName = txtBranchName.Text.Trim();

                var branchesWithSameName = db.Branches.FromSql($"exec getBranchByName {branchName}").ToList();

                if (branchesWithSameName.Count > 0)
                {
                    MessageBox.Show("Branch with the same name already exists", "Duplicated Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.Database.ExecuteSqlRaw($"exec AddNewBranch {branchName}");
                    MessageBox.Show("Branch added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Branch name must be more than 1 character", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
