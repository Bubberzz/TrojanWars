using System;
using TrojanWars.Enum;

namespace TrojanWars
{
    internal class Program
    {
        static readonly Random Initiative = new Random();
        static void Main()
        {
            var Achilles = new Hero("Achilles", Allegiance.Greek);
            var Hector = new Hero("Hector", Allegiance.Trojan);

            while (Achilles.IsAlive && Hector.IsAlive)
            {
                if (Initiative.Next(0, 8) < 4)
                {
                    Achilles.Attack(Hector);
                }
                else
                {
                    Hector.Attack(Achilles);
                }
            }
        }
    }
}
