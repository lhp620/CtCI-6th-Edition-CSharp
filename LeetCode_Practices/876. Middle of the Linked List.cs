using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class _876
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = new ListNode(0);
            ListNode fast = new ListNode(0);
            slow = head;
            fast = head;

            do
            {
                slow = slow.next;
                fast = fast.next;
                if (fast != null)
                {
                    fast = fast.next;
                }
            } while (fast != null && fast.next != null);

            return slow;
        }
    }
}
