namespace _07._017_ReadonlyStruct
{
    internal class Program
    {
        readonly struct RGBColor
        {
            public readonly byte R;
            public readonly byte G;
            public readonly byte B;

            public RGBColor(byte r, byte g, byte b)
            {
                R = r;
                G = g;
                B = b;
            }
        }
        static void Main(string[] args)
        {
            RGBColor red = new RGBColor(255, 0, 0);
            //red.G = 100; 컴파일 에러

        }
    }
}
