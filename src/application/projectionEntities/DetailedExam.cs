using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.projectionEntities
{
    public class DetailedExam
    {
        public string Question { get; set; }
        [Column("Correct Answer")]
        public string CorrectAnswer { get; set; }
        public string AnswerStatus { get; set; }
        public string StudentAnswer { get; set; }
    }
}
