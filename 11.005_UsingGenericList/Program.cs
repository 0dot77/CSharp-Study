using System;
using System.Collections.Generic;
namespace _11._005_UsingGenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (int el in list)
                Console.WriteLine(el);
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (int el in list)
                Console.WriteLine(el);
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int el in list)
                Console.WriteLine(el);
            Console.WriteLine();
        }
    }
}
