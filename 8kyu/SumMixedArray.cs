// Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

// Return your answer as a number.

// My solution

using System;
using System.Linq;

public class Kata
{
  public static int SumMix(object[] x)
  {
    int[] array = new int[x.Length];
    for(int i = 0; i < array.Length; i++){
      array[i] = Convert.ToInt32(x[i]);
    }
    return array.Sum();
  }
}