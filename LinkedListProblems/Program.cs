using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(4);
            head.nxtlink = new Node(3);
            head.nxtlink.nxtlink = new Node(9);
            head.nxtlink.nxtlink.nxtlink = new Node(1);
            head.nxtlink.nxtlink.nxtlink.nxtlink = new Node(6);
            head.nxtlink.nxtlink.nxtlink.nxtlink.nxtlink = new Node(5);
            head.nxtlink.nxtlink.nxtlink.nxtlink.nxtlink.nxtlink = new Node(7);

            //var x = kthtoelement.FindkToLast(3, head);
            // Console.Write(x);
            // Console.ReadLine();


            //ReferenceDelete.DeleteReference(head.nxtlink.nxtlink);
            //Console.WriteLine(head.nxtlink.nxtlink.value);
            //Console.ReadLine();

            //Console.WriteLine("Original List:");
            //var temp = head;
            //while (temp != null)
            //{
            //    Console.Write(temp.value + "->");
            //    temp = temp.nxtlink;
            //}

            //var reverseHead = ReverseLinkedList.ReverseList(head);

            //Console.WriteLine("\nReversed List:");
            //while (reverseHead != null)
            //{
            //    Console.Write(reverseHead.value + "->");
            //    reverseHead = reverseHead.nxtlink;
            //}

            //Console.ReadLine();

            Console.WriteLine("Original List:");
            var temp = head;
            while (temp != null)
            {
                Console.Write(temp.value + "->");
                temp = temp.nxtlink;
            }

            Node partitionedHead = PartitionLinkedList.ParititionList(head, 5);


            Console.WriteLine("\nReversed List:");
            while (partitionedHead != null)
            {
                Console.Write(partitionedHead.value + "->");
                partitionedHead = partitionedHead.nxtlink;
            }

            Console.ReadLine();
        }
    }
}
