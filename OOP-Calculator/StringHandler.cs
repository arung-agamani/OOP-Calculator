using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator
{
    public class StringHandler
    {
        protected string inputString { get; set; }

        public StringHandler()
        {
            this.inputString = "";
        }

        public StringHandler(string s)
        {
            this.inputString = s;
        }

        public string getRawString()
        {
            return this.inputString;
        }

        public static StringHandler operator+(StringHandler s1, StringHandler s2)
        {
            return new StringHandler(s1.getRawString() + s2.getRawString());
        }

        public static StringHandler operator +(StringHandler s1, string s2)
        {
            return new StringHandler(s1.getRawString() + s2);
        }
    }
}
