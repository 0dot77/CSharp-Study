using System.Collections;
namespace _10._015_UsingHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["one"] = 1;
            ht["two"] = 2;
            ht["three"] = 3;
            ht["four"] = 4;
            ht["five"] = 5;

            Console.WriteLine(ht["one"]);
            Console.WriteLine(ht["two"]);
            Console.WriteLine(ht["three"]);
            Console.WriteLine(ht["four"]);
            Console.WriteLine(ht["five"]);
        }
    }
}