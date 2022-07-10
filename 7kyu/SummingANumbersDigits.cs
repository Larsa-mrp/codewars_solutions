// Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits.

// For example: (Input --> Output)

// 10 --> 1
// 99 --> 18
// -32 --> 5

// Let's assume that all numbers in the input will be integer values.


// My solution by Larsa-mrp

using System.Linq;
using System;
public class Kata
{
  public static int SumDigits(int number)
  {
    int total = 0;
    int trueValue = Math.Abs(number);
    string num = Convert.ToString(trueValue);
    foreach(char item in num){
      total += item - '0';
    } 
    return total;
  }
}