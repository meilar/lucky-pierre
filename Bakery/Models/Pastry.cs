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
      Total = 0;
    }
  }
}