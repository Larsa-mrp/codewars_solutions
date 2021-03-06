// ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.

// If the function is passed a valid PIN string, return true, else return false.
// Examples (Input --> Output)

// "1234"   -->  true
// "12345"  -->  false
// "a234"   -->  false

// my solution - larsa-mrp
// not exactly regex but gets the job done

using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin){
    foreach (char c in pin){
      if (c < '0' || c > '9'){return false;}}
    if(pin.ToString().Length == 4 || pin.ToString().Length == 6){
      return true;} 
    else{return false;}
  }
}