using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListThings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new Employee[]
            {
                new Employee{ Name = "Jasmine"},
                new Employee{ Name = "Lily"}
            };

            foreach(var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
            for(int i=0; i<employees.Count; i++)
            {
                Console.WriteLine(employees[i].Name);
            }
            Array.Resize(ref employees, 10);
        }
    }
}
