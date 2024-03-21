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
    public partial class StudentForm : Form
    {
        Student student;
        public StudentForm()
        {
            InitializeComponent();
        }
        public StudentForm(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

    }
}
