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
    public ListNode RotateRight(ListNode head, int k) {
        
        if (k == 0 || head == null)
        {
            return head;
        }
        
        ListNode current = head;
        ListNode tail;
        int length = 1;
        
        while (current.next != null)
        {
            length++;
            current = current.next;
        }
        tail = current;
        tail.next = head;
        
        for (int i = 0; i < k%length; i++)
        {
            for (int j = 0; j < length-1; j++)
            {
                head = head.next;
                tail = tail.next;
            }

        }
        
        tail.next = null;
        return head;
    }
}