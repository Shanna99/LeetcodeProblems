using System;

namespace _0019RemoveNthNodeFromLinkedList
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

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
           
            int count = 0;
            var node = head;
           
            while(node != null)
            {
                if(n == count)
                {
                    node.next = node.next.next;
                    return head;
                }
                else
                {
                    node = node.next;
                    count++;
                }

            }
            return head;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            ListNode node4 = new ListNode(5);

            ListNode node3 = new ListNode(4);
            node3.next = node4;

            ListNode node2 = new ListNode(3);
            node2.next = node3;

            ListNode node1 = new ListNode(2);
            node1.next = node2;

            ListNode head = new ListNode(1);
            head.next = node1;

            var x = p.RemoveNthFromEnd(head,2);
            var n = x;
            while(n != null)
            {
                Console.WriteLine(n.val);
                n = n.next;
            }
        }
    }
}
