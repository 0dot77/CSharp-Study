namespace _07._5_review
{
    class Cat
    {
        public int age;
        public string name;
        public string color;

        public Cat(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public Cat(string color) : this(10,"야옹")
        {
            this.color = color;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("white");
            Console.WriteLine($"{myCat.age} {myCat.name} {myCat.color}");
        }
    }
}
