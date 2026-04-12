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
    public bool HasCycle(ListNode head) {
      var set = new HashSet<ListNode>();
      var h = head;

      while(h is not null){
        if(!set.Add(h))
            return true;
        h = h.next;
      }
        return false;
    }
}
