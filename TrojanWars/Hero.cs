using System;
using System.Diagnostics;
using System.Threading;
using TrojanWars.Enum;
using TrojanWars.Equipment;
namespace TrojanWars
{
    class Hero
    {
        private const int TROJAN_STARTING_HEALTH = 10;
        private const int GREEK_STARTING_HEALTH = 10;

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

            AttackResult(enemyHero, damage);

            Thread.Sleep(100);
            
        }

        private void AttackResult(Hero enemyHero, int damage)
        {
            if (enemyHero.health <= 0)
            {
                enemyHero.isAlive = false;
                Tools.ColourOfWriteLine($"{enemyHero.name} is dead.", ConsoleColor.Red);
                Tools.ColourOfWriteLine($"{name} is victorious!", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine(
                    $"{name} attacked {enemyHero.name}. {damage} damage was inflicted to {enemyHero.name}, remaining health of {enemyHero.name} is {enemyHero.health}.");
            }
        }
    }
}
