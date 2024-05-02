using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1.ClassExercise
{
    internal class Assistant : Person
    {
        public Assistant(int age, string name) : base(age, name)
        {
        }
        
        public void GotCallFromCongressMan()
        {
            Console.WriteLine("네, 전화 받았습니다. 의원님!");
        }
    }
}
