using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrojanWars.Enum;

namespace TrojanWars
{
    class Program
    {
        static Random rng = new Random();
        static void Main()
        {
            Hero Achilles = new Hero("Achilles", Allegiance.Greek);
            Hero Hector = new Hero("Hector", Allegiance.Trojan);

            while (Achilles.IsAlive && Hector.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
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
