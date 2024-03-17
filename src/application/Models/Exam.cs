using System;
using System.Collections.Generic;

namespace application.Models;

public partial class Exam
{
    public int ExamId { get; set; }

    public DateTime ExamDate { get; set; }

    public int Duration { get; set; }

    public int? CourseId { get; set; }

    public int? DeptId { get; set; }

    public virtual Course Course { get; set; }

    public virtual Department Dept { get; set; }

    public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; } = new List<StudentExamQuestion>();

    public virtual ICollection<QuestionPool> Questions { get; set; } = new List<QuestionPool>();
}
