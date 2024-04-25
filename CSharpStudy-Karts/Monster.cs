using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy_Karts
{
    internal class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }

        public Monster(string name, int health, int attack, int defense, int speed, int level)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            Level = level;
        }

        public void AttackMonster(Monster target)
        {
            int damage = Attack - target.Defense;
            if (damage < 0)
            {
                damage = 0;
            }
            target.Health -= damage;
        }

        public void PrintMonster()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Attack: " + Attack);
            Console.WriteLine("Defense: " + Defense);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Level: " + Level);
        }   
    }
}
