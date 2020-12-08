using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Sphinx
{
  public class Program
  {    
    public static void Main()
    { 
      for (int i = 0; i < Riddles.riddle.Count; i++) {
        int random = Riddles.MakeRandom();
        Console.WriteLine(Riddles.questionKeys[random]);
        string yourAnswer = Console.ReadLine();
        if (yourAnswer == Riddles.riddle[Riddles.questionKeys[random]])
        {
          Console.WriteLine("You are correct!");
        }
        else 
        {
          Console.WriteLine("Munch Time!");
          break;
        }
      }
    }
  }
}

