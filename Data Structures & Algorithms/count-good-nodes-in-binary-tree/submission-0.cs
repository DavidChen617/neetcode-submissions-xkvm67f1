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
    public int GoodNodes(TreeNode root) {
        return DFS(root, root.val);

        int DFS(TreeNode node, int maxVal){
            if(node is null)
                return 0;
            
            int res = node.val >= maxVal? 1 : 0;
            maxVal = Math.Max(node.val, maxVal);
            res += DFS(node.left, maxVal);
            res += DFS(node.right, maxVal);

            return res;
        }
    }
}
