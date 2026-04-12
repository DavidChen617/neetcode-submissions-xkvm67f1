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
    public int KthSmallest(TreeNode root, int k) {
       var res = new int[2];
       res[0] = k;
       Dfs(root, res);
       return res[1];
    }

    public void Dfs(TreeNode root, int[] arr){
       if(root is null)
          return;
      
        Dfs(root.left, arr);

        --arr[0];
        if(arr[0] == 0){
            arr[1] = root.val;
            return;
        }

        Dfs(root.right, arr);
    }
}
