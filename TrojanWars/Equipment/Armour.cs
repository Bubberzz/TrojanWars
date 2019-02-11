using TrojanWars.Enum;

namespace TrojanWars.Equipment
{
    class Armour
    {
        private int trojanArmour;
        private int greekArmour;

        private int armourPoints;

        public int ArmourPoints => armourPoints;

        public Armour(Allegiance allegiance)
        {
            switch (allegiance)
            {
                case Allegiance.Trojan:
                    armourPoints = trojanArmour;
                    break;
                case Allegiance.Greek:
                    armourPoints = greekArmour;
                    break;
                default:
                    break;
            }
        }
    }
}
