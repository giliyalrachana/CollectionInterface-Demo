using System;
using System.Collections.Generic;

namespace CollectionInterfaces
{
    // This program demo. how to use Collection which implements IEnumerable interface
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { EmpCode = 100, EmpName = "Rachana", Email = "rachana@gmail.com" };
            Employee employee2 = new Employee { EmpCode = 111, EmpName = "Rachana1", Email = "rachana1@gmail.com" };
            Employee employee3 = new Employee { EmpCode = 222, EmpName = "Rachana2", Email = "rachana2@gmail.com" };
           
            Employees employees = new Employees();
            employees[0] = employee1;
            employees[1] = employee2;
            employees[2] = employee3;

            foreach (var emp in employees)
            {
                Console.WriteLine($"Code={emp.EmpCode}\nName={emp.EmpName}\nEmail={emp.Email}");
            }

                Console.ReadLine();    
        }
    }
}
