using System;

namespace _0203RemoveLinkedListElement
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
        public ListNode RemoveElements(ListNode head, int val)
        {
            return head;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            ListNode n7 = new ListNode(6);
            ListNode n6 = new ListNode(5, n7);
            ListNode n5 = new ListNode(4, n6);
            ListNode n4 = new ListNode(3, n5);
            ListNode n3 = new ListNode(6, n4);
            ListNode n2 = new ListNode(2, n3);
            ListNode head = new ListNode(1, n2);

            ListNode n44 = new ListNode(1);
            ListNode n33 = new ListNode(2, n44);
            ListNode n22 = new ListNode(2, n33);
            ListNode head2 = new ListNode(1, n22);

            var x = p.RemoveElements(head2, 2);

            var node = x;
            while (node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }
    }
}
