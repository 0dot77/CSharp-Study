using System.Numerics;

namespace _07._1_review
{
    class Cat
    {
        string name;
        string color;
        int age;

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat(string name, string color, int age)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }

        public void setNewName(string newName)
        {
            this.name = newName;
        }

        public void getName()
        {
            Console.WriteLine(this.name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("야옹이", "검정", 3);

            cat1.getName();

            cat1.setNewName("호춘이");

            cat1.getName();
        }
    }
}
