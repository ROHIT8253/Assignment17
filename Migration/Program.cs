using MigrationAssignment.Data;
using MigrationAssignment.Models;

class Program
{
    static void Main()
    {
        using var context = new AppDbContext();

        context.Users.Add(new User { Name = "Rohit", Email = "rohit@test.com" });
        context.Employees.Add(new Employee { Name = "John", Department = "IT", Salary = 50000 });
        context.Students.Add(new Student { Name = "Alex", Course = "C#", Age = 22 });

        context.SaveChanges();

        Console.WriteLine("Data inserted successfully!");
    }
}