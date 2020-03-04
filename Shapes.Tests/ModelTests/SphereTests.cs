using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {
    [TestMethod]
    public void SphereConstructor_CreateNewInstanceOfSphere_SphereType()
    {
      // arrange
      Sphere newSphere = new Sphere();
      // act
      Sphere result = newSphere;
      // assert
      Assert.AreEqual(typeof(Sphere), result.GetType());
    }
    [TestMethod]
    public void SphereConstructor_SphereHasRadiusFromCircle_SphereRadiusInt()
    {
      // arrange
      Circle newCircle = new Circle(5);
      Sphere newSphere = new Sphere(newCircle);
      // act
      int result = Sphere.Radius;
      // assert
      Assert.AreEqual(5, result);
    }
  }
}