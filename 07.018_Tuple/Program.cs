namespace _07._018_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1} {a.Item2}");

            var b = (Name: "배트맨", Level: 9999);
            Console.WriteLine($"{b.Name} {b.Level}");

            // 분해
            var (Name, Level) = b;
            Console.WriteLine($"{Name} {Level}");

            // 분해2
            var (Name2, Age2) = ("스파이더맨", 20);
            Console.WriteLine($"{Name2} {Age2}");
        }
    }
}
