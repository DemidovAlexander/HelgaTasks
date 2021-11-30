//https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1207/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null)
        {
            return head;
        }
        ListNode curNode = head.next;
        ListNode prevNode = head;
        while (curNode != null)
        {
            if (curNode.val == val)
            {
                prevNode.next = curNode.next;
            }
            else
            {
                prevNode = prevNode.next;
            }
            curNode = curNode.next;
        }
        if (head.val == val)
        {
            head = head.next;
        }
        return head;
    }
}
