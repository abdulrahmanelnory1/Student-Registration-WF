using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D2LinqCF.Models
{
    

    public class Course
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<Student> Students { get; set; }=new List<Student>();
    }
}
