using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator
{
    public class GenericQueue<T>
    {
        private Queue<T> q;
        
        public GenericQueue()
        {
            this.q = new Queue<T>();
        }

        public void add(T t)
        {
            this.q.Enqueue(t);
        }
    }
}
