namespace _09._014_EX002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "박상현", Age = 17 };

            Console.WriteLine($"이름 : {nameCard.Name}, 나이 : {nameCard.Age}");
        }
    }
}
