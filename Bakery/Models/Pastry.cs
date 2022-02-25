namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int Total { get; set; }
    public string PriceDescription;

    public Pastry(int quantity)
    {
      Quantity = quantity;
      this.UpdateTotal();
      
    }

    public void UpdateTotal()
    {
      int quantity = this.Quantity;
      int discountedQuantity = quantity/3;
      int fullPriceQuantity = quantity%3;
      this.Total = (discountedQuantity*5) + (fullPriceQuantity*2);
    }
  }
}