namespace _07._2_OOPAndCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine("{0} : {1}", kitty.Name, kitty.Color);

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name}, {nero.Color}");
        }
    }
}
