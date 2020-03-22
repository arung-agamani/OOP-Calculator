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
        private string ans;
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
            this.ans = "";
        }
        public double evaluate()
        {
            inputString += numeric;
            inputString = inputString.Replace("Ans", this.ans);
            Console.WriteLine(this.inputString);
            using (var read = new StringReader(inputString))
            {
                Parser p = new Parser();
                double ans = p.parse(read);
                this.ans = ans.ToString().Replace(",", ".");
                Console.WriteLine(this.ans);
                return ans;
            }
        }

        public void flush()
        {
            this.inputString = "";
            this.numeric = "0";
            this.op = "";
            this.isComma = false;
            this.isZero = true;
            this.isOperator = false;
        }

        public void setNumeric(double d)
        {
            this.numeric = d.ToString().Replace(",", ".");
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
            else if (op.getOperator() == Operator.Radical)
            {
                this.op += op.getOperator();
            }
            else if (op.getOperator() == Operator.Minus && this.op.Length == 1)
            {
                this.op += op.getOperator();
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
