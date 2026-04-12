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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var count = 0;
        var cur = head;
        
        while(cur is not null){
            ++count;
            cur = cur.next;
        }

        var removeIdx = count - n;
        if(removeIdx == 0)
            return head.next;
        
        cur = head;
        for(int i = 0; i < count; ++i){
            if(i + 1 == removeIdx){
                cur.next = cur.next.next;
                break;
            }
            cur = cur.next;
        }

        return head;
    }
}
