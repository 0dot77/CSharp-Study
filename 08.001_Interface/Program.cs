namespace _08._001_Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ConsoleLogger logger) // 결국 같은 참조 타입이기 때문에 부모 클래스의 타입 형식에 파생 클래스의 타입이 할당될 수 있다.
        {
            this.logger = logger;
        }

        public void start()
        {
            while(true)
            {
                Console.WriteLine
                    ("온도를 입력해주세요: ");

                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재 온도: " + temperature);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
