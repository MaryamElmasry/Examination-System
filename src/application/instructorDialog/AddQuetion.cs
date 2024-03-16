﻿using application.Models;
using application.TeacherUserControls;
using Microsoft.EntityFrameworkCore;


namespace application.instructorDialog
{
    public partial class AddQuetion : Form
    {
        string mode = string.Empty;
        QuestionPool questionPool;
        public AddQuetion(string mode)
        {
            InitializeComponent();
            this.mode = mode;
        }
        public AddQuetion(string mode, QuestionPool question)
        {
            InitializeComponent();
            this.mode = mode;
            this.questionPool = question;
            if (question.QuestionType == 1)
            {
                MCQRadio.Checked = true;

            }
            else
            {
                TFRadio.Checked = true;
            }
            MCQRadio.Enabled = false;
            TFRadio.Enabled = false;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mcqAddEdit1.Visible = true;
            tfAddEdit1.Visible = false;
        }

        private void mcqAddEdit1_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var quest = new QuestionPool();
            quest.Title = textBox1.Text;
            quest.CorrectAnswerIndex = GetCorrectAns();
            if (quest.CorrectAnswerIndex == 0)
            {
                throw new Exception("try to select at least one question");
            }

            SetQuestionChoices(quest);
            var ch1 = quest.QuestionChoices.ElementAt(0).Choice;
            var ch2 = quest.QuestionChoices.ElementAt(1).Choice;
            var ch3 = quest.QuestionChoices.ElementAt(2).Choice;
            var ch4 = quest.QuestionChoices.ElementAt(3).Choice;
            var qType = TFRadio.Checked ? 0: 1;
            using (var ctx = new iti_ExamContext())
            {

                ctx.Database.ExecuteSqlRaw($"EXEC AddQuestion '{quest.Title}', '{ch1}', '{ch2}', '{ch3}', '{ch4}', '{qType}', {quest.CorrectAnswerIndex}, 3, 4");
                MessageBox.Show("Question Added Successfully");
                this.Close();
                ctx.SaveChanges();

            }

        }

        private void SetQuestionChoices(QuestionPool quest)
        {
            if (MCQRadio.Checked)
            {
                quest.QuestionChoices = new List<QuestionChoice>
            {
                new QuestionChoice()
                {
                    Choice = (mcqAddEdit1.Controls["Qc1"] as TextBox).Text,
                    ChoiceIndex = 1
                },
                new QuestionChoice()
                {
                    Choice = (mcqAddEdit1.Controls["Qc2"] as TextBox).Text,
                    ChoiceIndex = 2
                },
                new QuestionChoice()
                {
                    Choice = (mcqAddEdit1.Controls["Qc3"] as TextBox).Text,
                    ChoiceIndex = 3
                },
                new QuestionChoice()
                {
                    Choice = (mcqAddEdit1.Controls["Qc4"] as TextBox).Text,
                    ChoiceIndex = 4
                }
            };
            }
            else if (TFRadio.Checked)
            {

                quest.QuestionChoices = new List<QuestionChoice>
            {
                new QuestionChoice()
                {
                    Choice = "true",
                    ChoiceIndex = 1
                },
                new QuestionChoice()
                {
                    Choice = "false",
                    ChoiceIndex = 2
                },

               null,

                null,

                };

            }




        }
        private int GetCorrectAns()
        {
            if (MCQRadio.Checked)
            {
                if ((mcqAddEdit1.Controls["Qr1"] as RadioButton).Checked)
                {
                    return 1;
                }
                else if ((mcqAddEdit1.Controls["Qr2"] as RadioButton).Checked)
                {
                    return 2;
                }
                else if ((mcqAddEdit1.Controls["Qr3"] as RadioButton).Checked)
                {
                    return 3;
                }
                else if ((mcqAddEdit1.Controls["Qr3"] as RadioButton).Checked)
                {
                    return 4;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if ((tfAddEdit1.Controls["TrueBtn"] as RadioButton).Checked)
                {
                    return 1;
                }
                else if ((mcqAddEdit1.Controls["FalseBtn"] as RadioButton).Checked)
                {
                    return 2;
                }
                else
                {
                    return -1;
                }
            }

        }
        private void CheckTheCorrectRadio(QuestionPool quest)
        {
            if (MCQRadio.Checked) {

                (mcqAddEdit1.Controls[$"Qr{quest.CorrectAnswerIndex}"] as RadioButton).Checked = true;
            }
            else
            {
                if (quest.CorrectAnswerIndex == 1)
                    (mcqAddEdit1.Controls["TrueBtn"] as RadioButton).Checked = true;
                else if (quest.CorrectAnswerIndex == 2)
                    (mcqAddEdit1.Controls["FalseBtn"] as RadioButton).Checked = true;


            }

        }
        private void TFRadio_CheckedChanged(object sender, EventArgs e)
        {
            mcqAddEdit1.Visible = false;
            tfAddEdit1.Visible = true;
        }

        private void AddQuetion_Load(object sender, EventArgs e)
        {
            if(mode == "Edit")
            {
                populateControls(questionPool);
            }
        }

        private void populateControls(QuestionPool questionPool)
        {
           
            textBox1.Text = questionPool.Title;

            if (questionPool.QuestionType == 1)
            {
                List<QuestionChoice> choices = questionPool.QuestionChoices.ToList();

                for (int i = 0; i < choices.Count; i++)
                {
                    RadioButton radioButton = mcqAddEdit1.Controls["Qr" + (i + 1)] as RadioButton;

                    (mcqAddEdit1.Controls[$"Qc{i+1}"] as TextBox).Text = choices[i].Choice;
                }
            }
            CheckTheCorrectRadio(questionPool);


        }

    }
}
