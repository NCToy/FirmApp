using System;

namespace FirmProject.Employees
{
    public class Worker : Employee
    {
        public Worker(DateTime time) : base(time) { }

        public override void Work() => Console.WriteLine("I make some product!");
    }
}
