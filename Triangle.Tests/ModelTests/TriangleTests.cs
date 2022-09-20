using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests {

    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True(){
      Triangle testLeapYear = new Triangle();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
      //Assert.AreEqual(false, testLeapYear.IsLeapYear(2011)); 
    }
    
  }
}