using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CrystalReportGenerator.Program;

namespace application.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }
        private void btnSR_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                int DeptID = int.Parse(txtDeptID.Text);
                ReportGenerator.DisplayDeptReport(DeptID);
            }
            catch 
            {
                MessageBox.Show("DeptID is Required and Must be Int Value");
            }
            
        }
    }

}
