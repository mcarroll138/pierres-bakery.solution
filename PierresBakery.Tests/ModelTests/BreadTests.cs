using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{

  [TestMethod]
  public void CalculateTotalCost_ReturnCorrectTotalCost()
  {
    //Arrange
    int numberOfLoaves = 1;
    int expectedCost = 5;
    Bread bread = new Bread();

    //Act
    int actualCost = bread.CalculateBreadCost(numberOfLoaves);

    //Assert
    Assert.AreEqual(expectedCost, actualCost);
  }
}
