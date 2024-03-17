using System;
using System.Collections.Generic;

namespace application.Models;

public partial class QuestionChoice
{
    public string Choice { get; set; }

    public int QuestionId { get; set; }

    public int ChoiceIndex { get; set; }

    public virtual QuestionPool Question { get; set; }
}
