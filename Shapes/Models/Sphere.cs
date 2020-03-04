using System;
namespace Shapes.Models
{
  public class Sphere
  {
    public int Radius {get;}

    public Sphere(Circle circle)
    {
      Radius = circle.Radius;
    }
    public double GetSurfaceArea()
    {
      int radiusSquared = Radius * Radius;
      // Console.WriteLine($"rSquared:{radiusSquared}");
      int times4 = radiusSquared * 4;
      // Console.WriteLine($"times4:{times4}");
      double surfaceArea = times4 * 3.14;
      // Console.WriteLine($"SA:{surfaceArea}");
      return surfaceArea;
    }
    public double FindVolume()
    {
      int radiusCubed = Radius * Radius * Radius;
      // double times4Over3 = radiusCubed * 1.33;
      int times4 = radiusCubed * 4;
      double timespi = times4 * 3.1415;
      double dividedBy3 = timespi / 3;
      double volume = Math.Round(dividedBy3, 1);
      return volume;
    }
  }
}