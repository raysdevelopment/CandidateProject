using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Sudoku.Core;
using Sudoku.Common;

namespace Sudoku.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategySolver solver = new StrategySolver();
            // TODO: Add strategies

            // TODO: Initialize puzzle from file
            Puzzle puzzle = null;

            solver.Solve(puzzle);
            Console.Write(puzzle);
            
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to continue.");
            Console.ReadLine();
        }
    }
}
