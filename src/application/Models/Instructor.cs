#nullable disable

using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Instructor
{
    public int BranchId { get; set; }

    public int InstructorId { get; set; }

    public virtual Branch Branch { get; set; }

    public virtual User InstructorNavigation { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
