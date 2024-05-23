namespace _09._018_AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "Alice", Age = 34 };
            Console.WriteLine($"Name : {a.Name}, Age : {a.Age}");

            var b = new { Subject = "Math", Scores = new int[] { 90, 87, 93 } };

            Console.WriteLine($"Subject : {b.Subject}, Scores: ");

            foreach (var score in b.Scores)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine();
        }
    }
}
