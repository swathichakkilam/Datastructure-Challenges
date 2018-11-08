using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class CheckPalindrome
    {
        public static bool CheckIfLinkedListisPalindrome(Node head)
        {
            var length = 0;

            var temp = head;
            while (temp != null)
            {
                length++;
                temp = temp.nxtlink;
            }

            return true;
        }
    }
}
