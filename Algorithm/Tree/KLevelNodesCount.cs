public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public int KLevelNodesCount(TreeNode node, int k){
    if(node == null || k <= 0){
        return 0;
    }
    if(node != null && k == 1){
        return 1;
    }

    return KLevelNodesCount(node.left, k - 1) + KLevelNodesCount(node.right, k - 1);
}