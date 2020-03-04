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
    public int GetCircumference()
    {
      return 0;
    }
  }
}