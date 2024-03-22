using application.Forms.adminForms;
using application.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

    public partial class StartExamPage : Form
    {
        iti_ExamContext db = new iti_ExamContext();
        int currentQuestion;
        //List of questions
        List<ExamQuestion> questions = new List<ExamQuestion>();
        //List of selected answers with length of questions
        int[] selectedAnswers;
        
        
        public StartExamPage(int ExamID = 0)
        {
            InitializeComponent();
            #region Get Questions and Initialize Selected Answers
            questions = db.Database.SqlQuery<ExamQuestion>($"EXEC [dbo].[GetQuestionChoices] @ExamID = {ExamID};").ToList();
            selectedAnswers = new int[questions.Count];
            for (int i = 0; i < selectedAnswers.Length; i++)
            {
                selectedAnswers[i] = -1;
            }
            #endregion
            DisplayQuestion(questions[currentQuestion]);

        }

        private void DisplayQuestion(ExamQuestion question)
        {
                #region Display The Question and Choices 
                qTitle.Text = question.Title;
                string[] choices = question.Choices.Split(',');
                qChoice1.Text = choices[0];
                qChoice2.Text = choices[1];
                qChoice3.Text = choices[2];
                qChoice4.Text = choices[3];
                #endregion

                #region Check The Radio Button of the Selected Answer for current Question
                switch (selectedAnswers[currentQuestion])
                {
                     case -1:
                        qChoice1.Checked = false;
                        qChoice2.Checked = false;
                        qChoice3.Checked = false;
                        qChoice4.Checked = false;
                        break;
                    case 0:
                        qChoice1.Checked = true;
                        break;
                    case 1:
                        qChoice2.Checked = true;
                        break;
                    case 2:
                        qChoice3.Checked = true;
                        break;
                    case 3:
                        qChoice4.Checked = true;
                        break;

                }
                #endregion

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Display current question if >0 >Display it
            if (currentQuestion > 0)
            {
                currentQuestion--;
                DisplayQuestion(questions[currentQuestion]);
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Display current question if < questions.Count >Display it
            if (currentQuestion < questions.Count - 1)
            {
                currentQuestion++;
                DisplayQuestion(questions[currentQuestion]);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            //Are you sure you want to submit the exam?
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit the exam?", "Submit Exam", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int StudentID = 1;
                int ExamID = 0;
                int CourseID = 1;
                db.Database.ExecuteSqlRaw($"Delete from [StudentGrades] Where [CourseID]={CourseID} And [studentID]={StudentID};");
                db.Database.ExecuteSqlRaw($"EXEC [dbo].[GetStudentGrades] @StudentID = {StudentID}, @ExamID = {ExamID} , @CourseID={CourseID};");
                this.Close();

            }
            return;

        }

        private void qChoice1_CheckedChanged(object sender, EventArgs e)
        {
         
                selectedAnswers[currentQuestion] = 0;

                #region Save to Database
                db.Database.ExecuteSqlRaw($"EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = {1}, @ExamID = {0}, @QuestionID = {questions[currentQuestion].QuestionID}, @SelectedAnswerIndex = {selectedAnswers[currentQuestion]};");
                #endregion
            
        }

        private void qChoice2_CheckedChanged(object sender, EventArgs e)
        {
 
                selectedAnswers[currentQuestion] = 1;
                #region Save to Database
                db.Database.ExecuteSqlRaw($"EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = {1}, @ExamID = {0}, @QuestionID = {questions[currentQuestion].QuestionID}, @SelectedAnswerIndex = {selectedAnswers[currentQuestion]};");
                #endregion

        }

        private void qChoice3_CheckedChanged(object sender, EventArgs e)
        {
                selectedAnswers[currentQuestion] = 2;
                #region Save to Database
                db.Database.ExecuteSqlRaw($"EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = {1}, @ExamID = {0}, @QuestionID = {questions[currentQuestion].QuestionID}, @SelectedAnswerIndex = {selectedAnswers[currentQuestion]};");
                #endregion
        }

        private void qChoice4_CheckedChanged(object sender, EventArgs e)
        {      
                selectedAnswers[currentQuestion] = 3;
                #region Save to Database
                db.Database.ExecuteSqlRaw($"EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = {1}, @ExamID = {0}, @QuestionID = {questions[currentQuestion].QuestionID}, @SelectedAnswerIndex = {selectedAnswers[currentQuestion]};");
                #endregion
        }
    }
    public class ExamQuestion
    {
        public int QuestionID { get; set; }
        public string Title { get; set; }

        public string Choices { get; set; }

        //override to string

        public override string ToString()
        {
            return $"{Title}  , {Choices}";
        }
    }
}
