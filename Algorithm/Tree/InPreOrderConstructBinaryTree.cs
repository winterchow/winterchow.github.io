public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}
int point = 0;
public TreeNode BuildTree(int[] preorder, int[] inorder) {
    if(preorder == null || inorder == null || preorder.Length == 0 || inorder.Length == 0){
        return null;
    }
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for(int i = 0; i < inorder.Length; i++){
        dict.Add(inorder[i], i);
    }

    return Build(dict, inorder, preorder, 0, inorder.Length - 1);
}
public TreeNode Build(Dictionary<int, int> dict, int[] inorder, int[] preorder, int start, int end){
    if(start > end || point > inorder.Length - 1){
        return null;
    }
    int index = dict[preorder[point]];
    TreeNode node = dict[preorder[point]];
    point++;
    node.left = Build(dict, inorder, preorder, start, index - 1);
    node.right = Build(dict, inorder, preorder, index + 1, end);

    return node;
}