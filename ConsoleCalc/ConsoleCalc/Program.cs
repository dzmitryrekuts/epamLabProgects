using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
      

        static void Main(string[] args)
        {

           
            do
            {
                 
                    Console.WriteLine("Result = " + Calculator.Operation(Calculator.AskAndParse(), Calculator.AskAndParse()));
                    Console.WriteLine("'q' to quit// any key to continue");

            } while (!Console.ReadLine().Equals("q"));


        }
    }
}
