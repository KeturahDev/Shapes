using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests 
  {
    [TestMethod]
    public void ConstructCircle_CreateNewInstanceOfCircle_CircleType()
    {
      // Arrange
      Circle newCircle = new Circle(2);
      // Act
      Circle result = newCircle;
      // Assert
      Assert.AreEqual(result.GetType(), typeof(Circle));
    }
    [TestMethod]
    public void ConstructCircle_CircleInstanceHoldsRadius_intRadius()
    {
      int radius = 3;
      Circle newCircle = new Circle(radius);

      int result = newCircle.Radius;

      Assert.AreEqual(result, radius);
    }

    [TestMethod]
    public void FindDiameter_ResturnDiameterOfCircle_DiameterInt()
    {
      // arrange
      int radius = 3;
      Circle newCircle = new Circle(radius);
      newCircle.SetDiameter();
      // act
      int result = newCircle.Diameter;
      // assert
      Assert.AreEqual(result, 6);
    }
    // [TestMethod]
    // public void FindCircumfrance_ResturnCircumferenceOfCircle_CircumfranceInt()
    // {
    //   // arrange
    //   int radius = 3;
    //   Circle newCircle = new Circle(radius);
    //   // act
    //   int result = newCircle.GetCircumference();
    //   // assert
    //   Assert.AreEqual(result, 6);
    // }
  }
}