using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    class CompressString
    {
        public static string StringCompress(string str)
        {
            string compressedString = "";
            char currChar = '';
            int currCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != currChar)
                {
                    compressedString += str[i];
                }
                else
                {

                }

            }

            return null;
        }
    }
}
