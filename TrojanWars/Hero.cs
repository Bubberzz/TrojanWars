using System;
using System.Threading;
using TrojanWars.Enum;
using TrojanWars.Equipment;
namespace TrojanWars
{
    internal class Hero
    {
        private const int TROJAN_STARTING_HEALTH = 100;
        private const int GREEK_STARTING_HEALTH = 100;
        private int _health;
        private readonly string _name;
        public bool IsAlive { get; private set; }
        private readonly Weapon _weapon;
        private readonly Armour _armour;
        private static readonly Random DamagePoints = new Random();

        public Hero(string name, Allegiance allegiance)
        {
            this._name = name;
            IsAlive = true;

            switch (allegiance)
            {
                case Allegiance.Trojan:
                    _weapon = new Weapon(allegiance);
                    _armour = new Armour(allegiance);
                    _health = TROJAN_STARTING_HEALTH;
                    break;
                case Allegiance.Greek:
                    _weapon = new Weapon(allegiance);
                    _armour = new Armour(allegiance);
                    _health = GREEK_STARTING_HEALTH;
                    break;
            }
        }

        public void Attack(Hero enemyHero)
        {
            var damage = DamagePoints.Next(0, _weapon.Damage) / DamagePoints.Next(1, enemyHero._armour.ArmourPoints);
            enemyHero._health -= damage;
            AttackResult(enemyHero, damage);
            Thread.Sleep(200);
        }

        private void AttackResult(Hero enemyHero, int damage)
        {
            if (enemyHero._health <= 0)
            {
                enemyHero.IsAlive = false;
                Console.WriteLine(
                    $"{_name} attacked {enemyHero._name}. {damage} damage was inflicted to {enemyHero._name}, remaining health of {enemyHero._name} is 0.");
                Tools.ColourOfWriteLine($"{enemyHero._name} is dead.", ConsoleColor.Red);
                Tools.ColourOfWriteLine($"{_name} is victorious!", ConsoleColor.Green);
                Console.Read();
            }
            else
            {
                Console.WriteLine(
                    $"{_name} attacked {enemyHero._name}. {damage} damage was inflicted to {enemyHero._name}, remaining health of {enemyHero._name} is {enemyHero._health}.");
            }
        }
    }
}
