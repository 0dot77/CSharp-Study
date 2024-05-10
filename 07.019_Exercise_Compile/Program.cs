namespace _07._019_Exercise_Compile
{
    struct ACSetting
    {
        public readonly double currentInCelsius;
        public readonly double target;

        public ACSetting(int current)
        {
            this.currentInCelsius = current;
            this.target = currentInCelsius * 1.8 + 32;
        }

        public readonly double GetFahrenheit()
        {
            return target;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ACSetting ac = new ACSetting(25);
            Console.WriteLine($"화씨는 : {ac.GetFahrenheit()}");
        }
    }
}
