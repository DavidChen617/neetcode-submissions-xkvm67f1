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
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){

            var len = q.Count;
            TreeNode right = null;

            for(var i = 0; i < len; ++i){

                var curr = q.Dequeue();

                if(curr is null)
                    continue;

                right = curr;
                q.Enqueue(curr.left);
                q.Enqueue(curr.right);
            }

            if(right is null)
                continue;

            result.Add(right.val);
        }

        return result;
    }
}
