using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company CompanyCo = new Company("CompanyCo", DateTime.Now);
            Employee Bre = new Employee("Bre", "Coach", "CEO", DateTime.Now);
            Employee Autumn = new Employee("Autumn", "Fotopolus", "SeniorManager", DateTime.Now);
            Employee Meg = new Employee("Meg", "McGregor", "associate", DateTime.Now);
            CompanyCo.AddEmployee(Bre);
            CompanyCo.AddEmployee(Autumn);
            CompanyCo.AddEmployee(Meg);
            CompanyCo.ListEmployee();
        }
    }
}