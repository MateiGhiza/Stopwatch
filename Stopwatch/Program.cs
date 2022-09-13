using System;

namespace Stopwatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start to start  ,stop to stop , exit to exit");
          var input = Console.ReadLine();
          var startProgram = new Ui();
          startProgram.uI(input);
        }
    }
}