using System;
using System.Collections.Generic;
using System.Text;

namespace BonusLab13
{
    public class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public override void Play()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Weapon: {WeaponType}\n");
        }
    }
}

