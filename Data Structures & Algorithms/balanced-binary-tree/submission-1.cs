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
    public bool IsBalanced(TreeNode root) {
        return DFS(root).balanced;
    
        (bool balanced, int height) DFS(TreeNode? current)
        {
            if (current is null)
                return  (true, 0);
            
            (bool balanced, int height) left = DFS(current.left),
                right = DFS(current.right);

            var balanced = left.balanced && right.balanced && 
                            Math.Abs(left.height - right.height) <= 1;
            
            var height = 1+ Math.Max(left.height, right.height);

            return (balanced, height);
        }
    }
}
