using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.projectionEntities
{
    internal class ExamAnswersDetails
    {
        public string Question {  get; set; }
        [Column("selected Choice")]
        public string selectedChoice { get; set; }
        [Column("correct Choice")]
        public string CorrectChoice { get; set; }
    }
}
