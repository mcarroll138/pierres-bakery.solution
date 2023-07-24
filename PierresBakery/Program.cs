using System;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery
{
  class Program
  {
    private static int numberOfLoaves;
    private static int breadTotalCost;
    private static int numberOfPastries;
    private static int pastryTotalCost;
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
      numberOfLoaves = int.Parse(Console.ReadLine());
      breadTotalCost = bread.CalculateBreadCost(numberOfLoaves);
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
        Console.WriteLine($"Your total for {numberOfLoaves} loaves is ${breadTotalCost}");
        Console.WriteLine("Would you like to order to start a pastry order?");
        string pastryResponseTwo = Console.ReadLine();
        if (pastryResponseTwo.ToLower() == "yes")
        {
          StartPastryOrder();
        }
        else
        {
          Console.WriteLine("Thank you for your order, we will see you soon!");
          GrandTotal();
        }
      }

    }

    static void StartPastryOrder()
    {
      Pastry pastry = new Pastry();
      Console.WriteLine("How many pastries would you like to order?");
      numberOfPastries = int.Parse(Console.ReadLine());
      pastryTotalCost = pastry.CalculatePastryCost(numberOfPastries);
      Console.WriteLine($"Your total for {numberOfPastries} pastries is ${pastryTotalCost}");
      GrandTotal();
    }
    static void GrandTotal()
    {
      if (numberOfLoaves >= 1 && numberOfPastries >= 1)
      {
        int grandTotal = breadTotalCost + pastryTotalCost;
        Console.WriteLine($"Your grand total for {numberOfLoaves} loaves and {numberOfPastries} pastries is ${grandTotal}");
      }
    }
  }
}
