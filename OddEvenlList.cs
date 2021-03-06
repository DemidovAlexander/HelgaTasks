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
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null)
        {
            return head;
        }
        ListNode even = head.next;
        ListNode evenHead = head.next;
        ListNode odd = head;
        while (even != null && even.next != null)
        {
            odd.next = even.next;
            odd = even.next;
            even.next = odd.next;
            even = odd.next;
        }
        odd.next = evenHead;
        return head;
    }
}
