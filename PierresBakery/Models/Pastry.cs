using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    //     private static int _fullPricePastry = 2;
    //     public int CalculatePastryCost(int numberOfPastries)
    //     {
    //       int fullPricePastries = 0;
    //       for (int i = 1; i <= numberOfPastries; i++)
    //       {
    //         if (i % 4 != 0)
    //         {
    //           fullPricePastries++;
    //         }
    //       }
    //       int totalCost = fullPricePastries * _fullPricePastry;
    //       return totalCost;
    //     }
    //   }
    // }



    private static int _fullPricePastry = 2;
    private int _numberOfPastries;
    public int NumberOfPastries
    {
      get { return _numberOfPastries; }
      set { _numberOfPastries = value; }
    }
    public int TotalCost = 0;

    public int CalculatePastryCost(int numberOfPastries)
    {
      int fullPricePastries = 0;

      for (int i = 1; i <= numberOfPastries; i++)
      {
        if (i % 3 != 0)
        {
          fullPricePastries++;
        }
      }

      int totalCost = fullPricePastries * _fullPricePastry;
      return totalCost;
    }
  }
}