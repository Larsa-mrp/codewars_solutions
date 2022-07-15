// Convert number to reversed array of digits

// Given a random non-negative number, you have to return the digits of this number within an array in reverse order.
// Example(Input => Output):

// 348597 => [7,9,5,8,4,3]
// 0 => [0]

// solution by larsa-mrp

using System;
using System.Collections.Generic;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      List<long> nums = new List<long>();
      string number = n.ToString();
      foreach(var item in number){
        nums.Add(item - 48);
      }
      nums.Reverse();
      return nums.ToArray();
    }
  }
}