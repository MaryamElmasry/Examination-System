using application.instructorDialog;
using application.Models;
using application.projectionEntities;
using Microsoft.EntityFrameworkCore;


namespace application.TeacherUserControls
{
    public partial class QuestionsControl : UserControl
    {
        public QuestionsControl()
        {
            InitializeComponent();
        }

        private void AddQuestbtn_Click(object sender, EventArgs e)
        {
            var qs = QuestionsGV.DataSource as List<PCourse>;
            var SelectedQuestion = qs.FirstOrDefault(a => a.isSelected);
          
            var addDialog = new AddQuetion("Add");
            addDialog.Show();

        }

        private void EditQuestbtn_Click(object sender, EventArgs e)
        {
            QuestionPool qestion;
            var qs = QuestionsGV.DataSource as List<PCourse>;
            var SelectedQuestion = qs.FirstOrDefault(a => a.isSelected);
            using (var ctx = new iti_ExamContext())
            {
                qestion = ctx.QuestionPools.FromSqlRaw($"select * from questionpools where QuestionID={SelectedQuestion.QuestionId}").Include(c => c.QuestionChoices).FirstOrDefault() ;
            }
            if (SelectedQuestion == null)
            {
                MessageBox.Show("please Select At least one Question");

            }
            else
            {
                var addDialog = new AddQuetion("Edit", qestion); ;
                addDialog.Show();

            }


        }

        private void DeleteQuestbtn_Click(object sender, EventArgs e)
        {
            var qs = QuestionsGV.DataSource as List<PCourse>;
            var SelectedQuestion = qs.FirstOrDefault(a => a.isSelected);
            if (SelectedQuestion == null)
            {
                MessageBox.Show("please Select At least one Question");

            }
            else
            {
                using (var ctx = new iti_ExamContext())
                {
                    ctx.PCourses.FromSqlRaw("EXEC deleteQuestion {0}",SelectedQuestion.QuestionId).ToList();
                    QuestionsGV.Refresh();

                }

            }
           
        }
    }
}
