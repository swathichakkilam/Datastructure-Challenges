using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class GenericStack<T>
    {
        private List<T> StackElements;
        public int StackCount;

        public GenericStack()
        {
            this.StackElements = new List<T>();
            this.StackCount = 0;
        }

        public void Push (T x)
        {
            this.StackElements.Add(x);
            this.StackCount++;
        }

        public T Pop()
        {
            if (this.StackElements.Count > 0)
            {
                T element = this.StackElements[this.StackElements.Count - 1];
                this.StackElements.RemoveAt(this.StackElements.Count - 1);
                this.StackCount--;
                return element;
            }
            Console.WriteLine("Stack is empty");
            return default(T);
        }
        
        public T Top()
        {
            if (this.StackElements.Count > 0)
            {
                T element = this.StackElements[this.StackElements.Count - 1];
                return element;
            }
            Console.WriteLine("Stack is empty");
            return default(T);
        }
    }
}
