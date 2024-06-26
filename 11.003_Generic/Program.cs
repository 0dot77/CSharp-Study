﻿namespace _11._003_Generic
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

            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";

            for(int i = 0; i < str_list.Length; i++)
            {
                Console.WriteLine(str_list[i]);
            }

            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 1;
            int_list[1] = 2;
            int_list[2] = 3;
            int_list[3] = 4;
            int_list[4] = 5;

            for(int i = 0; i < int_list.Length; i++)
            {
                Console.WriteLine(int_list[i]);
            }
        }
    }
}
