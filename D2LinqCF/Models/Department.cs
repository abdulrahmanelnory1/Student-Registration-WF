using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2LinqCF.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List <Student> Students { get; set; } = new List<Student>();

        public List <Course> Courses { get; set; } = new List<Course>();


    }
}
