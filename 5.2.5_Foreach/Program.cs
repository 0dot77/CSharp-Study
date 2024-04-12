using System;
namespace _5._2._5_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}