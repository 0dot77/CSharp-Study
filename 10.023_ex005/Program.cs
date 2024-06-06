using System.Collections;
namespace _10._023_ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["company"] = "Microsoft";
            ht["URL"] = "http://www.microsoft.com";

            Console.WriteLine($"회사 : {ht["company"]} ");
            Console.WriteLine($"URL : {ht["URL"]} ");
        }
    }
}
