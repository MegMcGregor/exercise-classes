using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        public Company(string EmployeeName, DateTime date)
        {
            Name = EmployeeName;
            CreatedOn = date;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee NewEmployee)
        {
            Employees.Add(NewEmployee);
        }

    }
}