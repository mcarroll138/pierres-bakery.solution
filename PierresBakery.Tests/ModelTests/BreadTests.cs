using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculateBreadCost_ReturnsCorrectCostForSingleLoaf()
    {
      // Arrange
      int numberOfLoaves = 1;
      int expectedCost = 5;
      Bread bread = new Bread();

      // Act
      int actualCost = bread.CalculateBreadCost(numberOfLoaves);

      // Assert
      Assert.AreEqual(expectedCost, actualCost);
    }

    [TestMethod]
    public void CalculateBreadCostWithDeal_ReturnsCorrectCostForDeal()
    {
      // Arrange
      int numberOfLoaves = 3;
      int expectedCost = 10;
      Bread bread = new Bread();

      // Act
      int actualCost = bread.CalculateBreadCost(numberOfLoaves);
      // Assert
      Assert.AreEqual(expectedCost, actualCost);
    }
  }
}


