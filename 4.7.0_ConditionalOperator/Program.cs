namespace _4._7._0_ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}