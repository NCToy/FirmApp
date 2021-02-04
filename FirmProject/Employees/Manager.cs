using System;

namespace FirmProject.Employees
{
    public class Manager : Employee
    {
        public Manager(DateTime time) : base(time) { }

        public override void Work() => Console.WriteLine("I take orders!");

        public void GiveWork() => Console.WriteLine("Need to make this product!");
    }
}
