// Your function takes two arguments:

//     current father's age (years)
//     current age of his son (years)

// Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old).

// My solution - Larsa-mrp

using System;
namespace Solution
{
  public class TwiceAsOldSolution
  {
    public static int TwiceAsOld(int dadYears, int sonYears)
    {
      return Math.Abs(sonYears * 2 - dadYears);
    }
  }
}