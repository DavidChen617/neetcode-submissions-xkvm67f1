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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root is null)
            return null;
        
        if(root.val == key){
            if(root.left is null)
                return root.right;
            else if(root.right is null)
                return root.left;
            
            var minimum = FindMinimum(root.right);
            root.val = minimum.val;
            root.right = DeleteNode(root.right, minimum.val);
        }
        else if(key > root.val)
            root.right = DeleteNode(root.right, key);
        else
            root.left = DeleteNode(root.left, key);

        return root;
    }

    public TreeNode FindMinimum(TreeNode root){
        var curr = root;
        while(curr is not null && curr.left is not null)
            curr = curr.left;
        return curr;
    }
}