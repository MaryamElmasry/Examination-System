using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Department
{
    public int DeptId { get; set; }

    public string DeptName { get; set; }

    public int? BranchId { get; set; }

    public virtual Branch Branch { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
