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
    }

    public class InputHandler
    {
        public string inputString { get; set; }
        private bool isComma;
        private bool isZero;

        public InputHandler()
        {
            this.inputString = "0";
            this.isComma = false;
            this.isZero = true;
        }

        public string getFormattedString()
        {
            string formatted = this.inputString.Replace("r", "\u221A");
            return formatted;
        }

        public string getRawString()
        {
            return this.inputString;
        }

        public void setComma(bool set)
        {
            this.isComma = set;
        }

        public void addOperator(string op, int number)
        {
            this.inputString += op + number.ToString();
        }

        public void addOperator(string op, float number)
        {
            this.inputString += op + number.ToString();
        }

        public void addOperator(string op, double number)
        {
            this.inputString += op + number.ToString();
        }

        public void concatNumber(string num)
        {
            if (!this.isZero && num == "0")
            {
                this.inputString += num;
            } else if (this.isZero && !this.isComma && num == ".")
            {
                this.inputString += num;
                setComma(true);
            } else if (this.isZero && this.isComma && num != ".")
            {
                this.inputString += num;
            } else if (this.isZero && !this.isComma && num != "0")
            {
                this.inputString = num;
                this.isZero = false;
            } else if (!this.isZero)
            {
                this.inputString += num;
            }
            
        }
    }
}
