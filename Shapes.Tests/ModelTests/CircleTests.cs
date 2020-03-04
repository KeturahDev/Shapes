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
      Circle newCircle = new Circle();
      // Act
      Circle result = newCircle;
      // Assert
      Assert.AreEqual(result.GetType(), typeof(Circle));
    }
    // [TestMethod]
    // public void ConstructCircle_CircleInstanceHoldsRadius_intRadius()
    // {
    //   int radius = 3;
    //   Circle newCircle = new Circle(radius);

    //   int result = newCircle.Radius;

    //   Assert.AreEqual(result, radius);
    // }
    // [TestMethod]
    // public void FindCircumfrance_ResturnCircomfranceOfCircle_CircumfranceInt()
    // {
    //   int radius = 3;
    //   Circle newCircle = new Circle(radius);
    // }
  }
}