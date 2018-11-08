using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class ReverseLinkedList
    {
        public static Node ReverseList(Node head)
        {
            Node prev = null;
            Node curr = head;
            Node next = null;

            while (curr != null)
            {
                next = curr.nxtlink;
                curr.nxtlink = prev;

                prev = curr;
                curr = next;
            }

            return prev;
        }

        public static Node ReverseListRecursive(Node curr, Node prev)
        {
            if (curr.nxtlink == null)
            {
                Node finalHead = curr;
                finalHead.nxtlink = prev;
                return finalHead;
            }

            // the below two statements Unitary piece
            Node next = curr.nxtlink;
            curr.nxtlink = prev;

            Node head = ReverseListRecursive(next, curr);
            return head;
        }
    }
}
