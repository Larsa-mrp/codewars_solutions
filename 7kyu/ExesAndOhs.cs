// Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

// Examples input/output:

// XO("ooxx") => true
// XO("xooxx") => false
// XO("ooxXm") => true
// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
// XO("zzoo") => false

// my solution - larsa-mrp

using System.Linq;
using System;

public static class Kata 
{
  public static bool XO (string input)
  {
    string lwr = input.ToLower();
    int xCount = lwr.Count(f => (f == 'x'));
    int yCount = lwr.Count(f => (f == 'o'));
    return xCount == yCount;
  }
}