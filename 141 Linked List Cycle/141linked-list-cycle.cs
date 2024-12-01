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
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slowNode = head;
        ListNode fastNode = head;
        
        // since fastNode is pointing at head, at the first iteration we are also checking for the edge case of having a head or a head.next pointing to a null value
        while (fastNode != null && fastNode.next != null)
        {
            slowNode = slowNode.next;
            fastNode = fastNode.next.next;
            
            if (slowNode == fastNode)
            {
                return true;
            }
        }
        return false;
    }
}