using System;
using System.Threading;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine(Welcome.Banner);
      Console.ReadKey();
      Console.WriteLine(Welcome.Intro);
      int breadInput = Int32.Parse(Console.ReadLine());
      Bread userBread = new Bread(breadInput);

      if (breadInput == 0)
      {
        Console.WriteLine();
        Console.WriteLine("Thank you.");
      }
      else
      {
        Console.WriteLine();
        Console.WriteLine("Thank you. You have ordered " + userBread.Quantity + " loaf/loaves of bread, and your order total is now $" + userBread.Total);
      }

      Console.WriteLine(Welcome.PastriesText);
      int pastryInput = Int32.Parse(Console.ReadLine());
      Pastry userPastry = new Pastry(pastryInput);

      if (pastryInput == 0 && breadInput == 0)
      {
        Console.WriteLine();
        Console.WriteLine("OK, then. Thanks for stopping in, and maybe you'll try something another time.");
        Console.WriteLine(Welcome.Outtro);
        Thread.Sleep(5000);
        Console.WriteLine(Welcome.Grafix);
      }
      else if (pastryInput == 0)
      {
        Console.WriteLine();
        Console.WriteLine("Alrighty then. Your order stands at " + userBread.Quantity + " loaf/loaves of bread, and a grand order total of $" + userBread.Total + " Press ENTER to pay.");
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("Your payment has been accepted. Thank you for shopping with us.");
        Console.WriteLine(Welcome.Outtro);
        Thread.Sleep(5000);
        Console.WriteLine(Welcome.Grafix);
      }
      else
      {
        Console.WriteLine();
        Console.WriteLine("Great. Your order is now " + userPastry.Quantity + " pastry/pastries and " + userBread.Quantity + " loaf/loaves of bread. You now have a grand order total of $" + (userBread.Total + userPastry.Total) + ". Press ENTER to pay.");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Your payment has been accepted. Thank you for shopping with us.");
        Console.WriteLine(Welcome.Outtro);
        Thread.Sleep(10000);
        Console.WriteLine(Welcome.Grafix);
      }


    }
  }
}
