// A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).

// Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.

// My solution - Larsa-mrp

using System;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    for(char c = 'a'; c <= 'z'; c++){
      if(!str.ToLower().Contains("" + c)){
        return false;
      }
    }
    return true;
  }
}