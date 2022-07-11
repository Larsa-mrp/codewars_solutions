// Complete the function that takes a non-negative integer n as input, and returns a list of all the powers of 2 with the exponent ranging from 0 to n ( inclusive ).
// Examples

// n = 0  ==> [1]        # [2^0]
// n = 1  ==> [1, 2]     # [2^0, 2^1]
// n = 2  ==> [1, 2, 4]  # [2^0, 2^1, 2^2]

// solution by larsa-mrp

using System;
using System.Numerics;

public class Kata
{
  public static BigInteger[] PowersOfTwo(int n)
  {
    BigInteger[] nums = new BigInteger[n+1];
    for(int i = 0; i < nums.Length; i++){
      nums[i] = BigInteger.Pow(2, i);
    }
    return nums;
  }
}