using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; }

    public virtual ICollection<CourseTopic> CourseTopics { get; set; } = new List<CourseTopic>();

    public virtual ICollection<Course_Dept> Course_Depts { get; set; } = new List<Course_Dept>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Instructor_Course> Instructor_Courses { get; set; } = new List<Instructor_Course>();

    public virtual ICollection<QuestionPool> QuestionPools { get; set; } = new List<QuestionPool>();

    public virtual ICollection<StudentGrade> StudentGrades { get; set; } = new List<StudentGrade>();

    public virtual ICollection<Department> Depts { get; set; } = new List<Department>();

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
}
