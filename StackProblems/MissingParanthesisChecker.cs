using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class MissingParanthesisChecker
    {
        public static string CheckMissingParanthesis(string expr)
        {
            GenericStack<char> stack = new GenericStack<char>();

            if (expr== null || expr.Length == 0) {
                return "";
            }


            // PUsh if you see a opening bracket to the stack
            // Pop if you see a closing bracket from the stack
            //          If the stack is empty when you encounter a closing bracket, it means that there is a missing opening paranthesis
            // At the end, if the stack is not empty, then it means that there is a missing closing bracket.
            string missingParanthesis = "";
            for (int i=0; i<expr.Length; i++)
            {
                char ch = expr[i];

                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.StackCount > 0 && stack.Top() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        missingParanthesis = missingParanthesis + "(\t";
                    }
                }
            }

            if (stack.StackCount > 0)
            {
                while (stack.StackCount != 0)
                {
                    char ch = stack.Pop();

                    if (ch == '(')
                    {
                        missingParanthesis = missingParanthesis + ")\t";
                    }
                }
            }

            return missingParanthesis;
            
            ()((()())))))
            
            }
    }
}
