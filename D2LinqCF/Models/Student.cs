using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2LinqCF.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Address { get; set; }
        public int deptId { get; set; }
        public virtual Department dept { get; set;}

        public ICollection<Course> Courses { get; set; } = new List<Course>();
      

    }
}
