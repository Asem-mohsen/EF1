using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
    public class ITIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDatabase;Trusted_Connection=True;TrustServerCertificate =true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API Configuration
            modelBuilder.Entity<Department>().HasKey(d => d.ID);
            modelBuilder.Entity<Department>().Property(d => d.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Instructor>().HasKey(i => i.ID);
            modelBuilder.Entity<Instructor>().Property(i => i.Name).IsRequired();
        }
    }

}
