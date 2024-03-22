using application.Models;
using application.projectionEntities;
using application.Reports;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;


namespace application.instructorDialog
{

    public partial class PrintForm : Form
    {
        private readonly ReportViewer reportViewer;
        public readonly int _examid ;
        public readonly string _crsname, _deptname;
        public PrintForm(int examid , string crsname,string deptname)
        {
            InitializeComponent();
            Text = "Report viewer";
            WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
            _examid = examid;
            _crsname = crsname;
            _deptname = deptname;
        }
        protected override void OnLoad(EventArgs e)
        {
            using (var ctx = new iti_ExamContext())
            {
                var exam = ctx.Database.SqlQueryRaw<ExamReportView>($"Exec ExamReport {_examid}").ToList();
                using var fs = new FileStream("..\\..\\..\\Reports\\Exam.rdlc", FileMode.Open);
                reportViewer.LocalReport.LoadReportDefinition(fs);
                reportViewer.LocalReport.SetParameters(new ReportParameter("crsname", _crsname));
                reportViewer.LocalReport.SetParameters(new ReportParameter("deptname", _deptname));
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("ExamSet", exam));
            }
            reportViewer.RefreshReport();
            base.OnLoad(e);
        }
    }
}
