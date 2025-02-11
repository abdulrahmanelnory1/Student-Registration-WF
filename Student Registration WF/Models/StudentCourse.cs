using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2LinqCF.Models
{
    public class StudentCourse
    {
        public int StdId { get; set;}
        public string CrsId{ get; set;}

        public int Grade { get; set; }

        public virtual Student Crs { get; set; }
        public virtual Course Std { get; set;}


        
    }
}
