namespace _0405_Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######## 4.9");
            // &
            // |
            // ^
            // ~

            int x = 10;
            // 0b1010

            int y = 9;
            // 0b1001

            Console.WriteLine(x & y);

            //0b1010
            //0b1001
            //0b1000 -> 8

            Console.WriteLine(x | y);

            //0b1010
            //0b1001
            //0b1011

            Console.WriteLine(x ^ y);

            //0b1010
            //0b1001
            //0b0011

            Console.WriteLine("######## 4.10");

            int? s = null;
            
            Console.WriteLine(s ?? 100);

            Console.WriteLine("######## 문제");

            // 1

            //int a1 = 12;
            //int b1 = 6;

            // b1 = 0b0110
            // a1 = 0b1100
            // a | b = 0b1110 = 14

            // 2

            // b = 14
            // a = 12

            // -> a = -2

            // 3

            // a = 14 / -1
            // a = -14

            // a = -14
            // b = 14

            Console.WriteLine("######## 5.1");

        }
    }
}
