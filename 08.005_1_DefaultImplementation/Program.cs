namespace _08._005_1_DefaultImplementation
{
    interface ILogger
    {
        // 5년 전에 작성 된 것
        void WriteLog(string message);

        // 현재 작성한 것
        void WriteError(string error)
        {
            WriteError(error);
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");
        }
    }
}