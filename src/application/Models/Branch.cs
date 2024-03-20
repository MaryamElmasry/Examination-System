using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public string BranchName { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Department> Depts { get; set; } = new List<Department>();
}
