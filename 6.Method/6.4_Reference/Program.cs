namespace _6._4_Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");
            Swap(ref x, ref y);

            Console.WriteLine($"x:{x}, y:{y}");
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
