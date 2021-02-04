using System;
using System.Collections.Generic;
using FirmProject.Employees;

namespace FirmProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Createing a firm
            Firm Sony = new Firm();

            // Creating employees
            Employee Albert = new Manager(DateTime.Parse("05/12/2015 08:00:00")) { Name = "Albert", Surname = "Milinkovich", Patronymic = "Ivanovich" };
            Employee Anton = new Worker(DateTime.Parse("05/12/2015 08:00:00")) { Name = "Anton", Surname = "Terentiev", Patronymic = "Ivanovich" };
            Employee Grisha = new Foreman(DateTime.Parse("05/12/2015 08:00:00")) { Name = "Grisha", Surname = "Zaharchenko", Patronymic = "Ivanovich" };

            // Adding employees to the firm
            Sony += Albert;
            Sony += Anton;
            Sony += Grisha;

            // Delete the employee from the firm
            Sony -= Anton;

            // Checking type of employee
            Console.WriteLine(Sony.HasEmployee(Albert));
            Console.WriteLine(Sony.HasEmployee(Anton));
            Console.WriteLine(Sony.HasEmployee(Grisha));

            // Print all employees
            Sony.AllEmployees();

            // Getting a list of managers
            List<Employee> managers = new List<Employee>();
            managers = Sony.GetByType("Manager");

            // Print the data of the list
            Console.WriteLine("-------------------------------------------------------------");
            foreach (Employee emp in managers)
            {
                Console.WriteLine(emp.Name + "\t" + emp.Surname + "\t" + emp.Patronymic + "\t" + "Exp: " + emp.Experience);
            }
            Console.WriteLine("-------------------------------------------------------------");

            // Print count of employees by specific type 
            Console.WriteLine(Sony.CountByType("Manager"));
        }
    }
}
