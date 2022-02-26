using System;
using System.Threading;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine(Dialogue.Banner);
      Console.ReadKey();
      Console.WriteLine(Dialogue.Intro);
      MainNavigation();
    }

    public static void MainNavigation()
    {
      Console.WriteLine(Dialogue.NavPrompt);
      string response = (Console.ReadLine()).ToLower();
      Console.WriteLine();
      if (response == "about")
      {
        ShowAbout();
      }
      else if (response == "bread")
      {
        OrderBread();
      }
      else if (response == "pastry")
      {
        OrderPastry();
      }
      else if (response == "order")
      {
        ShowOrder();
      }
      else if (response == "restart")
      {
        Restart();
      }
      else if (response == "checkout")
      {
        Checkout();
      }
      else
      {
        Error();
      }
    }

    public static void ShowAbout()
    {
      Console.WriteLine();
      Console.WriteLine(Dialogue.About);
      Console.ReadKey();
      Program.MainNavigation();
    }

    public static void OrderBread()
    {
      Console.WriteLine(Dialogue.BreadPrompt);
      int breadInput = 0;
      try 
      {
        breadInput = Int32.Parse(Console.ReadLine());
      }
      catch
      {
        Error();
      }
      
      Console.WriteLine();
      
      if (breadInput == 0)
      {
        Console.WriteLine("Thank you.");
      }
      else
      {
        Basket.userBread.Quantity = breadInput;
        Basket.userBread.UpdateTotal();
        Console.WriteLine("Thank you. You have ordered " + Basket.userBread.Quantity + " loaf/loaves of bread, and your order total is now $" + (Basket.userBread.Total + Basket.userPastry.Total));
      }
      Console.WriteLine("Press ENTER to return to navigation menu.");
      Console.ReadKey();
      Program.MainNavigation();
    }

    public static void OrderPastry()
    {
      Console.WriteLine(Dialogue.PastriesPrompt);
      int pastryInput = 0;
      try
      {
      pastryInput = Int32.Parse(Console.ReadLine());
      }
      catch
      {
        Error();
      }
      Console.WriteLine();
      if (pastryInput == 0)
      {
        Console.WriteLine("Thank you.");
      }
      else
      {
        Basket.userPastry.Quantity = pastryInput;
        Basket.userPastry.UpdateTotal();
        Console.WriteLine("Thank you. You have ordered " + Basket.userPastry.Quantity + " pastry/pastries, and your order total is now $" + (Basket.userBread.Total + Basket.userPastry.Total));
      }
      Console.WriteLine("Press ENTER to return to navigation menu.");
      Console.ReadKey();
      Program.MainNavigation();
    }

    public static void Checkout()
    {
      Console.WriteLine("Your grand order total is $" + (Basket.userBread.Total + Basket.userPastry.Total) + ". Press ENTER to pay.");
      Console.ReadKey();
      Console.WriteLine();
      Console.WriteLine("Your payment has been accepted. Thank you for shopping with us.");
      Console.WriteLine(Dialogue.Outtro);
      Thread.Sleep(10000);
      Console.WriteLine(Dialogue.Grafix);
      Environment.Exit(0);
    }

    public static void ShowOrder()
    {
      Console.WriteLine();
      Console.WriteLine("Your current order is " + Basket.userBread.Quantity + " loaf/loaves of bread and " + Basket.userPastry.Quantity + " pastry/pastries. That's a grand order total of $" + (Basket.userBread.Total + Basket.userPastry.Total) + " . Enter 'checkout' to pay, or press ENTER to go to the navigation menu.");
      string response = (Console.ReadLine()).ToLower();
      Console.WriteLine();
      if (response == "checkout")
      {
        Checkout();
      }
      else
      {
        MainNavigation();
      }
    }
    public static void Error()
    {
      Console.WriteLine(Dialogue.Error);
      Console.ReadKey();
      Console.WriteLine();
      Program.MainNavigation();
    }

    public static void Restart()
    {
      Basket.userBread.Quantity = 0;
      Basket.userPastry.Quantity = 0;
      Basket.userBread.UpdateTotal();
      Basket.userPastry.UpdateTotal();
      Console.WriteLine(Dialogue.Success);
      Thread.Sleep(3000);
      Program.MainNavigation();

    }
  }
}
