using MyExtension;

namespace MyExtension
{
    static class MyStringExtension
    {
       public static string Append(this string myString, string stringToAppend)
        {
            return myString + stringToAppend;
        }
    }
}

namespace _07._016_ExtensionString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine(hello.Append("World"));
        }
    }
}
