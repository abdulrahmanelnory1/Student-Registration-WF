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
        public List <Student> students { get; set; } = new List<Student>();


    }
}
