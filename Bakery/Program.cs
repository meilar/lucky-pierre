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

      Console.WriteLine(Dialogue.PastriesText);
      int pastryInput = Int32.Parse(Console.ReadLine());
      Pastry userPastry = new Pastry(pastryInput);

      if (pastryInput == 0 && breadInput == 0)
      {
        Console.WriteLine();
        Console.WriteLine("OK, then. Thanks for stopping in, and maybe you'll try something another time.");
        Console.WriteLine(Dialogue.Outtro);
        Thread.Sleep(5000);
        Console.WriteLine(Dialogue.Grafix);
      }
      else if (pastryInput == 0)
      {
        Console.WriteLine();
        Console.WriteLine("Alrighty then. Your order stands at " + userBread.Quantity + " loaf/loaves of bread, and a grand order total of $" + userBread.Total + " Press ENTER to pay.");
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("Your payment has been accepted. Thank you for shopping with us.");
        Console.WriteLine(Dialogue.Outtro);
        Thread.Sleep(5000);
        Console.WriteLine(Dialogue.Grafix);
      }
      else
      {
        Console.WriteLine();
        Console.WriteLine("Great. Your order is now " + userPastry.Quantity + " pastry/pastries and " + userBread.Quantity + " loaf/loaves of bread. You now have a grand order total of $" + (userBread.Total + userPastry.Total) + ". Press ENTER to pay.");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Your payment has been accepted. Thank you for shopping with us.");
        Console.WriteLine(Dialogue.Outtro);
        Thread.Sleep(10000);
        Console.WriteLine(Dialogue.Grafix);
      }


    }

    public static void MainNavigation()
    {
      Console.WriteLine(Dialogue.NavPrompt);
      string response = Console.ReadLine();
      Console.WriteLine();
      if (response == "about")
      {
        ShowAbout();
      }
      else
      {
        Console.WriteLine();
        Console.WriteLine("I'm afraid I don't understand you. Let's try again. Press ENTER to return to the navigation menu.");
        Console.ReadKey();
        Console.WriteLine();
        Program.MainNavigation();
      }

    }

    public static void ShowAbout()
    {
      Console.WriteLine();
      Console.WriteLine(Dialogue.About);
      Console.ReadKey();
      Program.MainNavigation();
    }
  }
}
