// Problem No. 92 - Reverse Linked List II

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
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        ListNode prevOfM = null;
        ListNode nodeAtM = null;
        ListNode prev = null;
        ListNode curr = head; 
        int index = 1;
        
        if (m == n) {
            return head;
        }
        
        while (curr != null && index <= n) {
          if (index >= m && index <= n) {
             if (m == index) {
              prevOfM = prev;
              nodeAtM = curr;
             }
              
             if (n == index) {
              if (m != 1) {
                prevOfM.next = curr; 
              }
              nodeAtM.next = curr.next;
             }
             
             var temp = curr.next;
             if (index != m) {
               curr.next = prev;
             }
             prev = curr;
             curr = temp;
           } else if (index < m) {
             prev = curr; 
             curr = curr.next;
           }
           index++;
       }
        
       if (m == 1) {
          return prev;
       } else {
          return head;
       }
    }
}