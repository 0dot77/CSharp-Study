using System.Collections;

namespace _10._016_InitializingCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                Console.WriteLine($"ArrayList : {item}");
            Console.WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
                Console.WriteLine($"Stack : {item}");
            Console.WriteLine();

            Queue queue = new Queue(arr);
            foreach (object item in queue)
                Console.WriteLine($"Queue : {item}");
            Console.WriteLine();

            ArrayList list2 = new ArrayList() { 11, 12, 13 };
            foreach (object item in list2)
                Console.WriteLine($"ArrayList2 : {item}");
            Console.WriteLine();
        }
    }
}