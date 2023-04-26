using System;

namespace MakingProgress
{
  class Program
  {
    static void Main(string[] args)
    {
      // declare steps variable
      int steps = 0;

      // Two steps forward 
      steps += 1;

      // One step back 
      steps--;

      // Print result to the console
      Console.WriteLine(steps);
    }
  }
}
