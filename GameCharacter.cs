using System;
using System.Collections.Generic;
using System.Text;

namespace BonusLab13
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public virtual void Play()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");

        }
    }
}
