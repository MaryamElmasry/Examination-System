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
    public partial class Branches : UserControl
    {

        public Branches()
        {
            InitializeComponent();
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            AddNewBranch addNewBranch = new AddNewBranch(this);
            addNewBranch.ShowDialog();
        }

        private void Branches_Load(object sender, EventArgs e)
        {
            //using (iti_ExamContext db = new iti_ExamContext())
            //{
            //    gvBranches.DataSource = db.Branches.ToList();
            //    gvBranches.Columns[2].Visible = false;
            //}
        }
    }
}
