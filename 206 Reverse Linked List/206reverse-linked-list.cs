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
public class Solution {
    public ListNode ReverseList(ListNode head) {
        /* ---------- THE BELOW SOLUTION IS DONE WITH RECURSION  ---------- */
        
        // base case: traverse the list until the end
        if (head == null || head.next == null)
        {
            return head;
        }
        // Recursive call: after base case, assign the new head (last node) to newHead variable
        ListNode newHead = ReverseList(head.next);
        // the below swaps the two nodes. So we take current (e.g. 4), take the next of it (5) and then take the next of 5 and set it to current (4);
        head.next.next = head;
        // after swapping we set the next of the current to null
        head.next = null;

        // returning the new head, so we have the start of the list
        return newHead;
    }
}
