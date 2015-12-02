using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Calculator
    {

        private static double parseResult;

        const string PLUS = "+";
        const string MINUS = "-";
        const string DIVISION = "/";
        const string MULTIPLY = "*";


        public static double AskAndParse() {
            Console.WriteLine("Enter Number");
            string number = Console.ReadLine();

            try {
                 parseResult = Double.Parse(number);
                    }
            catch(FormatException e) {

                Console.WriteLine("Not a number! Please, Enter a number");
                AskAndParse();

            }


            return parseResult ;
        }

        private static string AskOperation()
        {
            Console.WriteLine("Enter operation");
            return Console.ReadLine();
        }

        public static double Operation(double number1, double number2) {

            double result;
            switch (AskOperation())
            {
                case PLUS:
                    result = Addition(number1, number2);
                    break;
                case MINUS:
                    result = Subtracrion(number1, number2);
                    break;
                case DIVISION:
                        result = Division(number1, number2);
                    break;
                case MULTIPLY:
                    result = Multiplication(number1, number2);
                    break;
                default:
                    Console.WriteLine("Unknoun operation");
                   result = Operation(number1, number2);
                    break;
            }



            return result ;
        }

        public static double Addition(double num1, double num2) {
            return num1 + num2;
        }
        public static double Subtracrion(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }



    }
}
