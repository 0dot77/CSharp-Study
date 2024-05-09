namespace _07._013_ReadonlyFields
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            max = v2;
        }

        public void ChangeMax(int newMax)
        {
            // 생성자가 아닌 다른 곳에서 값을 수정하려고 하면 에러가 난다.
            //max = newMax;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Configuration c = new Configuration(0, 100);
        }
    }
}
