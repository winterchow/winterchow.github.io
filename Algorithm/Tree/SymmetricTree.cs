public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public bool IsSymmetric(TreeNode root){
    return IsMirror(root, root);
}
public bool IsMirror(TreeNode root1, TreeNode root2){
    if(root1 == null && root2 == null){
        return true;
    }
    if(root1 == null || root2 == null){
        return false;
    }

    return root1.val == root2.val && IsMirror(root1.left, root2.right) && IsMirror(root1.right, root2.left);
}