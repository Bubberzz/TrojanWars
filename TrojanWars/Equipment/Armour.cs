using TrojanWars.Enum;

namespace TrojanWars.Equipment
{
    class Armour
    {
        private const int TROJAN_ARMOUR = 5;
        private const int GREEK_ARMOUR = 5;

        private int armourPoints;

        public int ArmourPoints => armourPoints;

        public Armour(Allegiance allegiance)
        {
            switch (allegiance)
            {
                case Allegiance.Trojan:
                    armourPoints = TROJAN_ARMOUR;
                    break;
                case Allegiance.Greek:
                    armourPoints = GREEK_ARMOUR;
                    break;
                default:
                    break;
            }
        }
    }
}
