using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadOrderContructor_MakeABreadOrder_BreadOrder()
    {

      BreadOrder testBreadOrder = new BreadOrder(2, 3);
      Assert.AreEqual(typeof(BreadOrder), testBreadOrder.GetType());
    }
  }
}