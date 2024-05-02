using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1.ClassExercise
{
    internal class Clerk : Person
    {
        public Clerk(int age, string name) : base(age, name)
        {
        }

        public void WriteDocument()
        {
            Console.WriteLine("네, 지금 바로 작성하겠습니다");
        }

    }
}
