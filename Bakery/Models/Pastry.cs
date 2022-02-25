namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int Total { get; }
    public string PriceDescription;

    public Pastry(int quantity)
    {
      Quantity = quantity;
      Total = this.UpdateTotal(quantity);
      
    }

    private int UpdateTotal(int quanitity)
    {
      int total = 0;
      int discountedQuantity = quanitity/3;
      int fullPriceQuantity = quanitity%3;
      total = (discountedQuantity*5) + (fullPriceQuantity*2);
      return total;
    }
  }
}