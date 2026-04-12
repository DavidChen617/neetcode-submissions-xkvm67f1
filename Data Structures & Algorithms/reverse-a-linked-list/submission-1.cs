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
 // A -> B -> C
public class Solution {
    public ListNode ReverseList(ListNode head) {
        // 判斷當前 head 是否為 null
        if(head == null)
            return null;

        // 緩存 head
        var newHead = head;
        // 判斷 head 指向是否有值
        if(head.next!=null){
            // 遞迴
            newHead = ReverseList(head.next);
            // B -> C -> null to B <- C
            head.next.next = head;    
        }
        // 移除 head 指向
        head.next = null;

        return newHead;
    }
}
