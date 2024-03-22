using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; }

    public virtual ICollection<CourseTopic> CourseTopics { get; set; } = new List<CourseTopic>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<QuestionPool> QuestionPools { get; set; } = new List<QuestionPool>();

    public virtual ICollection<StudentGrade> StudentGrades { get; set; } = new List<StudentGrade>();

    public virtual ICollection<Department> Depts { get; set; } = new List<Department>();

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}
