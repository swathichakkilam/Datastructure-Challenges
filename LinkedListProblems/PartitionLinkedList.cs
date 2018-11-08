using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class PartitionLinkedList
    {
        public static Node ParititionList(Node head, int x)
        {
            Node smallerHead = null;
            Node smallerLast = null;
            Node equalHead = null;
            Node equalLast = null;
            Node greaterHead = null;
            Node greaterLast = null;

            while (head != null)
            {
                if (head.value == x)
                {
                    if (equalHead == null)
                    {
                        equalHead = head;
                        equalLast = head;
                    }
                    else
                    {
                        equalLast.nxtlink = head;
                        equalLast = equalLast.nxtlink;
                    }
                }
                else if (head.value < x)
                {
                    if (smallerHead == null)
                    {
                        smallerHead = head;
                        smallerLast = head;
                    }
                    else
                    {
                        smallerLast.nxtlink = head;
                        smallerLast = smallerLast.nxtlink;
                    }
                }
                else
                {
                    if (greaterHead == null)
                    {
                        greaterHead = head;
                        greaterLast = head;
                    }
                    else
                    {
                        greaterLast.nxtlink = head;
                        greaterLast = greaterLast.nxtlink;
                    }
                }
                head = head.nxtlink;
            }

            if (greaterLast != null)
            {
                greaterLast.nxtlink = null;
            }

            if (smallerHead == null)
            {
                if (equalHead == null)
                {
                    return greaterHead;
                }
                equalLast.nxtlink = greaterHead;
                return equalHead;
            }

            if (equalHead == null)
            {
                smallerLast.nxtlink = greaterHead;
                return smallerHead;
            }

            smallerLast.nxtlink = equalHead;
            equalLast.nxtlink = greaterHead;

            return smallerHead;
        }
    }
}
