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
    /*
    public int DiameterOfBinaryTree(TreeNode root) {
        IList<TreeNode> pathFromNode = new List<TreeNode>();
        IList<TreeNode> pathReverse = new List<TreeNode>();
        Stack<TreeNode> _stack = new Stack<TreeNode>();
        
        TreeNode reverseNode = new TreeNode(0,null,null);
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
            if(currentNode.left == null && currentNode.right == null){
                reverseNode = currentNode;
                break;
                //Console.WriteLine(""+reverseNode.val);   
            }
        }
        Stack<TreeNode> _stackReverse = new Stack<TreeNode>();   
        _stackReverse.Push(reverseNode);

        while(_stackReverse != null && _stackReverse.Count() > 0){
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
    */
    // public int DiameterOfBinaryTree(TreeNode root) {
    //     List<KeyValuePair<TreeNode,int>> pathFromNode = new List<KeyValuePair<TreeNode, int>>();
    //     List<KeyValuePair<TreeNode,int>> pathReverse = new List<KeyValuePair<TreeNode, int>>();
    //     var _stack = new Stack<KeyValuePair<TreeNode,int>>();
    //     var _stackReverse = new Stack<KeyValuePair<TreeNode,int>>();
    //     int level = 0;
    //     TreeNode reverseNode = new TreeNode();
    //     _stack.Push(new KeyValuePair<TreeNode, int>(root,0));
        
    //     while(_stack.Count() > 0){
    //         var currentNode = _stack.Pop();
    //         pathFromNode.Add(currentNode);
    //         level = Math.Max(level,currentNode.Value);
    //         if(currentNode.Key.left != null){
    //             _stack.Push(new KeyValuePair<TreeNode, int>(currentNode.Key.left,level+1));
    //         }
    //         if(currentNode.Key.right != null){
    //             _stack.Push(new KeyValuePair<TreeNode, int>(currentNode.Key.right,level+1));
    //         }
    //         if(currentNode.Key.left == null && currentNode.Key.right == null)
    //             reverseNode = currentNode;

    //     }
    //     _stackReverse.Push(reverseNode);

    //     while(_stackReverse.Count() > 0){
    //         TreeNode currentNode = _stack.Pop();
    //         pathReverse.Add(currentNode);
    //         if(currentNode.left != null){
    //             _stack.Push(currentNode.left);
    //         }
    //         if(currentNode.right != null){
    //             _stack.Push(currentNode.right);
    //         }
    //         if(currentNode.left == null && currentNode.right == null)
    //             reverseNode = currentNode;

    //     }
    //     if(_stackReverse.Count() > _stack.Count()){
    //         return _stackReverse.Count()-1;
    //     }else
    //         return _stack.Count()-1;

    // }
    public int DiameterOfBinaryTree(TreeNode root){
        int max = 0;
        if(root == null) return max;
        var dict = new Dictionary<TreeNode,int>();
        var _stack = new Stack<TreeNode>();
        _stack.Push(root);
        while(_stack.Count > 0){
            TreeNode currentNode = _stack.Peek();
            if(currentNode.left != null && !dict.ContainsKey(currentNode.left)){
                _stack.Push(currentNode.left);
            }
            else if(currentNode.right != null && !dict.ContainsKey(currentNode.right)){
                _stack.Push(currentNode.right);
            }else{
                //we reached in a leaf node
                //now we will pop the stack and traverse in oppposite way and calculate the maximum paths
                TreeNode topNode = _stack.Pop();
                int leftNodeLength = topNode.left != null? dict[topNode.left]: 0;
                int rightNodeLength = topNode.right != null ? dict[topNode.right]: 0;
                //adding only leafnodes in the dictionary
                dict.Add(topNode,Math.Max(leftNodeLength,rightNodeLength)+1);
                int max_left_right = Math.Max(leftNodeLength,rightNodeLength);
                max = Math.Max(max,max_left_right);
            }
        }
        return max;
    }
    public bool IsSameTree(TreeNode p, TreeNode q){
        if(p == null && q == null) return true;
        if(p == null || q == null) return false;
        if(IsSameTree(p.left,q.left) && IsSameTree(p.right,q.right) && p.val == q.val){
            return true;
        }else{
            return false;
        }
    }
    /*
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q != null) return false;
        if(p != null && q == null) return false;
        var firstTree = new Stack<TreeNode>();
        var secondTree = new Stack<TreeNode>();
        firstTree.Push(p);
        secondTree.Push(q);
        while(firstTree.Count > 0 && secondTree.Count > 0){
            var currentNode_1 = firstTree.Pop();
            var currentNode_2 = secondTree.Pop();
            if(currentNode_1.val != currentNode_2.val)  return false;
            if(currentNode_1.left != null && currentNode_1.left.val != null){
                firstTree.Push(currentNode_1.left);
            }
            if(currentNode_1.right != null && currentNode_1.right.val != null){
                firstTree.Push(currentNode_1.right);
            }
            if(currentNode_2.left != null && currentNode_2.left.val != null){
                secondTree.Push(currentNode_2.left);
            }
            if(currentNode_2.right != null && currentNode_2.right.val != null){
                secondTree.Push(currentNode_2.right);
            }
        }
        return true;   
    }
    */
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

