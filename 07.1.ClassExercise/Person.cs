using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1.ClassExercise
{
    internal class Person
    {
        private int Age { get; set; }
        private string Name { get; set; }

        public Person(int age, string name) // 생성자 초기화
        {
            this.Age = age;
            this.Name = name;
        }

        public void Eat()
        {
            Console.WriteLine("I am eating");
        }

        public void Writing()
        {
            Console.WriteLine("I am writing");
        }

        public void Walking()
        {
            Console.WriteLine("I am walking");
        }
    }
}
