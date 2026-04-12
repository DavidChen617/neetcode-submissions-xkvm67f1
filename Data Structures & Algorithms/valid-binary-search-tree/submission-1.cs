/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        return DFS(root, long.MinValue, long.MaxValue);

        bool DFS(TreeNode node, long left, long right){
            if(node is null)
                return true;

            if(node.val <= left || node.val >= right)
                return false;
            
            return DFS(node.left, left, node.val) &&
                DFS(node.right, node.val, right);
        }
    }
}
