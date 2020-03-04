namespace Shapes.Models
{
  public class Sphere
  {
    public int Radius {get;}

    public Sphere(Circle circle)
    {
      Radius = circle.Radius;
    }
  }
}