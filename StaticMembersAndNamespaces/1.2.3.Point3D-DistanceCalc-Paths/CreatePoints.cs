using System;

namespace Point3D
{
    class CreatePoints
    {
        static void Main()
        {
            Point3D point1 = new Point3D(-7, -4, 3);
            Point3D point2 = new Point3D(17, 6, 2.5);

            // Display Points
            Console.WriteLine("Starting point: " + Point3D.StartingPoint);
            Console.WriteLine("Point3D 1: " + point1);
            Console.WriteLine("Point3D 1: " + point2);


            // Display Distance Between Points
            double distance = DistanceCalculator.CalculateDistance(point1, point2);

            Console.WriteLine();
            Console.WriteLine("Distance: " + distance);
            Console.WriteLine();


            // Display Path
            Path3D path = new Path3D(point1, point2);
            path.AddPoint(new Point3D(4, 6.4, 11.1));

            // if 3th value is true, the path will be appended to old file data, else the file will be overwritten
            Storage.SavePath("paths.txt", path, false);
            Console.WriteLine("Path: " + path);

            string storageData = Storage.LoadPath("paths.txt");
            Console.WriteLine("\nPath from Storage:\n" + storageData);
        }
    }
}