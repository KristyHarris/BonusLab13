using System;
using System.Collections.Generic;
using System.Text;

namespace BonusLab13
{
    class Program
    {
        static void Main(string[] args)

        {
            var warrior1 = new Warrior();
            warrior1.Name = "Thor";
            warrior1.Strength = 100;
            warrior1.Intelligence = 50;
            warrior1.WeaponType = "Hammer";

            var warrior2 = new Warrior();
            warrior2.Name = "Arthur";
            warrior2.Strength = 85;
            warrior2.Intelligence = 90;
            warrior2.WeaponType = "Sword";

            var wizard1 = new Wizard();
            wizard1.Name = "Joe";
            wizard1.Strength = 90;
            wizard1.Intelligence = 50;
            wizard1.MagicalEnergy = 70;
            wizard1.SpellNumber = 13;

            var wizard2 = new Wizard();
            wizard2.Name = "Bob";
            wizard2.Strength = 81;
            wizard2.Intelligence = 71;
            wizard2.MagicalEnergy = 61;
            wizard2.SpellNumber = 23;

            var wizard3 = new Wizard();
            wizard3.Name = "Steve";
            wizard3.Strength = 72;
            wizard3.Intelligence = 92;
            wizard3.MagicalEnergy = 82;
            wizard3.SpellNumber = 33;

    
            GameCharacter[] gameCharacters = { warrior1, warrior2, wizard1, wizard2, wizard3 };
            for (var i = 0; i < gameCharacters.Length; i++)
            {
                
                gameCharacters[i].Play();

            }

        }
    }
}
