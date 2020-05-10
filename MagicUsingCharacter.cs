using System;
using System.Collections.Generic;
using System.Text;

namespace BonusLab13
{
    public class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public override void Play()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
