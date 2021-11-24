using System;

namespace _0141LinkedListCycle
{
    //accepted by leetcode 97,26% faster than other c# users
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    class Program
    {

     

        //accepted by leetcode, 77.22% faster than other c# users
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 != null)
            {
                return l2;
            }
            if (l1 != null && l2 == null)
            {
                return l1;
            }
            if (l1 == null && l2 == null)
            {
                return null;
            }
            var node1 = l1;
            var node2 = l2;
            ListNode newList;
            if (node1.val <= node2.val)
            {
                newList = new ListNode(node1.val);
                node1 = node1.next;
            }
            else
            {
                newList = new ListNode(node2.val);
                node2 = node2.next;
            }
            var nl = newList;
            while (node1 != null && node2 != null)
            {
                if (node1.val <= node2.val)
                {
                    nl.next = new ListNode(node1.val);
                    node1 = node1.next;
                }
                else
                {
                    nl.next = new ListNode(node2.val);
                    node2 = node2.next;
                }
                nl = nl.next;

            }
            if (node1 == null && node2 != null)
            {
                nl.next = node2;
            }
            else if (node1 != null && node2 == null)
            {
                nl.next = node1;
            }

            return newList;
        }

        public ListNode DetectCycle(ListNode head)
        {

            return null;
        }

        //accepted by leetcode 97.26% faster than other c# users
        public bool HasCycle(ListNode head)
        {
            var i = head;
            var j = head;

            while (i != null && j != null && j.next != null)
            {
                i = i.next;
                j = j.next.next;
                if (i == j)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Program p = new Program();


            ListNode node2 = new ListNode(4);

            ListNode node1 = new ListNode(2);
            node1.next = node2;

            ListNode head = new ListNode(1);
            head.next = node1;

            ListNode head13 = new ListNode(4);
            ListNode head12 = new ListNode(3);
            head12.next = head13;
            ListNode head1 = new ListNode(1);
            head1.next = head12;

            var y = p.MergeTwoLists(head, head1);
            Console.WriteLine(y);

            var x = p.HasCycle(head);
            Console.WriteLine(x);
        }
    }
}
