using System;

namespace GalacticGPS
{
    public class GalacticGPS
    {
        static void Main()
        {
            Location sofia = new Location(42.7, 23.33, Planet.Earth);
            Console.WriteLine(sofia);
        }
    }
}