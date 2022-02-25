namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public int Total { get; }
    public string PriceDescription;

    public Bread(int quantity)
    {
      Quantity = quantity;
      Total = 0;
    }
  }
}
