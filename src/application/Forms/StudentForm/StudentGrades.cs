﻿using application.Forms.adminForms;
using application.instructorDialog;
using application.Models;
using application.projectionEntities;
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
    public partial class StudentGrades : Form
    {
        iti_ExamContext db = new iti_ExamContext();
        int StudentID;
        public StudentGrades(int StudentID)
        {
            this.StudentID = StudentID;
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private async void StudentGrades_Load(object sender, EventArgs e)
        {
            var GradeTable = await db.GetProcedures().GetExamGradesByStudentIDAsync(StudentID);
            foreach (var item in GradeTable)
            {
                dataGridView1.Rows.Add(item.ExamID, item.CourseName, item.ExamDate, item.Grade);
            }

            string StudentName = db.Database.SqlQuery<string>($"exec GetStudentName {StudentID}").AsEnumerable().FirstOrDefault();
            lblUserName.Text = StudentName;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getDetailedExam(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
         e.RowIndex >= 0)
            {

                int rowStudentID = Convert.ToInt32(senderGrid[0, e.RowIndex].Value);
                string reportType = "detailedExam";

                PrintForm printForm = new PrintForm(rowStudentID, StudentID, reportType);
                printForm.Show();
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new Login().Show();
        }
    }
}
