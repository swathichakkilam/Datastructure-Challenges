using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    class ReplaceSpaces
    {
        public static string ReplaceSpace(string str)
        {
            StringBuilder sb = new StringBuilder();
            if (str == null)
            {
                return string.Empty;
            }

            for(int i=0; i<str.Length;i++)
            {
                if (str[i] == ' ')
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(str[i]);
                }
            }

            return sb.ToString();
        }
    }
}
