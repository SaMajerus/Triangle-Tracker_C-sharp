using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TrackerTests {

    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True(){
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
      //Assert.AreEqual(false, testLeapYear.IsLeapYear(2011)); 
    }
    
    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFour_False(){
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    }

    [TestMethod]
    public void IsLeapYear_MultiplesOfOneHundred_False(){
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }

    [TestMethod]
    public void IsLeapYear_MultiplesOfFourHundred_True(){
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }

  }
}