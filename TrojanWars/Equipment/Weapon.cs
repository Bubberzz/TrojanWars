using TrojanWars.Enum;

namespace TrojanWars.Equipment
{
    class Weapon
    {
        private int trojanDamage;
        private int greekDaamage;
        private int damage;

        public int Damage => damage;

        public Weapon(Allegiance allegiance)
        {
            switch (allegiance)
            {
                case Allegiance.Trojan:
                    damage = trojanDamage;
                    break;
                case Allegiance.Greek:
                    damage = greekDaamage;
                    break;
                default:
                    break;
            }
        }
    }
}