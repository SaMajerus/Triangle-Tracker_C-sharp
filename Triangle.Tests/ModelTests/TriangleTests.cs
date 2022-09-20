using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests {

    [TestMethod]
    public void IsTriangle_LengthFiveEquilateral_True(){
      Triangle testLeapYear = new Triangle();
      Assert.AreEqual(true, testLeapYear.IsTriangle(5, 5, 5));
      //Assert.AreEqual(false, testLeapYear.IsLeapYear(2011)); 
    }
    
  }
}