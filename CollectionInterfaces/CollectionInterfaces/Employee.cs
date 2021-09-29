using System;
using System.Collections;
using System.Collections.Generic;


namespace CollectionInterfaces
{
    // This class implements IEnumerable interface
    class Employees : IEnumerable<Employee>
    {
        List<Employee> employeeList = new List<Employee>();
        // Indexer property
        public Employee this[int index]

        public IEnumerator<Employee> GetEnumerator()
        {
            return employeeList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
        // Indexer property
        public Employee this[int index]
        {
            get
            {
                return employeeList[index];
            }
            set
            {
                employeeList.Add(value);

            }

        }
        
    }
    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }


    }
}
