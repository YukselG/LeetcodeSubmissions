/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
    
        ListNode pointerA = headA;
        ListNode pointerB = headB;
        
        // checking for edge cases
        if (headA == null || headB == null)
        {
            return null;
        }
        
        // while loop that runs if the two pointers are different. In the end, they can either both be the same node (intersection), or both point to null (the end of their lists).
        while (pointerA != pointerB)
        {
            // if pointerA points to null, it is at its end of its list, and we point to the head of the other node, and traverse that node now.
            // we do the same for pointerB.
            // when both pointers are looking at the other list, they will eventually meet at the intersection
            if (pointerA == null)
            {
                pointerA = headB;
            } else 
            {
                pointerA = pointerA.next;
            }
            
            if (pointerB == null)
            {
                pointerB = headA;
            } else 
            {
                pointerB = pointerB.next;
            }
        }
        
        return pointerA;
        
        // hashset implementation, using extra space though
        /*
        HashSet<ListNode> setNodes = new HashSet<ListNode>();
        //ListNode nodeA = headA;
        while (headA != null)
        {
            setNodes.Add(headA);
            headA = headA.next;
        }
        //ListNode nodeB = headB;
        while (headB != null)
        {
            if (setNodes.Contains(headB))
            {
                return headB;
            } else 
            {
                headB = headB.next;
            }
        }
        
        return null;
        */
    }
}