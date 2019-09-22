public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public bool IsBalanced(TreeNode root){
    if(root == null){
        return true;
    }
    if(Math.Abs(DFS(root.left) - DFS(root.right)) > 1){
        return false;
    }

    return IsBalanced(root.left) && IsBalanced(root.right);
}
public int DFS(TreeNode node){
    if(node == null){
        return 0;
    }

    return Math.Max(DFS(node.left), DFS(node.right)) + 1;
}