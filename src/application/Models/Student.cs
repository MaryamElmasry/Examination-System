using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Student
{
    public int? DeptId { get; set; }

    public int StudentId { get; set; }

    public int? Branch { get; set; }

    public virtual Branch BranchNavigation { get; set; }

    public virtual Department Dept { get; set; }

    public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; } = new List<StudentExamQuestion>();

    public virtual ICollection<StudentGrade> StudentGrades { get; set; } = new List<StudentGrade>();

    public virtual User StudentNavigation { get; set; }
}
