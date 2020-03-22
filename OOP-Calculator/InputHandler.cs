using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Calculator
{
    
    public class InputHandler : StringHandler
    {
        private bool isComma;
        private bool isZero;
        private bool isOperator;
        private string numeric;
        private string op;
        private Queue<string> numericQueue;
        private Queue<Operator> operatorQueue;

        public InputHandler() : base()
        {
            this.numericQueue = new Queue<string>();
            this.operatorQueue = new Queue<Operator>();
            this.isComma = false;
            this.isZero = true;
            this.isOperator = false;
            this.numeric = "0";
            this.op = "";
        }
        public double evaluate()
        {
            inputString += numeric;
            using (var read = new StringReader(inputString))
            {
                Parser p = new Parser();

                return p.parse(read);
            }
        }
        public string getFormattedString()
        {
            string formatted = (this.inputString + this.numeric + this.op).Replace("r", "\u221A");
            return formatted;
        }

        public void concat(Operator op)
        {
            if (!this.isOperator)
            {
                this.numericQueue.Enqueue(this.numeric);
                this.inputString += this.numeric;
                this.isComma = false;
                this.isZero = true;
                this.isOperator = true;
                this.op = op.getOperator();
            }
            else
            {
                this.op = op.getOperator();
            }
            this.numeric = "";
        }

        public void concat(string val)
        {
            if (this.op != "")
            {
                this.inputString += this.op;
                this.operatorQueue.Enqueue(new Operator(this.op));
                this.op = "";
                this.numeric = "0";
            }
            this.isOperator = false;
            if (val != "0" && val != ".")
            {
                if (numeric.Equals("0") && numeric.Length == 1)
                {
                    this.numeric = val;
                } else
                { 
                    this.numeric += val;
                }
                this.isZero = false;
            } else if (val != "0" && val == "." && !this.isComma)
            {
                this.isComma = true;
                this.numeric += val;
            } else if (val != "." && this.isComma)
            {
                this.numeric += val;
            } else if (!this.isZero && val != ".")
            {
                this.numeric += val;
            }
        }
    }
}
