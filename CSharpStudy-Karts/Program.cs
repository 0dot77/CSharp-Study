namespace CSharpStudy_Karts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster m = new Monster("Goblin", 100, 10, 5, 5, 1);

            Console.WriteLine($"Monster Info: {m.Name}");
        }
    }
}
