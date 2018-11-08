using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackReverser.ReverseStack();

            string missingParanthesis = MissingParanthesisChecker.CheckMissingParanthesis("2 * ( 3 + 5(sasdfasdfasd))))");
            Console.WriteLine(missingParanthesis);


            //int sum = ExpressionEvaluator.EvaluateExpression("2*3*4");
            //Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
