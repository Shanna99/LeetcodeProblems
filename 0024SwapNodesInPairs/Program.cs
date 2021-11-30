using System;

namespace _0024SwapNodesInPairs
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    class Program
    {

        public ListNode SwapPairs(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }

            return SwapPairs(head, 0);
        }

        public ListNode SwapPairs(ListNode node, int count)
        {
            if(node.next == null)
            {
                
            }
            return node;

        }


        static void Main(string[] args)
        {
            Program p = new Program();

            ListNode node3 = new ListNode();
            node3.val = 4;
            node3.next = null;

            ListNode node2 = new ListNode();
            node2.val = 3;
            node2.next = node3;

            ListNode node1 = new ListNode();
            node1.val = 2;
            node1.next = node2;

            ListNode head = new ListNode();
            head.val = 1;
            head.next = node1;


            p.SwapPairs(head);

        }
    }
}
