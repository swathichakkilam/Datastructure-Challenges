using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    class UniqueCharacters
    {
        public static bool CheckUnique(string str)
        {
            HashSet<char> set = new HashSet<char>();

            for (int i=0; i<str.Length; i++)
            {
                if (set.Contains(str[i]))
                {
                    return false;
                }
                else
                {
                    set.Add(str[i]);
                }
            }

            return true;
        }
    }
}
