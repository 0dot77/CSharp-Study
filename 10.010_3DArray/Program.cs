namespace _10._010_3DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[4, 3, 2]
            {
                {{1,2}, {3,4}, {5,6}},
                {{7,8}, {9,10}, {11,12}},
                {{13,14}, {15,16}, {17,18}},
                {{19,20}, {21,22}, {23,24}}
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine($"array[{i},{j},{k}] = {array[i, j, k]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
