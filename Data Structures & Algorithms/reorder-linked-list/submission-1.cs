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
    public void ReorderList(ListNode head) {
        DFS(head, head.next);

        ListNode DFS(ListNode root, ListNode cur){
            if(cur is null)
                return root;
            
            root = DFS(root, cur.next);
            
            if(root is null)
                return null;
            
            ListNode temp = null;

            if(root == cur || root.next == cur)
                cur.next = null;
            else{
                temp = root.next;
                root.next = cur;
                cur.next = temp;
            }

            return temp;
        }
    }
}
