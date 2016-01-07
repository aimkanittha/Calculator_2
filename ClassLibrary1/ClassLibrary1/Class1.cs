using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        private double first, second ,sum;
        private string operator1;
        public Calculator
            { }

        public void getInput(string one, string two, string _operator)
        {
            first = Double.Parse(one);
            second = Double.Parse(two);

            switch (_operator)
            {
                case "+":
                case "-add":
                    operator1 = "+"; break;
                case "-":
                case "-minus":
                    operator1 = "-"; break;
                case "*":
                case "-multiply":
                    operator1 = "*"; break;
                case "/":
                case "-divide":
                    operator1 = "/"; break;
                default: Console.WriteLine("You can't calculate because operator is incorrect."); break;
            }
        }

        private string calculate()
        {
            switch (operator1)
            {
                case "+": sum = first + second; break;
                case "-": sum = first - second; break;
                case "*": sum = first * second; break;
                case "/": sum = first / second; break;
            }
            return sum+"";

            //log file
        }
    }
    
}
