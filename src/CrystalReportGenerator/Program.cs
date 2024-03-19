using LijsDev.CrystalReportsRunner.Core;

namespace CrystalReportGenerator
{
    public class Program
    {
        public static void Main()
        {
            
        }
        public class ReportGenerator
        {
            public static void DisplayReport(string reportPath = "CrystalReport.rpt")
            {
                CrystalReportsEngine engine = new CrystalReportsEngine();

                var report = new Report(reportPath, "Report");

                engine.ShowReport(report);
            }
            // DisplayDeptReport
            public static void DisplayDeptReport(int DeptID)
            {
                CrystalReportsEngine engine = new CrystalReportsEngine();

                var report = new Report("CrystalReport.rpt", "Students/Departemnt Report");

                report.Parameters.Add("@DeptID", DeptID);

                engine.ShowReport(report);
            }


        }
    }
}
