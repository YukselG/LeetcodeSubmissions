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
    public ListNode RemoveElements(ListNode head, int val) {
 
        while (head != null && head.val == val)
        {
            head = head.next;
        }
        
        // head could become null if all values are to be deleted, so:
        if (head == null) return null;
            
        ListNode deleteNode = head.next;
        ListNode tempNode = head;
        while (deleteNode != null)
        {
            //Console.WriteLine("counter: " + whileCounter);
            //Console.WriteLine("deleteNode.val: " + deleteNode.val);
            //Console.WriteLine("tempNode.val: " + tempNode.val);

            if (deleteNode.val == val)
            {
                //Console.WriteLine("inside if val == val");
                tempNode.next = deleteNode.next;
            } else {
                //Console.WriteLine("inside else statement");
                tempNode = tempNode.next;
            }
            deleteNode = deleteNode.next;

        }
        return head;
    }
}