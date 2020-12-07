using System;
using System.Collections.Generic;
// using Sphinx.Riddles;

// namespace Sphinx
// {
public class Program
{
  public static Dictionary<string, string> riddle = new Dictionary<string, string>();
  public static void Main()
  {
    riddle.Add("Whats black and white and read all over?", "newspaper");
    riddle.Add("What goes up but never comes down?", "age");
    riddle.Add("What can you keep after giving to someone?", "your word");
    List<string> questionKeys = new List<string>(riddle.Keys);
    for (int i = 0; i < questionKeys.Count; i++) {
      Console.WriteLine(questionKeys[i]);
      string yourAnswer = Console.ReadLine();
      if (yourAnswer == riddle[questionKeys[i]])
      {
        Console.WriteLine("You are correct!");
      }
      else 
      {
        Console.WriteLine("Munch Time!");
      }
    }
  }
}
// }

