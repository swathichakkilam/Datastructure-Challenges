using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class StackReverser
    {
        public static void ReverseStack()
        {
            Stack sL = GetLoadedStack();
            Stack tempStack = new Stack();
            
            while(sL.StackCount != 0)
            {
                tempStack.Push(sL.Pop());
            }

            sL = tempStack;

        }

        private static Stack GetLoadedStack()
        {
            Stack s = new Stack();
            s.Push(3);
            s.Push(2);
            s.Push(23);
            s.Push(35);
            s.Push(44);
            s.Push(11);
            s.Push(1);
            return s;
        }
    }
}
