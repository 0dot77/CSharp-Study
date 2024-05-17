namespace _13._003_GenericDelegate
{
    delegate int Compare<T>(T a, T b);

    internal class Program
    {
        static void Main(string[] args)
        {
            static int AscendCompare<T>(T a, T b) where T : IComparable<T>
            {
                return a.CompareTo(b);
            }
        }
    }
}
