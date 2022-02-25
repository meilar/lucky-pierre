using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Constructor_InitializesObject_IsBread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Constructor_RunsPricingLogic_OrderTotal()
    {
      Bread bread1 = new Bread(1);
      Assert.AreEqual(bread1.Total, 5);
      Bread bread2 = new Bread(2);
      Assert.AreEqual(bread2.Total, 10);
      Bread bread3 = new Bread(3);
      Assert.AreEqual(bread3.Total, 10);
      Bread bread4 = new Bread(7);
      Assert.AreEqual(bread4.Total, 25);
    }

    [TestMethod]
    public void UpdateTotal_UpdatesPriceAfterInitialization_NewOrderTotal()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(newBread.Total, 5);
      newBread.Quantity = 7;
      newBread.UpdateTotal();
      Assert.AreEqual(newBread.Total, 25);
    }
  }
}