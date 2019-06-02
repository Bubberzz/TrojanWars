using System;
using TrojanWars.Enum;

namespace TrojanWars.Equipment
{
    internal class Weapon
    {
        private static readonly Random Sword = new Random();
        private static readonly Random Spear = new Random();
        public int Damage { get; }

        public Weapon(Allegiance allegiance)
        {
            switch (allegiance)
            {
                case Allegiance.Trojan:
                    Damage = Sword.Next(10, 50);
                    break;
                case Allegiance.Greek:
                    Damage = Spear.Next(10, 50);
                    break;
            }
        }
    }
}