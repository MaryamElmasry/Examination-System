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

                var report = new Report("Students.rpt", "Students/Departemnt Report");

                report.Parameters.Add("@DeptID", DeptID);

                engine.ShowReport(report);
            }
            public static void DisplayGradesReport(int StudentID ,string StudentName)
            {
                CrystalReportsEngine engine = new CrystalReportsEngine();

                var report = new Report("StudentGrades.rpt", "Student Grades Report");

                report.Parameters.Add("@StudentID", StudentID);

                report.Parameters.Add("Student Name", StudentName);

                engine.ShowReport(report);
            }



        }
    }
}
