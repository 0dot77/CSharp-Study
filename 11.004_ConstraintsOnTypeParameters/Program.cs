using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _11._004_ConstraintsOnTypeParameters
{
    public class StructArray<T> where T : struct
    {
        // Array는 T형식의 배열 (그런데, struct 제약조건을 가지고 있음)
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class
    {
        // T가 참조 타입, 클래스다.
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }

    }
        class Base { }
        class Derived : Base { }
        class BaseArray<U> where U : Base
            // U는 Base 클래스 형식으로 제한된다.
        {
            public U[] Array { get; set; }
            public BaseArray(int size)
            {
                Array = new U[size];
            }

            public void CopyArray<T>(T[] Source) where T : U
            {
                Source.CopyTo(Array, 0);
            }
        }
    internal class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        
        {
            StructArray<int> a= new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;
            Console.WriteLine($"a : {a.Array[0]}, {a.Array[1]}, {a.Array[2]}");

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived(); // Base의 파생클래스인 Derived 클래스도 Base 클래스로 형변환이 가능하다.
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>(); // 여기서 Base 클래스를 사용할 수 없는 이유는 Derived가 Base의 파생 클래스이기 때문이다.

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);

        }
    }
}
