namespace _09._015_Record
{
    record RTranscation
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : {Amount,10}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RTranscation tr1 = new RTranscation { From = "Alice", To = "Bob", Amount = 100 };
            RTranscation tr2 = new RTranscation { From = "Bob", To = "Charlie", Amount = 200 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
        }
    }
}
