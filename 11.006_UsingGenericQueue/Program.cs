using System.Collections.Generic;
namespace _11._006_UsingGenericQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while(queue.Count > 0)
            {
                System.Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
