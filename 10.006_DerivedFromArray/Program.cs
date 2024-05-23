namespace _10._006_DerivedFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {10, 30, 20, 7, 1 };
            Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Base type of array : {array.GetType().BaseType}");
        }
    }
}
