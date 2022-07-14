// Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.

// For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.

// [10, 343445353, 3453445, 3453545353453] should return 3453455.

// my solution - larsa-mrp

using System;

public static class Kata
{
  public static int sumTwoSmallestNumbers(int[] numbers)
  {
    int min1 = Int32.MaxValue, min2 = Int32.MaxValue; 
    foreach(int n in numbers){
      if(n < min1 || n < min2){
        if(min1 < min2){
          min2 = n;}
          else
          min1 = n;   
      }
    }
    return min1 + min2;
  }
}