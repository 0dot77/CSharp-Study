﻿namespace _09._010_AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "유태양", Age = "28" };
            Console.WriteLine($"Name : {a.Name}, Age : {a.Age}");

            var b = new {Subject="수학", Scores= new int[] { 90, 80, 70, 60 } };

            Console.Write($"Subject : {b.Subject}, Scores : ");

            foreach(var score in b.Scores)
                Console.Write($"{score} ");

            Console.WriteLine();
        }
    }
}
