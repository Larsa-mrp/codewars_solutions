// Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

// For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

// Note: The function accepts an integer and returns an integer

// my solution - larsa-mrp

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string num = "";
    int[] result = n.ToString().Select(o => Convert.ToInt32(o) - 48 ).ToArray(); 
    for(int i = 0 ; i < result.Length; i++){
      result[i] = result[i] * result[i];
      num += result[i];  
    }
    return Convert.ToInt32(num);
  }
}