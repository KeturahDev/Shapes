using System;
namespace Shapes.Models
{
  public class Circle
  {
    public int Radius {get;}
    public int Diameter {get; set;}
    public Circle(int radius)
    {
      Radius = radius;
      Diameter = 0;
    }
    public void SetDiameter()
    {
      Diameter = Radius * 2;
    }
    public double GetCircumference()
    {
      // Console.WriteLine(Diameter);
      double Circumference = Diameter * 3.14;
      return Circumference;
    }
  }
}