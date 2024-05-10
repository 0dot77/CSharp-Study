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
                result *= myInt;
            }
            return result;
        }

    }
}

namespace _07._016_ExtensionMethod
{
    class Taeyang
    {
        public int hi = 10; // 4바이트
        public string dkqmkd = "100"; // 8바이트
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
