using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }
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

        public void ListEmployee()
        {
            foreach (Employee data in Employees)
            {
                Console.WriteLine($"{data.FirstName} {data.LastName} works for CompanyCo as {data.Title} since {data.StartDate}");
            }
        }

    }
}