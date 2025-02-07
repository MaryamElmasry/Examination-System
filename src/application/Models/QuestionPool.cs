﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace application.Models;

public partial class QuestionPool
{
    public int QuestionID { get; set; }

    public string Title { get; set; }

    public int QuestionType { get; set; }

    public int CorrectAnswerIndex { get; set; }

    public int Grade { get; set; }

    public int CourseID { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<ExamQuestion> ExamQuestions { get; set; } = new List<ExamQuestion>();

    public virtual ICollection<QuestionChoice> QuestionChoices { get; set; } = new List<QuestionChoice>();

    public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; } = new List<StudentExamQuestion>();
}