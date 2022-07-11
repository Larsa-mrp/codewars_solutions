// Create a function that takes 2 integers in form of a string as an input, and outputs the sum (also as a string):

// Example: (Input1, Input2 -->Output)

// "4",  "5" --> "9"
// "34", "5" --> "39"
// "", "" --> "0"
// "2", "" --> "2"
// "-5", "3" --> "-2"

// Notes:

//     If either input is an empty string, consider it as zero.

//     Inputs and the expected output will never exceed the signed 32-bit integer limit (2^31 - 1)

// My solution - Larsa-mrp

using System;
namespace Solution
{
  public static class Program
  {
    public static string StringsSum(string s1, string s2)
    {
      int first = 0;
      int second = 0;
      Int32.TryParse(s1, out first);
      Int32.TryParse(s2, out second);
      return (first + second).ToString();
    }
  }
}