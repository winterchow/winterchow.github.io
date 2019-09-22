public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

// 求节点的左右子树的节点总数，如果两者其一大于 n/2，则选任意左右子节点都赢。
// 如果左+右+根 小于n/2，则选择根节点赢。
// 否则都输。
int leftSubTreeNodes = 0;
int rightSubTreeNodes = 0;
int temp = 0;
public bool BtreeGameWinningMove(TreeNode root, int n, int x) {
    temp = x;
    countNode(root, x);
    if(leftSubTreeNodes + rightSubTreeNodes + 1 > (n + 1) / 2){
        return true;
    }
    if(leftSubTreeNodes > n / 2 || rightSubTreeNodes > n / 2){
        return true;
    }

    return false;
}
public int countNode(TreeNode node){
    if(node == null){
        return 0;
    }
    int l = countNode(node.left);
    int r = countNode(node.right);
    if(node.val == temp){
        leftSubTreeNodes = l;
        rightSubTreeNodes = r;
    }

    return l + r + 1;
}