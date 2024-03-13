using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application.instructorDialog
{
    public partial class EditDialog : Form
    {
        public int Qtype { get; set; }
        public EditDialog(int Qtype)
        {
            InitializeComponent();
            this.Qtype = Qtype;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditDialog_Load(object sender, EventArgs e)
        {
            if(Qtype == 0)
            {
                tfAddEdit1.Visible = true;
                mcqAddEdit1.Visible=false;
            }
            else
            {
                tfAddEdit1.Visible = false;
                mcqAddEdit1.Visible = true;
            }
        }
    }
}
