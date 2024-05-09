namespace _07._015_PartialClass
{
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    partial class MyClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            c.Method1();
            c.Method3();
        }
    }
}
