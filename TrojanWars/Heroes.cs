using System.Diagnostics;
using TrojanWars.Enum;
using TrojanWars.Equipment;
namespace TrojanWars
{
    class Heroes
    {
        private int trojanStartingHealth;
        private int greekStartingHealth;

        private Allegiance allegiance;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get { return isAlive; }
        }

        private Weapon weapon;
        private Armour armour;

        public Heroes(string name, Allegiance allegiance)
        {
            this.name = name;
            this.allegiance = allegiance;
            isAlive = true;

            switch (allegiance)
            {
                case Allegiance.Trojan:
                    weapon = new Weapon(allegiance);
                    armour = new Armour(allegiance);
                    health = trojanStartingHealth;
                    break;
                case Allegiance.Greek:
                    weapon = new Weapon(allegiance);
                    armour = new Armour(allegiance);
                    health = greekStartingHealth;
                    break;
                default:
                    break;
            }
        }
    }
}
