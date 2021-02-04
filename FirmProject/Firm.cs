using System.Collections.Generic;

namespace FirmProject
{
    public class Firm
    {
        public Firm()
        {
            _employees = new List<Employee>();
        }

        public List<Employee> _employees { get; set; }

        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                _employees = value;
            }
        }

        public static Firm operator +(Firm firm, Employee emp)
        {
            firm.Employees.Add(emp);
            return firm;
        }

        public static Firm operator -(Firm firm, Employee emp)
        {
            firm._employees.Remove(emp);
            return firm;
        }
    }
}
