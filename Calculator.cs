using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator
    {
        private double first, second;
        private string sum ,operator1;
        private InterfaceLog log = null;
        //Polymorphismccc
        private calNumber[] cal = new calNumber[4];
        //private ArrayList calStore = new ArrayList();

        public object Unit { get; private set; }

        public Calculator()
        {
            getOperatorForCal();
        }
        
        public void getOperatorForCal()
        {
            cal[0] = new calAdd();
            cal[1] = new calMinus();
            cal[2] = new calMultiply();
            cal[3] = new calDivide();
            /*calStore.Add(new calAdd());
            calStore.Add(new calMinus());
            calStore.Add(new calMultiply());
            calStore.Add(new calDivide());*/

        }
        public void getInput(string one, string two, string _operator,InterfaceLog e)
        {
            log = e;
            this.first = Double.Parse(one);
            this.second = Double.Parse(two);

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

        public string calculate()
        {

            switch (operator1)
            {
                case "+": sum = cal[0].cal(first, second); break;
                case "-": sum = cal[1].cal(first, second); break;
                case "*": sum = cal[2].cal(first, second); break;
                case "/": sum = cal[3].cal(first, second); break;
                // it can't use method even call class
                /*case "+": sum = calStore[0].cal(first,second); break;
                case "-": sum = calStore[1].cal(first, second); break;
                case "*": sum = calStore[2].cal(first, second); break;
                case "/": sum = calStore[3].cal(first, second); break;*/

            }
            if (log != null)
                { log.writeLog(first + " " + operator1 + " " + second + " = " + sum); }
            return sum;
        }
    }
    
}
