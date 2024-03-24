using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using application.Models;
using application.projectionEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace application.Reports
{
    internal class ReportF
    {
      
        internal record InsInfo(string UserName, string BranchName);
        internal record ExamInfo(double Grade, string CourseName);


        internal static void LoadPrintExamReport(LocalReport report , int _examid,string _deptname,string _crsname)
        {
            using (var ctx = new iti_ExamContext())
            {
                var exam = ctx.Database.SqlQueryRaw<ExamReportView>($"Exec ExamReport {_examid}").ToList();
                var info = ctx.Exams.FromSqlRaw($"Exec getExambyId {_examid}").ToList().FirstOrDefault();
                using var fs = new FileStream("..\\..\\..\\Reports\\Exam.rdlc", FileMode.Open);
                report.LoadReportDefinition(fs);
                report.SetParameters(new ReportParameter("crsname", _crsname));
                report.SetParameters(new ReportParameter("Deptname", _deptname));
                report.SetParameters(new ReportParameter("date", info.ExamDate.Date.ToString("yyyy-MM-dd")));
                report.SetParameters(new ReportParameter("time", info.ExamDate.TimeOfDay.ToString("hh\\:mm\\:ss")));
                report.SetParameters(new ReportParameter("duration", info.Duration.ToString()));
                report.DataSources.Add(new ReportDataSource("ExamSet", exam));
            }


        }
        internal static void LoadCoursesInfo(LocalReport report, int insid)
        {

            using (var ctx = new iti_ExamContext())
            {
                var crs = ctx.Database.SqlQueryRaw<MyCoursesInfoP>($"Exec getStudentsPerCourse {insid}").ToList();
                var info = ctx.Database.SqlQueryRaw<InsInfo>($"Exec GetInstructorByid {insid}").ToList().FirstOrDefault();
                using var fs = new FileStream("..\\..\\..\\Reports\\CourseInfo.rdlc", FileMode.Open);
                report.LoadReportDefinition(fs);
                report.SetParameters(new ReportParameter("InsName", info.UserName));
                report.SetParameters(new ReportParameter("InsBranch", info.BranchName));
                report.DataSources.Add(new ReportDataSource("CoursesInfo", crs));

            }
        }
        internal static void LoadTopics(LocalReport report, int courseId)
        {

            using (var ctx = new iti_ExamContext())
            {
                var topics = ctx.CourseTopics.FromSqlRaw($"exec GetCourseTopics {courseId} ").ToList();
                dynamic course  = ctx.Courses.FromSqlRaw($"select * from courses where courseid =  {courseId} ").ToList().FirstOrDefault();
                using var fs = new FileStream("..\\..\\..\\Reports\\Topics.rdlc", FileMode.Open);
                report.LoadReportDefinition(fs);
                report.SetParameters(new ReportParameter("CourseName", course.CourseName));
                report.DataSources.Add(new ReportDataSource("DataSet1",topics));

            }
        }
        internal static void DetailedExamReport(LocalReport report, int ExamId,int stdId)
        {
            using (var ctx = new iti_ExamContext())
            {
                dynamic result = ctx.Database.SqlQueryRaw<DetailedExam>($"EXEC GetExamForStdReport {ExamId}, {stdId}").ToList();
                dynamic std  = ctx.Users.FromSqlRaw($"select * from users where UserID = {stdId}").ToList().FirstOrDefault();
                var examInfo = ctx.Database.SqlQueryRaw<ExamInfo>($"EXEC GetExamInfo {ExamId}, {stdId}").ToList().FirstOrDefault();
                using var fs = new FileStream("..\\..\\..\\Reports\\DetailedExam.rdlc", FileMode.Open);
                report.LoadReportDefinition(fs);
                report.SetParameters(new ReportParameter("stdName", std.UserName));
                report.SetParameters(new ReportParameter("ExamName", examInfo.CourseName));
                report.SetParameters(new ReportParameter("Grade", examInfo.Grade.ToString()));
                report.DataSources.Add(new ReportDataSource("DataSet2",result));
                
            }
        }








    }
}
