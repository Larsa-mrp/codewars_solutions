// Simple, given a string of words, return the length of the shortest word(s).

// String will never be empty and you do not need to account for different data types.

// my solution - larsa-mrp

using System;
public class Kata
{
  public static int FindShort(string s)
  {
    string [] words = s.Split(' ');
    int shortest = words[0].Length;
    foreach(string str in words){
      if(str.Length < shortest){shortest = str.Length;}}
    return shortest;
  }
}