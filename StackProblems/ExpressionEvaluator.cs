using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class ExpressionEvaluator
    {
        public static int EvaluateExpression(string expr)
        {
            if (expr == null || expr.Length == 0)
            {
                Console.WriteLine("Expression is null or empty");
                throw new Exception("Expression is null or empty");
            }

            GenericStack<int> stack = new GenericStack<int>();

            for (int i=0; i<expr.Length; i++)
            {
                char ch = expr[i];
                int ascii = ch - '0';
                if (ascii >=0 && ascii <=9)
                {
                    stack.Push(ascii);
                }
                else if (ch == '*')
                {
                    if (stack.StackCount == 0)
                    {
                        Console.WriteLine("Expression invalid");
                        throw new Exception("Expression invalid");
                    }

                    int prevNum = stack.Pop();
                    int nextNum = expr[i + 1] - '0';
                    if (nextNum < 0 && nextNum > 9)
                    {
                        Console.WriteLine("Expression invalid");
                        throw new Exception("Expression invalid");
                    }

                    stack.Push(prevNum * nextNum);
                    i++;
                }
            }

            var sum = 0;
            while (stack.StackCount > 0)
            {
                sum = sum + stack.Pop();
            }

            return sum;
        }
    }
}
