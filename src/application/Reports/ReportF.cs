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

        internal static void LoadPrintExamReport(LocalReport report , int _examid,string _deptname,string _crsname)
        {
            using (var ctx = new iti_ExamContext())
            {
                var exam = ctx.Database.SqlQueryRaw<ExamReportView>($"Exec ExamReport {_examid}").ToList();
                using var fs = new FileStream("..\\..\\..\\Reports\\Exam.rdlc", FileMode.Open);
                report.LoadReportDefinition(fs);
                report.SetParameters(new ReportParameter("crsname", _crsname));
                report.SetParameters(new ReportParameter("deptname", _deptname));
                report.DataSources.Add(new ReportDataSource("ExamSet", exam));
            }

        }
    }
}
