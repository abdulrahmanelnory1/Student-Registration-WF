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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentCourse", // Name of the join table
                    j => j.HasOne<Course>().WithMany().HasForeignKey("CourseId").HasConstraintName("FK_StudentCourse_Course_CourseId").OnDelete(DeleteBehavior.Cascade),
                    j => j.HasOne<Student>().WithMany().HasForeignKey("StudentId").HasConstraintName("FK_StudentCourse_Student_StudentId").OnDelete(DeleteBehavior.Cascade),
                    j =>
                    {
                        j.HasKey("StudentId", "CourseId");
                        j.ToTable("StudentCourse");
                    })
            .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Courses)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
