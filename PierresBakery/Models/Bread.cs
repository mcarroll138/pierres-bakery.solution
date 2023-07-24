using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    private static int _fullLoafPrice = 5;
    private int _numberOfLoaves;
    public int NumberOfLoaves
    {
      get { return _numberOfLoaves; }
      set { _numberOfLoaves = value; }
    }
    public int TotalCost { get; set; }

    public int CalculateBreadCost(int numberOfLoaves)
    {
      int fullPriceLoaves = 0;

      for (int i = 1; i <= numberOfLoaves; i++)
      {
        if (i % 3 != 0)
        {
          fullPriceLoaves++;
        }
      }

      int totalCost = fullPriceLoaves * _fullLoafPrice;
      return totalCost;
    }
  }
}