using System.Collections.Generic;
using System.Linq;
using System;

namespace FirmProject
{
    public static class Extension
    {
        public static bool HasEmployee(this Firm firm, Employee emp) => firm.Employees.Any(e => e == emp);

        public static void AllEmployees(this Firm firm)
        {
            Console.WriteLine("-------------------------------------------------------------");
            foreach (Employee emp in firm.Employees)
            {
                Console.WriteLine(emp.Name + "\t" + emp.Surname + "\t" + emp.Patronymic + "\t" + "Exp: " + emp.Experience);
            }
            Console.WriteLine("-------------------------------------------------------------");

        }

        public static List<Employee> GetByType(this Firm firm, string type) => firm.Employees.Where(e => e.GetType().ToString().Replace("FirmProject.Employees.", "").ToLower() == type.ToLower()).ToList();

        public static int CountByType(this Firm firm, string type) => firm.Employees.Where(e => e.GetType().ToString().Replace("FirmProject.Employees.", "").ToLower() == type.ToLower()).ToList().Count;
    }
}
