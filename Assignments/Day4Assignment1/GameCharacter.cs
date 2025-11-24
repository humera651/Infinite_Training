using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment1
{
    internal class GameCharacter
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public List<string> Skills { get; set; }

        public object Clone()
        {
            return new GameCharacter
            {
                Health = this.Health,
                Attack = this.Attack,
                Defense = this.Defense,
                Skills = new List<string>(this.Skills)
            };
        }

        public void Display()
        {
            Console.WriteLine($"Health: {Health}, Attack: {Attack}, Defense: {Defense}");
            Console.WriteLine("Skills: " + string.Join(", ",Skills));
        }
    }
}
