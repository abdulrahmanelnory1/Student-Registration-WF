using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2LinqCF.Models
{
    public class CollegeDBContext:DbContext
    {
        public virtual DbSet<Student> Students { get; set; } 
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Department> StudentCourses { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AD\\ABDULRAHMANDIAA;Database=College;Trusted_Connection=True;Encrypt=false");
        }


     
    }
}
