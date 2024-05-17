namespace _09._006_RequiredProperty
{
    class BirthdayInfo
    {
        public required string Name { get; set; }
        public required DateTime BirthDay { get; init; }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(BirthDay).Ticks).Year;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "서현", BirthDay = new DateTime(1991, 6, 28) 
            };

            Console.WriteLine("Name : {0}", birth.Name);

        }
    }
}