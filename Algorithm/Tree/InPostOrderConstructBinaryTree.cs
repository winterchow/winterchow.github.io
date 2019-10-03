public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}
int point = 0;
public TreeNode BuildTree(int[] postorder, int[] inorder) {
    if(postorder == null || inorder == null || postorder.Length == 0 || inorder.Length == 0){
        return null;
    }
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for(int i = 0; i < inorder.Length; i++){
        dict.Add(inorder[i], i);
    }
    point = inorder.Length - 1;
    return Build(dict, inorder, postorder, 0, inorder.Length - 1);
}
public TreeNode Build(Dictionary<int, int> dict, int[] inorder, int[] postorder, int start, int end){
    if(start > end || point < 0){
        return null;
    }
    int index = dict[postorder[point]];
    TreeNode node = dict[postorder[point]];
    point--;
    node.right = Build(dict, inorder, postorder, index + 1, end);
    node.left = Build(dict, inorder, postorder, start, index - 1);

    return node;
}