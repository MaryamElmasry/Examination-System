using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Instructor
{
    public int BranchId { get; set; }

    public int InstructorId { get; set; }

    public virtual Branch Branch { get; set; }

    public virtual ICollection<CourseDept> CourseDepts { get; set; } = new List<CourseDept>();

    public virtual User InstructorNavigation { get; set; }
}
