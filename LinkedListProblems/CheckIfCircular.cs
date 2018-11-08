using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class CheckIfCircular
    {
        public static Node IsCircular(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node slow = head;
            Node fast = head;

            while(slow != null && fast !=null)
            {
                slow = slow.nxtlink;

                if (fast.nxtlink == null)
                {
                    return null;
                    break;
                }

                fast = fast.nxtlink.nxtlink;

                if (slow == fast)
                {
                    slow = head;

                    while (slow != fast)
                    {
                        slow = slow.nxtlink;
                        fast = fast.nxtlink;
                    }
                }
            }
            return null;
        }
    }
}
