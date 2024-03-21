using System;
using System.Collections.Generic;

namespace application.Models;

public partial class StudentExamQuestion
{
    public int SelectedAnswerIndex { get; set; }

    public int ExamId { get; set; }

    public int QuestionId { get; set; }

    public int StudentId { get; set; }

    public virtual Exam Exam { get; set; }

    public virtual QuestionPool Question { get; set; }

    public virtual Student Student { get; set; }
}
