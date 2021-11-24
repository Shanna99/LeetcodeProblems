using System;

namespace _0002AddTwoNumbers
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

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sumList = new ListNode();
            var node1 = l1;
            var node2 = l2;
            var sl = sumList;
            bool temp = false;

            while (node1 != null && node2 != null)
            {
                if (node1.val + node2.val <= 9)
                {
                    sl.next = new ListNode((node1.val + node2.val));
                }

                else
                {
                    int sum = node1.val + node2.val;
                    sum = sum % 10;
                    sl.next = new ListNode(sum);
                    temp = true;
                }
                sl = sl.next;
                node1 = node1.next;
                node2 = node2.next;
                if (temp)
                {
                    if (node1 == null && node2 != null)
                    {
                        node1 = new ListNode(1);
                    }
                    else if (node2 == null && node1 != null)
                    {
                        node2 = new ListNode(1);
                    }
                    else if(node1 == null && node2 == null)
                    {
                        sl.next = new ListNode(1);
                    }
                    else
                    {
                        node1.val += 1;
                    }
                }
                temp = false;
            }

            return sumList.next;

        }
        static void Main(string[] args)
        {
            Program p = new Program();

            //ListNode node5 = new ListNode(9);
            //ListNode node4 = new ListNode(9, node5);
            //ListNode node3 = new ListNode(9, node4);
            ListNode head2 = new ListNode(0);

            //ListNode node9 = new ListNode(9);
            //ListNode node8 = new ListNode(9, node9);
            //ListNode node7 = new ListNode(9, node8);
            //ListNode node6 = new ListNode(9, node7);
            //ListNode node2 = new ListNode(9, node6);
            ListNode node1 = new ListNode(8);
            ListNode head1 = new ListNode(1, node1);

            var x = p.AddTwoNumbers(head1, head2);

            var n = x;
            while (n != null)
            {
                Console.WriteLine(n.val);
                n = n.next;
            }
        }
    }
}
