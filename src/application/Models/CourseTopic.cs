using System;
using System.Collections.Generic;

namespace application.Models;

public partial class CourseTopic
{
    public string Topic { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; }
}
