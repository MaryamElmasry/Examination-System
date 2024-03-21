using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public string BranchName { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}

