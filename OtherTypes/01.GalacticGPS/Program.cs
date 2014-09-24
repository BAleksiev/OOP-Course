public struct Location
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public Planet Planet { get; set; }

    public Location(double latitude, double longitude, Planet planet)
    {
        this.Longitude = longitude;
        this.Latitude = latitude;
        this.Planet = planet;
    }

    public override string ToString()
    {
        return this.Latitude + ", " + this.Longitude + ", " + this.Planet;
    }
}

public class TestLocations
{
    static void Main()
    {
        Location sofia = new Location(42.7, 23.33, Planet.Earth);
        Console.WriteLine(sofia.ToString());
    }
}