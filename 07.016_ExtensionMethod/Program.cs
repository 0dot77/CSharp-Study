using MyExtension;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exp)
        {
            int result = myInt;
            for (int i = 1; i < exp; i++)
            {
                result = result * myInt;
            }
            return result;
        }

    }
}
namespace _07._016_ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
