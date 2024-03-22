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
        private int sid;
        private int examid;
        string mode;
        int insid;

        public PrintForm()
        {
            InitializeComponent();
            Text = "Report viewer";
            WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
           
        }
        public PrintForm(int examid , string crsname,string deptname , string _mode):this()
        {
            _examid = examid;
            _crsname = crsname;
            _deptname = deptname;
            mode = _mode;
        }
      
        public PrintForm(int sid , int examid):this()
        {
            this.sid = sid;
            this.examid = examid;
        }
        public PrintForm(int insid,string mode):this()
        {
            this.mode = mode;
            this.insid = insid;

        }
        protected override void OnLoad(EventArgs e)
        {
            if(mode == "PrintExam") {
                ReportF.LoadPrintExamReport(reportViewer.LocalReport, _examid, _deptname, _crsname);

            }else if(mode == "MyCoursesInfo")
            {
                ReportF.LoadCoursesInfo(reportViewer.LocalReport, insid);
            }
            reportViewer.RefreshReport();
            base.OnLoad(e);
        }
    }
}
