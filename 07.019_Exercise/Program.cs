namespace _07._019_Exercise
{
    internal class Program
    {
        struct ACSetting
        {
            public double celcius;
            public double target;

            public double GetFahrenheit()
            {
                target = celcius * 1.8 + 32;
                return target;
            }
        }
        static void Main(string[] args)
        {
            ACSetting ac;
            ac.celcius = 25;
            ac.target = 25;
            Console.WriteLine($"{ac.GetFahrenheit()}");
        }
    }
}
