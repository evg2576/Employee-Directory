using Microsoft.EntityFrameworkCore;

namespace Employee_Directory.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set;}
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}
