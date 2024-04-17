using System.Collections;

namespace _4._8._0_NullConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a 자체가 null을 반환하기 때문에 뒤에 메소드 사용 불가
            a?.Add("축구");
            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

            a = new ArrayList();
            a?.Add("야구");
            Console.WriteLine($"Count : {a?.Count}");
        }
    }
}