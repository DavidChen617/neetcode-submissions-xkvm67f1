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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (subRoot is null)
            return true;

        if(root is null)
            return false;

        if(IsSameTree(root, subRoot))
            return true;

        return IsSubtree(root.left, subRoot) || 
            IsSubtree(root.right, subRoot);

        bool IsSameTree(TreeNode _root, TreeNode _subRoot)
        {
            if (_root is null && _subRoot is null)
                return true;

            if (_root is not null && _subRoot is not null && _root.val == _subRoot.val)
                return IsSameTree(_root.left, _subRoot.left) &&
                       IsSameTree(_root.right, _subRoot.right);

            return false;
        }
    }
}
