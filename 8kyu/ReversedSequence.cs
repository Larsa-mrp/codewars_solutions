// Build a function that returns an array of integers from n to 1 where n>0.

// Example : n=5 --> [5,4,3,2,1]

// my solution - larsa-mrp

using System.Linq;
using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    int [] a = Enumerable.Range(1, n).ToArray();
    Array.Reverse(a);
    return a;
  }
}