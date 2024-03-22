using System;
using System.Collections.Generic;

namespace application.Models;

public partial class CourseDept
{
    public int CourseId { get; set; }

    public int DeptId { get; set; }

    public int InsId { get; set; }

    public virtual Course Course { get; set; }

    public virtual Department Dept { get; set; }

    public virtual Instructor Ins { get; set; }
}
