using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class kthtoelement
    {
        public static int FindkToLast(int x, Node head)
        {
            if (head == null)
                throw new Exception("Empty linked list");
            if (x < 1)
                throw new Exception("Index out of range");
 
            Node first = head;
            Node second = head;

            for (int i = 1; i < x; i++)
            {
                if (second.nxtlink != null)
                {
                    second = second.nxtlink;
                }
                else
                {
                    throw new Exception("Index out of range");
                }
            }

            //Move the first and second pointers up one at a time until the second is at the end of the list
            while (second.nxtlink != null)
            {
                first = first.nxtlink;
                second = second.nxtlink;
            }
            return first.value;
        }
    }
}
