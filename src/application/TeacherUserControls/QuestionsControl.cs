using application.instructorDialog;
using application.Models;
using application.projectionEntities;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;


namespace application.TeacherUserControls
{
    public partial class QuestionsControl : UserControl
    {
        public Instructor ins;
        public QuestionsControl()
        {
            InitializeComponent();
            

        }

        private void AddQuestbtn_Click(object sender, EventArgs e)
        {
           

            var addDialog = new AddQuetion("Add" , (int)courselst.SelectedValue);
            addDialog.Show();

        }

        private void EditQuestbtn_Click(object sender, EventArgs e)
        {
            QuestionPool qestion;
            var qs = QuestionsGV.DataSource as List<PCourse>;
            var SelectedQuestion = qs.FirstOrDefault(a => a.isSelected);
            using (var ctx = new iti_ExamContext())
            {
                qestion = ctx.QuestionPools.FromSqlRaw($"select * from questionpools where QuestionID={SelectedQuestion.QuestionId}").Include(c => c.QuestionChoices).FirstOrDefault();
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
                    //ctx.PCourses.FromSqlRaw("EXEC deleteQuestion {0}", SelectedQuestion.QuestionId).ToList();
                    //QuestionsGV.Refresh();

                }

            }

        }
        private void populateCourseList(iti_ExamContext ctx)
        {
            var courses = ctx.Courses.FromSqlRaw("EXEC GetCoursesIns {0}", ins.InstructorId).ToList();
            var combo = this.Controls["courselst"] as ComboBox;
            combo.DataSource = courses;
            combo.DisplayMember = "CourseName";
            combo.ValueMember = "CourseID";
        }
        private void populateQuestionGV(int crsid,iti_ExamContext ctx)
        {
            var questions = ctx.Database.SqlQueryRaw<PCourse>("EXEC GetAllQuestions {0}", crsid).ToList();

            var questionsGV = this.Controls["QuestionsGV"] as DataGridView;
            questionsGV.DataSource = questions;
        }
        private void QuestionsControl_Load(object sender, EventArgs e)
        {
            using (var ctx = new iti_ExamContext())
            {
                populateCourseList(ctx);
                populateQuestionGV((courselst.SelectedItem as Course).CourseId, ctx);
            }
        }

        private void CourseListUpdate(object sender, EventArgs e)
        {
            QuestionsGV.Controls.Clear();
            using (var ctx = new iti_ExamContext())
            {
                if((courselst.SelectedItem as Course) != null)
                populateQuestionGV((courselst.SelectedItem as Course).CourseId, ctx);
            }
        }
    }
}
