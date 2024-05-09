namespace _07._017_ReadonlyMethod
{
    internal class Program
    {
        struct ACSetting
        {
            public double currentInCelsius;
            public double target;

            public readonly double GetFahrenheit()
            {
                //target = currentInCelsius * 1.8 + 32;
                return target;
            }
        }
        static void Main(string[] args)
        {
            ACSetting ac;
            ac.currentInCelsius = 20;
            //Console.WriteLine(ac.GetFahrenheit());
        }
    }
}
