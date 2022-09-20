using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests {

    [TestMethod]
    public void IsNotATriangle_False(){
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Not a triangle", testTriangle.Classify(1, 2, 4));
    }

    [TestMethod]
    public void IsTriangle_IsEquilateral_True(){
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Equilateral", testTriangle.Classify(5, 5, 5));
    }

    [TestMethod]
    public void IsTriangle_IsIsosceles_True(){
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Isosceles", testTriangle.Classify(5, 3, 5));
    }

    [TestMethod]
    public void IsTriangle_IsScalene_True(){
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Scalene", testTriangle.Classify(5, 3, 7));
    }
    
  }
}