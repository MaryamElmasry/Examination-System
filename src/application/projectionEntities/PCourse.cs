using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.projectionEntities
{
    public class PCourse
    {
        public bool isSelected { get; set; }

        public int QuestionId { get; set; }
        public string Title { get; set; }
        public int Grade { get; set; }

        public string Choice { get; set; } 
    }
}
