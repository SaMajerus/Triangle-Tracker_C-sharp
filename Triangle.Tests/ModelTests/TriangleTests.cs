using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests {

    [TestMethod]
    public void IsTriangle_True(){
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(1, 2, 3));
    }

    [TestMethod]
    public void IsTriangle_IsEquilateral_True(){
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(5, 5, 5));
    }

    [TestMethod]
    public void IsTriangle_IsIsosceles_True(){
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(5, 3, 5));
    }

    [TestMethod]
    public void IsTriangle_IsScalene_True(){
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(5, 3, 7));
    }

    
  }
}