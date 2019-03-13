using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class FindLinkedListLoop
    {
        public static void Execute()
        {
            FindLinkedListLoop llist = new FindLinkedListLoop();

            llist.Push(20);
            llist.Push(4);
            llist.Push(15);
            llist.Push(10);

            /*Create loop for testing */
            llist.head.next.next.next.next = llist.head;

            llist.detectLoop();
        }

        int detectLoop()
        {
            Node slow_p = head, fast_p = head;
            while (slow_p != null && fast_p != null && fast_p.next != null)
            {
                slow_p = slow_p.next;
                fast_p = fast_p.next.next;
                if (slow_p == fast_p)
                {
                    Console.WriteLine("Found Loop");
                    return 1;
                }
            }
            return 0;
        }

        Node head;

        class Node
        {
            int data;
            public Node next;
            public Node(int d) { data = d; next = null; }
        }

        void Push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
    }
}
