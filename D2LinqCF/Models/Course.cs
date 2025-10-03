using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace D2LinqCF.Models
{  

    public class Course
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual List<Student> Students { get; set; }=new List<Student>();
        public virtual Department Department { get; set; }
    }
}
