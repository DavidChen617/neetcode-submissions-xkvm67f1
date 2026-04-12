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
    public bool HasPathSum(TreeNode root, int targetSum) {
        return DFS(root, 0);

        bool DFS(TreeNode root, int currSum){
            if(root is null)
                return false;
                
            currSum+=root.val;

            if(root.left is null && root.right is null)
                return currSum == targetSum;
            
            return DFS(root.left, currSum) || DFS(root.right, currSum);
        }    
    }
    
}