// Description:

// Remove an exclamation mark from the end of a string. For a beginner kata, you can assume that the input data is always a string, no need to verify it.
// Examples

// remove("Hi!") === "Hi"
// remove("Hi!!!") === "Hi!!"
// remove("!Hi") === "!Hi"
// remove("!Hi!") === "!Hi"
// remove("Hi! Hi!") === "Hi! Hi"
// remove("Hi") === "Hi"

// Note

// Please don't post issue about difficulty or duplicate.

// my solution - larsa-mrp

public class Kata
{
  public static string Remove(string s)
  {
    char[] arr = new char [s.Length];
    for(int i = 0; i < s.Length; i++){
      arr[i] = s[i];
    }
    if(arr[arr.Length - 1] == '!'){return s.Substring(0, s.Length -1);}
    else return s;
  }
}