using TrojanWars.Enum;

namespace TrojanWars.Equipment
{
    class Weapon
    {
        private const int TROJAN_WEAPON_DAMAGE = 5;
        private const int GREEK_WEAPON_DAMAGE = 5;
        private int damage;

        public int Damage => damage;

        public Weapon(Allegiance allegiance)
        {
            switch (allegiance)
            {
                case Allegiance.Trojan:
                    damage = TROJAN_WEAPON_DAMAGE;
                    break;
                case Allegiance.Greek:
                    damage = GREEK_WEAPON_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}