using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalculatePastryCost_ReturnsCorrectCostForSinglePastry()
    {
      // Arrange
      int numberOfPastries = 1;
      int expectedCost = 2;
      Pastry pastry = new Pastry();

      // Act
      int actualCost = pastry.CalculatePastryCost(numberOfPastries);

      // Assert
      Assert.AreEqual(expectedCost, actualCost);
    }
    [TestMethod]
    public void CalculatePastryCpstWithDeal_ReturnsCorrectCostForDeal()
    {
      // Arrange
      int numberOfPastries = 5;
      int expectedCost = 8;
      Pastry pastry = new Pastry();

      // Act
      int actualCost = pastry.CalculatePastryCost(numberOfPastries);
      // Assert
      Assert.AreEqual(expectedCost, actualCost);
    }
  }
}