using System;

namespace _07._6_This
{
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");

            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");

            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");

        }
    }
}
