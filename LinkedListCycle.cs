//https://leetcode.com/explore/learn/card/linked-list/214/two-pointer-technique/1212/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
        {
            return false;
        }

        if (head.next == null)
        {
            return false;
        }


        ListNode Nextnode = head.next;
        while (true)
        {
            if (Nextnode != head)
            {
                Nextnode = Nextnode.next;
                if (Nextnode == null)
                {
                    return false;
                }
            }
            if (Nextnode != head)
            {
                Nextnode = Nextnode.next;
                if (Nextnode == null)
                {
                    return false;
                }
            }
            if (Nextnode == head)
            {
                return true;
            }
            head = head.next;
        }
        return false;
    }
}
