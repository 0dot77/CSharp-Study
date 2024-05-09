using System.Threading.Tasks.Dataflow;

namespace _07._018_PositionalPattern
{
    internal class Program
    {
        private static double GetDiscountRate(object client)
            {
                return client switch
                {
                    ("학생", int n) when n < 18 => 0.2,
                    ("학생", _) => 0.1,
                    ("일반", int n) when n < 18 => 0.1,
                    ("일반", _) => 0.05,
                    _ => 0,
                };
            }
        static void Main(string[] args)
        {
            var alice = (job:"학생", age:17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave = (job: "일반", age: 25);

            Console.WriteLine(GetDiscountRate(alice));
            Console.WriteLine(GetDiscountRate(bob));
            Console.WriteLine(GetDiscountRate(charlie));
            Console.WriteLine(GetDiscountRate(dave));
        }
    }
}
