public class Tree{
    public IList<double> AverageOfLevels(TreeNode root) {
        IList<double> output = new List<double>();
        Queue<TreeNode> _queue = new Queue<TreeNode>();
        _queue.Enqueue(root);
        while(_queue.Count() > 0){
            
        }
    }
}

public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }

