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
      //Assert.AreEqual(false, testLeapYear.IsLeapYear(2011)); 
    }
    
  }
}