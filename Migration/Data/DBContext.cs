using Microsoft.EntityFrameworkCore;
using MigrationAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationAssignment.Data
{

    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=ROCKY;Database=Assign;Trusted_Connection=True;Encrypt=False;");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Rohit", Email = "rohit@example.com" },
                new User { Id = 2, Name = "Sneha", Email = "sneha@example.com" }
            );

            // Seeding Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 2, Name = "Amit", Department = "IT", Salary = 60000 },
                new Employee { Id = 3, Name = "Priya", Department = "HR", Salary = 45000 }
            );

            // Seeding Students
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Rahul", Course = "CSE", Age = 21 },
                new Student { Id = 2, Name = "Pooja", Course = "ECE", Age = 22 }
            );
        }
    }
} 