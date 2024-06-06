namespace _10._020_ex002
{
    internal class Program
    {
        static void multiply2DArray(int[,] a, int[,] b)
        {
            int rows1 = a.GetLength(0);
            int cols1 = a.GetLength(1);
            int rows2 = b.GetLength(0);
            int cols2 = b.GetLength(1);

            if(cols1 != rows2)
                throw new InvalidOperationException("Matrix dimensions are not valid for multiplication");

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

           for(int i = 0; i < rows1; i++)
            {
                for(int j = 0; j < cols2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2] { { 3,2 }, { 1,4 } };
            int[,] b = new int[2, 2] { { 9,2 }, { 1,7 } };

            Console.WriteLine(a);

            multiply2DArray(a, b);
        }
    }
}
