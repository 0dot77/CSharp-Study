namespace _07._10_review
{
    class MyOverride
    {
        virtual public void Start()
        {
        }
    }

    class MyOverride2 : MyOverride
    {
        override public void Start()
        {
            Console.WriteLine("MyOverride2.Start()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyOverride my1 = new MyOverride(); // 클래스의 인스턴스 생성
            my1.Start();

            MyOverride2 my2 = new MyOverride2(); // 클래스의 인스턴스 생성
            my2.Start();
        }
    }
}
