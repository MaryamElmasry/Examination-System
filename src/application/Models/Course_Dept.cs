﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Course_Dept
{
    public int CourseID { get; set; }

    public int DeptID { get; set; }

    public virtual Course Course { get; set; }

    public virtual Department Dept { get; set; }
}