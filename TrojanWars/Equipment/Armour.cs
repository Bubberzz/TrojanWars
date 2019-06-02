using TrojanWars.Enum;

namespace TrojanWars.Equipment
{
    internal class Armour
    {
        private const int TROJAN_ARMOUR = 5;
        private const int GREEK_ARMOUR = 5;
        public int ArmourPoints { get; }

        public Armour(Allegiance allegiance)
        {
            switch (allegiance)
            {
                case Allegiance.Trojan:
                    ArmourPoints = TROJAN_ARMOUR;
                    break;
                case Allegiance.Greek:
                    ArmourPoints = GREEK_ARMOUR;
                    break;
            }
        }
    }
}
