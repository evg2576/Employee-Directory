using System.Linq;
using Employee_Directory.Models;
namespace Employee_Directory
{
    public class SampleData
    {
        public static void Initialize(EmployeeContext context)
        {
            if (!context.Employees.Any())
            {
                for (int i = 0; i < 1000; i++)
                {
                    context.Employees.Add(new Employee {
                        Name = "Alexander " + i,
                        Department = "Automation " + i,
                        PhoneNumber = "+7777777" + i
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
