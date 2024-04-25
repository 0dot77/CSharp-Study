
namespace _07._5._1_IClonable
{
    class MyClass : ICloneable
    {
        public int MyField1;
        public int MyField2;

        public Object Clone()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;
            return newCopy;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
