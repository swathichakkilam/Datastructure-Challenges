using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class DuplicateRemoval
    {
        public static Node RemoveDuplicate(Node head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.nxtlink == null)
            {
                return head;
            }

            HashSet<int> set = new HashSet<int>();
            Node prev = null;
            Node returnHead = head;
            while(head != null)
            {
                if (set.Contains(head.value))
                {
                    prev.nxtlink = head.nxtlink;
                    head = head.nxtlink;
                }
                else
                {
                    set.Add(head.value);
                    prev = head;
                    head = head.nxtlink;
                }
            }

            return returnHead;
        }
    }
}
