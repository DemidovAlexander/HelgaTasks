//https://leetcode.com/explore/learn/card/linked-list/219/classic-problems/1209/
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
    public bool IsPalindrome(ListNode head)
    {
        ArrayList arr = new ArrayList();
        ListNode Node = head;
        while (Node != null)
        {
            arr.Add(Node.val);
            Node = Node.next;
        }
        int j = arr.Count - 1;
        for (int i = 0; i < j; i++)
        {
            if (!arr[i].Equals(arr[j]))
            {
                return false;
            }
            j--;
        }
        return true;
    }
}
