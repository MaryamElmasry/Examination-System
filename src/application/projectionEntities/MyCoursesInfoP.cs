using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.projectionEntities
{
    public class MyCoursesInfoP
    {
        
        public string CourseName {  get; set; }
        [Column("Number of Students")]
        public int NumberOfStudents { get; set; }
    
    }
}
