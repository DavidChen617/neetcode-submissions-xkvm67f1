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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        var indices = new Dictionary<int, int>();
        int n = inorder.Length, preIdx = 0;
        
        for(int i = 0; i < n; ++i)
            indices[inorder[i]] = i;
        
        return DFS(0, n - 1);

        TreeNode DFS(int l, int r){
            if(l > r)
                return null;
            
            var rootVal = preorder[preIdx++];
            var mid = indices[rootVal];
            var root = new TreeNode(rootVal);
            root.left = DFS(l, mid - 1);
            root.right = DFS(mid + 1, r);

            return root;
        }
    }
}
