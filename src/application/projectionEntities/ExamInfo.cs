using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.projectionEntities
{
    internal class ExamInfo
    {
        public double Grade { get; set; }

        [Column("CourseName")]
        public string CourseName { get; set; }

    }
}
