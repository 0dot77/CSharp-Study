using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1.ClassExercise
{
    internal class CongressMan : Person
    {
        public CongressMan(int age, string name) : base(age, name) 
        {
        }

        public void MakeLaw()
        {
            Console.WriteLine("엣헴, 법을 만들어볼까?!");
        }

        public void MakePromise()
        {
            Console.WriteLine("약속을 지킬까 말까");
        }

        public void Shouting()
        {
            Console.WriteLine("어디어디어디 국회의원한테!");
        }
    }
}
