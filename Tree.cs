public class Tree{
    public IList<double> AverageOfLevels(TreeNode root) {
        List<KeyValuePair<int,double>> nodeValueWithLevel = new List<KeyValuePair<int, double>>();
        int level = 0;
        TreeLevel _root_with_level = new TreeLevel(root,0);
        Queue<TreeLevel> _queue = new Queue<TreeLevel>();
        _queue.Enqueue(_root_with_level);
        while(_queue.Count() > 0){
            TreeLevel treeWihtLevel = _queue.Dequeue();
            level = Math.Max(level,treeWihtLevel.level);
            if(treeWihtLevel.treeNode.left != null){
                TreeLevel leftTreeWithLevel = new TreeLevel(treeWihtLevel.treeNode.left,level+1);
                _queue.Enqueue(leftTreeWithLevel);
            }   
            if(treeWihtLevel.treeNode.right != null){
                TreeLevel rightTreeWithLevel = new TreeLevel(treeWihtLevel.treeNode.right,level+1);
                _queue.Enqueue(rightTreeWithLevel);
            }  
            Console.WriteLine($"Level: {treeWihtLevel.level}, node value: {treeWihtLevel.treeNode.val}");
            nodeValueWithLevel.Add(new KeyValuePair<int, double>(treeWihtLevel.level,treeWihtLevel.treeNode.val));
        }
        
        return CalculateAvgByLevel(nodeValueWithLevel);
    }

    private IList<double> CalculateAvgByLevel(List<KeyValuePair<int, double>> nodeValueWithLevel)
    {
        IList<double> output = new List<double>();
        foreach(int level in nodeValueWithLevel.Select(a => a.Key).Distinct() ){
            double average = (double)nodeValueWithLevel.Where(b => b.Key == level).Select(a => a.Value).Sum()/(double)nodeValueWithLevel.Where(b => b.Key == level).Count();
            output.Add(average);
        }
        return output;
    }
    public bool HasPathSum(TreeNode root, int targetSum, IList<TreeNode> paths) {
        if(root == null)    return false;
        var _stack = new Stack<(TreeNode,int)>();
        _stack.Push((root,root.val));
        while(_stack.Count() > 0){
            var currentnode = _stack.Pop();
            
            if(currentnode.Item1.left != null){
                _stack.Push((currentnode.Item1.left,currentnode.Item2+currentnode.Item1.left.val));
            }
            if(currentnode.Item1.right != null){
                _stack.Push((currentnode.Item1.right,currentnode.Item2+currentnode.Item1.right.val));
            }
            if(currentnode.Item1.left == null && currentnode.Item1.right == null && currentnode.Item2 == targetSum) return true;
        }
        return false;    
    }
    public int DiameterOfBinaryTree(TreeNode root) {
        IList<TreeNode> pathFromNode = new List<TreeNode>();
        IList<TreeNode> pathReverse = new List<TreeNode>();
        Stack<TreeNode> _stack = new Stack<TreeNode>();
        Stack<TreeNode> _stackReverse = new Stack<TreeNode>();
        TreeNode reverseNode = null;
        _stack.Push(root);
        
        while(_stack.Count() > 0){
            TreeNode currentNode = _stack.Pop();
            pathFromNode.Add(currentNode);
            if(currentNode.left != null){
                _stack.Push(currentNode.left);
            }
            if(currentNode.right != null){
                _stack.Push(currentNode.right);
            }
            if(currentNode.left == null && currentNode.right == null)
                reverseNode = currentNode;

        }
        _stackReverse.Push(reverseNode);

        while(_stackReverse.Count() > 0){
            TreeNode currentNode = _stack.Pop();
            pathReverse.Add(currentNode);
            if(currentNode.left != null){
                _stack.Push(currentNode.left);
            }
            if(currentNode.right != null){
                _stack.Push(currentNode.right);
            }
            if(currentNode.left == null && currentNode.right == null)
                reverseNode = currentNode;

        }
        if(_stackReverse.Count() > _stack.Count()){
            return _stackReverse.Count()-1;
        }else
            return _stack.Count()-1;

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
 public class TreeLevel{
     public TreeNode treeNode;
     public int level;
     public TreeLevel(TreeNode _node = null,int _level = 0){
         this.treeNode = _node;
         this.level = _level;
     }
 }

