using System;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗    ████████╗ ██████╗ ");
      Console.WriteLine("██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝    ╚══██╔══╝██╔═══██╗");
      Console.WriteLine("██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗         ██║   ██║   ██║");
      Console.WriteLine("██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝         ██║   ██║   ██║");
      Console.WriteLine("╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗       ██║   ╚██████╔╝");
      Console.WriteLine(" ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝       ╚═╝    ╚═════╝ ");
      Console.WriteLine("██████╗ ██╗███████╗██████╗ ██████╗ ███████╗███████╗    ██████╗  █████╗ ██╗  ██╗███████╗██████╗ ██╗   ██╗");
      Console.WriteLine("██╔══██╗██║██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝    ██╔══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗╚██╗ ██╔╝");
      Console.WriteLine("██████╔╝██║█████╗  ██████╔╝██████╔╝█████╗  ███████╗    ██████╔╝███████║█████╔╝ █████╗  ██████╔╝ ╚████╔╝ ");
      Console.WriteLine("██╔═══╝ ██║██╔══╝  ██╔══██╗██╔══██╗██╔══╝  ╚════██║    ██╔══██╗██╔══██║██╔═██╗ ██╔══╝  ██╔══██╗  ╚██╔╝  ");
      Console.WriteLine("██║     ██║███████╗██║  ██║██║  ██║███████╗███████║    ██████╔╝██║  ██║██║  ██╗███████╗██║  ██║   ██║   ");
      Console.WriteLine("╚═╝     ╚═╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝    ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ");
      Console.WriteLine("Our specials today are as follows:");
      Console.WriteLine("Buy Two Loaves of Bread and Get the Third for FREE! (NO LIMIT)");
      Console.WriteLine("Buy Three Pastries and get the Fourth for FREE! (NO LIMIT)");
      Console.WriteLine("Cost for a single loaf of bread is $5.00");
      Console.WriteLine("Cost for a single pastry is $2.00");
      Console.WriteLine("If you are ready to place your order please type 'yes'");
      string OrderStart = Console.ReadLine();
      if (OrderStart.ToLower() == "yes")
        StartBreadOrder();
      else
      {
        Console.WriteLine("Come back when you are ready to order, we will be here all day!");
      }
    }

    static void StartBreadOrder()
    {
      Bread bread = new Bread();
      Console.WriteLine("How many loaves of bread would you like to order?");
      int numberOfLoaves = int.Parse(Console.ReadLine());
      int totalCost = bread.CalculateBreadCost(numberOfLoaves);
      if (numberOfLoaves == 0)
      {
        Console.WriteLine("Would you like to order pastries only?");
        string pastryResponse = Console.ReadLine();
        if (pastryResponse.ToLower() == "yes")
        {
          StartPastryOrder();
        }
        else
        {
          StartBreadOrder();
        }
      }
      else
      {
        Console.WriteLine($"Your total for {numberOfLoaves} loaves is ${totalCost}");
        Console.WriteLine("Would you like to order to start a pastry order?");
        string pastryResponseTwo = Console.ReadLine();
        if (pastryResponseTwo.ToLower() == "yes")
        {
          StartPastryOrder();
        }
        else
        {
          Console.WriteLine("Thank you for your order, we will see you soon!");
        }
      }

    }

    static void StartPastryOrder()
    {
      Pastry pastry = new Pastry();
      Console.WriteLine("How many pastries would you like to order?");
      int numberOfPastries = int.Parse(Console.ReadLine());
      int totalCost = pastry.CalculatePastryCost(numberOfPastries);
      Console.WriteLine($"Your total for {numberOfPastries} pastries is ${totalCost}");
    }

  }
}

