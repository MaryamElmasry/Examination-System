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
    public partial class InstructorForm : Form
    {
        public Instructor instructor;
        public InstructorForm()
        {
            InitializeComponent();

        }
        public InstructorForm(Instructor instructor)
        {
            InitializeComponent();
            this.instructor = instructor;
        }
    }
}
