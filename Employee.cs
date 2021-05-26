using System;

namespace Classes
{
    public class Employee
    {
        public Employee(string EmployeeFirstName, string EmployeeLastName, string EmployeeTitle, DateTime EmployeeStartDate)
        {
            FirstName = EmployeeFirstName;
            LastName = EmployeeLastName;
            Title = EmployeeTitle;
            StartDate = EmployeeStartDate;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }

}