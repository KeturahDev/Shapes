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
  }
}