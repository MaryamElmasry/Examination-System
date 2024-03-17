using System;
using System.Collections.Generic;

namespace application.Models;

public partial class QuestionPool
{
    public int QuestionId { get; set; }

    public string Title { get; set; }

    public int QuestionType { get; set; }

    public int CorrectAnswerIndex { get; set; }

    public int Grade { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<QuestionChoice> QuestionChoices { get; set; } = new List<QuestionChoice>();

    public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; } = new List<StudentExamQuestion>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
}
