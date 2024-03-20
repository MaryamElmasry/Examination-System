using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Department
{
    public int DeptId { get; set; }

    public string DeptName { get; set; }

    public virtual ICollection<CourseDept> CourseDepts { get; set; } = new List<CourseDept>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
}
