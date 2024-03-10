using application.Models;
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
        Branches branches;

        public AddNewBranch()
        {
            InitializeComponent();
        }

        public AddNewBranch(Branches _branches)
        {
            InitializeComponent();
            branches = _branches;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBranchName.Text != null && txtBranchName.Text.Trim().Length > 1)
            {
                Branch branch = new Branch();
                branch.BranchName = txtBranchName.Text.Trim();
                db.Branches.Add(branch);
                db.SaveChanges();
                MessageBox.Show("Branch added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                branches.Invalidate();
            }
            else
            {
                MessageBox.Show("Branch name must be more than 1 character", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
