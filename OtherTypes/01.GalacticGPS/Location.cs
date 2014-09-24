using System;

namespace GalacticGPS
{
    public struct Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Planet Planet { get; set; }

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return this.Latitude + ", " + this.Longitude + " - " + this.Planet;
        }
    }
}
