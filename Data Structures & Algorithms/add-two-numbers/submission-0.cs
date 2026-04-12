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

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var carry = 0;
        ListNode demmy = new ListNode(),
            cur = demmy;
        
        while(l1 is not null || l2 is not null || carry != 0){
            int v1 = l1 == null? 0 : l1.val,
                v2 = l2 == null? 0 : l2.val,
                val = v1 + v2 + carry;
            
            carry = val / 10;
            val = val % 10;
            cur.next = new ListNode(val);
            cur = cur.next;
            l1 = l1 is null? null : l1.next;
            l2 = l2 is null? null : l2.next;
        }

        return demmy.next;
    }
}
