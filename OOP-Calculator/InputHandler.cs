using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator
{
    
    public class InputHandler : StringHandler
    {
        private bool isComma;
        private bool isZero;
        private bool isOperator;

        public InputHandler() : base()
        {
            this.isComma = false;
            this.isZero = true;
            this.isOperator = false;
        }

        public string getFormattedString()
        {
            string formatted = this.inputString.Replace("r", "\u221A");
            return formatted;
        }

        public void setComma(bool set)
        {
            this.isComma = set;
        }

        public void concatNumber(string num)
        {
            if (num == "+" || num == "-" || num == "*" || num == "*" || num == "/" || num == "r")
            {
                if (!this.isOperator)
                {
                    this.inputString += num;
                    this.isComma = false;
                    this.isZero = true;
                    this.isOperator = true;
                }
            } else
            {
                this.isOperator = false;
                if (this.isZero)
                {
                    // allow dot, but only once
                    if (!this.isComma)
                    {
                        if (num == ".")
                        {
                            this.isComma = true;
                            this.isZero = false;
                            this.inputString += num;
                        } else if (num != "0")
                        {
                            this.isZero = false;
                            this.inputString += num;
                        }
                    } else
                    {
                        if (num != ".")
                        {
                            this.inputString += num;
                        }
                    }
                } else
                {
                    // allow dot, but only once
                    if (!this.isComma)
                    {
                        if (num == ".")
                        {
                            this.isComma = true;
                            this.isZero = false;
                            this.inputString += num;
                        }
                        else
                        {
                            this.isZero = false;
                            this.inputString += num;
                        }
                    }
                    else
                    {
                        if (num != ".")
                        {
                            this.inputString += num;
                        }
                    }
                }
            }
            
        }
    }
}
