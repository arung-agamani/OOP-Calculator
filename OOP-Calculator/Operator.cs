using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator
{
    public class Operator
    {
        public static string Plus = "+";
        public static string Minus = "-";
        public static string Multiply = "*";
        public static string Divide = "/";
        public static string Radical = "r";

        private string op;

        public Operator()
        {
            this.op = "";
        }

        public Operator(string s)
        {
            switch (s)
            {
                case "+":
                    this.op = Operator.Plus;
                    break;

                case "-":
                    this.op = Operator.Minus;
                    break;

                case "*":
                    this.op = Operator.Multiply;
                    break;

                case "/":
                    this.op = Operator.Divide;
                    break;

                case "r":
                    this.op = Operator.Radical;
                    break;

                default:
                    this.op = "";
                    break;
            }

        }

        public string getOperator()
        {
            return this.op;
        }
    }
}
