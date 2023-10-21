using System;
using System.Linq;

public static class Kata
{
  public static string boolToWord(bool word)
  {
    string msg = "No";
    
    if (word)
      {
      msg = "Yes";
      Console.WriteLine(msg);
      return msg;
    }
    Console.WriteLine(msg);
    return msg;
  }
}