using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Constructor_InitializesObject_IsPastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void Constructor_RunsPricingLogic_OrderTotal()
    {
      Pastry pastry1 = new Pastry(1);
      Assert.AreEqual(pastry1.Total, 2);
      Pastry pastry2 = new Pastry(2);
      Assert.AreEqual(pastry2.Total, 4);
      Pastry pastry3 = new Pastry(3);
      Assert.AreEqual(pastry3.Total, 5);
      Pastry pastry7 = new Pastry(7);
      Assert.AreEqual(pastry7.Total, 12);
    }

    [TestMethod]
    public void UpdateTotal_UpdatesPriceAfterInitialization_NewOrderTotal()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(newPastry.Total, 2);
      newPastry.Quantity = 7;
      newPastry.UpdateTotal();
      Assert.AreEqual(newPastry.Total, 12);
    }
  }
}