namespace _09._013_EX001
{
    internal class Program
    {
        class NameCard
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();

            MyCard.Age = 24;
            MyCard.Name = "태양";
        }
    }
}
