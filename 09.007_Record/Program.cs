namespace _09._007_Record
{
    internal class Program
    {
        record RTransaction
        {
            public string From { get; init; }
            public string To { get; init; }
            public int Amount { get; init; }

            public override string ToString()
            {
                return $"{From,-10} -> {To,-10} : ${Amount}";
            }
        }
        static void Main(string[] args)
        {
            RTransaction tr1 = new RTransaction()
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            RTransaction tr2 = new RTransaction()
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
        }
    }
}
