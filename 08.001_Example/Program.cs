namespace _08._001_Example
{
    interface IHajung
    {
        void GoToUniversity();
    }

    interface ITaeyang
    {
        void DoWork();
    }

    class Hajung : IHajung, ITaeyang
    {
        // 클래스는 단일 상속, 접근 제어자 사용 가능
        // 인터페이스 기본적으로 퍼블릭만 가능하다.
        public void GoToUniversity()
        {
            Console.WriteLine("Go to University");
        }

        public void DoWork()
        {
            Console.WriteLine("Do Work");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
