namespace _07._4_StaticField
{
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Global.Count);

            ClassA a = new ClassA();
            ClassB b = new ClassB();
            ClassA c = new ClassA();
            ClassB d = new ClassB();

            Console.WriteLine(Global.Count);
        }
    }
}
