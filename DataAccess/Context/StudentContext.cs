using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccess.Context
{
    internal class StudentContext : DbContext
    {

        public StudentContext()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { //Husk at ændre i stringen nedenfor
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-C42CI8FE\\SQLEXPRESS;" +
                "Initial Catalog=Students;Integrated Security=SSPI; TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { //kan give problemer senere hen?
            modelBuilder.Entity<Student>().HasData(new Student[] {
              new Student{StudentId=-1,Name="Bob"},
              new Student{StudentId=-2,Name="John"},
              new Student{StudentId=-3,Name="Bent"}
             });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }

}






    


