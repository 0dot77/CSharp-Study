namespace _11._002_Generic
{
    class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
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
