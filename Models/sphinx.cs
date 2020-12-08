using System;
using System.Collections.Generic;

namespace Sphinx.Models
{
  class Riddles 
  {
    public static int MakeRandom() 
    {
      Random x = new Random();
      int random = x.Next(riddle.Count);
      return random;
    }
    public static Dictionary<string, string> riddle = new Dictionary<string, string>() {
      { "Whats black and white and read all over?", "newspaper" },
      { "What goes up but never comes down?", "age" },
      { "What can you keep after giving to someone?", "your word" }
    };
    public static List<string> questionKeys = new List<string>(riddle.Keys); 
  }
}
