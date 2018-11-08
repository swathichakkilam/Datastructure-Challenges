using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class Stack
    {
        private List<int> StackElements;

        public Stack()
        {
            this.StackElements = new List<int>();
        }
        
        public int StackCount
        {
            get
            {
                return this.StackElements.Count;
            }
        }

        public void Push (int x)
        {
            this.StackElements.Add(x);
        }

        public int Pop()
        {
            if (this.StackElements.Count > 0)
            {
                int element = this.StackElements[this.StackElements.Count - 1];
                this.StackElements.RemoveAt(this.StackElements.Count - 1);
                return element;
            }
            Console.WriteLine("Stack is empty");
            return int.MinValue;
        }
        
        public int Top()
        {
            if (this.StackElements.Count > 0)
            {
                int element = this.StackElements[this.StackElements.Count - 1];
                return element;
            }
            Console.WriteLine("Stack is empty");
            return int.MinValue;
        }
    }
}
