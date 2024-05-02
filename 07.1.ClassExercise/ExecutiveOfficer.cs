using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1.ClassExercise
{
    internal class ExecutiveOfficer : Person
    {
        public ExecutiveOfficer(int age, string name) : base(age, name)
        {
        }

        public void MakeDecision()
        {
            Console.WriteLine("네, 담구겠습니다.");
        }
    }
}
