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
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null)
        {
            //Console.WriteLine("head is null");
            return head;
        }
        
        ListNode swap = head;
        
        head = head.next;
        
        swap.next = head.next;
        
        head.next = swap;
        
        swap.next = SwapPairs(head.next.next);
        
        return head;
    }
}