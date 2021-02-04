using System;

namespace FirmProject.Employees
{
    public class Foreman : Employee
    {
        public Foreman(DateTime time) : base(time) { }

        public override void Work() => Console.WriteLine("I buy materials!");

        public void GiveWork() => Console.WriteLine("All employees is live.");
    }
}
