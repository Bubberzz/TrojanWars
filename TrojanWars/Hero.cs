using System;
using System.Diagnostics;
using TrojanWars.Enum;
using TrojanWars.Equipment;
namespace TrojanWars
{
    class Hero
    {
        private const int TROJAN_STARTING_HEALTH = 100;
        private const int GREEK_STARTING_HEALTH = 100;

        private readonly Allegiance ALLEGIANCE;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get { return isAlive; }
        }

        private Weapon weapon;
        private Armour armour;

        public Hero(string name, Allegiance allegiance)
        {
            this.name = name;
            ALLEGIANCE = allegiance;
            isAlive = true;

            switch (allegiance)
            {
                case Allegiance.Trojan:
                    weapon = new Weapon(allegiance);
                    armour = new Armour(allegiance);
                    health = TROJAN_STARTING_HEALTH;
                    break;
                case Allegiance.Greek:
                    weapon = new Weapon(allegiance);
                    armour = new Armour(allegiance);
                    health = GREEK_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Hero enemyHero)
        {
            int damage = weapon.Damage / enemyHero.armour.ArmourPoints;
            enemyHero.health = enemyHero.health - damage;

            if (enemyHero.health <= 0)
            {
                enemyHero.isAlive = false;
                Console.WriteLine($"{enemyHero.name} is dead. {name} is victorious!");
                Console.ReadLine();
            }

            
        }
    }
}
