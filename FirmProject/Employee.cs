using System;

namespace FirmProject
{
    public class Employee
    {
        public Employee(DateTime time)
        {
            _experience = time;
        }

        // Personal data
        private string _name { get; set; }
        private string _surname { get; set; }
        private string _patronymic { get; set; }

        private DateTime _experience { get; }

        #region Properties
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Patronymic { get => _patronymic; set => _patronymic = value; }
        public double Experience { get => DateTime.Now.Subtract(_experience).TotalDays / 365; }
        #endregion

        public virtual void Work() { }
    }
}
