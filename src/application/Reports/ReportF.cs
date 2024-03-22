using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Models;
using application.projectionEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace application.Reports
{
    internal class ReportF
    {
      
        internal record InsInfo(string UserName, string BranchName);


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








    }
}
