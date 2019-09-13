public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

// BFS
public List<List<int>> BinaryTreeLevelOrderTraversal(TreeNode root){
    List<List<int>> res = new List<List<int>>();
    if(root == null){
        return res;
    }
    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root);
    while(queue.Count != 0){
        List<int> level = new List<int>();
        int levelSize = queue.Count;
        for(int i = 0; i < levelSize; i++){
            TreeNode temp = queue.Dequeue();
            if(temp.left != null){
                queue.Enqueue(temp.left);
            }
            if(temp.right != null){
                queue.Enqueue(temp.right);
            }
            level.Add(temp.val);
        }
        res.Add(level);
    }

    return res;
}