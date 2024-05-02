namespace _07._6._2_DeepCopyExample
{
    internal class Program
    {
        public int MyFiled1;
        public int MyFiled2;
        static void Main(string[] args)
        {
            Program source = new Program();
            source.MyFiled1 = 10;
            source.MyFiled2 = 20;

            Program target = source.DeepCopy();
            target.MyFiled1 = 30;
            target.MyFiled2 = 40;

            Console.WriteLine($"source: {source.MyFiled1}, {source.MyFiled2}");
            Console.WriteLine($"target: {target.MyFiled1}, {target.MyFiled2}");

        }

        public Program DeepCopy() // 반환 타입이 Program인 것에 유의하기
        {
            Program newProgram = new Program
            {
                MyFiled1 = this.MyFiled1,
                MyFiled2 = this.MyFiled2
            };
            return newProgram;
        }
    }
}
