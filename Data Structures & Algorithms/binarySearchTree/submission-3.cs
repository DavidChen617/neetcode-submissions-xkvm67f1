public class TreeNode{
        public int key;
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int key, int val, TreeNode left = null, TreeNode right = null){
            this.key = key;
            this.val = val;
            this.left = left;
            this.right = right;
        }
}

class TreeMap {
   
    private TreeNode root;
   
    public TreeMap() {

    }

    public void Insert(int key, int val) {
        var newNode = new TreeNode(key, val);

        if(root is null){
            root = newNode;
            return;
        }

        var curr = root;

        while(true){
            if(curr is null){
                curr = newNode;
                return;
            }
            if(key == curr.key){
                curr.val = val;
                return;
            } 
            if(key > curr.key){
                if(curr.right == null){
                    curr.right = newNode;
                    return;
                }
                curr=curr.right;
            }
               
            else if(key < curr.key){
                if(curr.left == null){
                    curr.left = newNode;
                    return;
                }

                curr=curr.left;
            }
        }
    }

    public int Get(int key) {
        var curr = root;
        while(curr is not null){
            if(curr.key == key)
                return curr.val;
            if(key > curr.key)
                curr = curr.right;
            else if(key < curr.key)
                curr = curr.left;
        }
        
        return -1;
    }

    public int GetMin() {
        var curr = root;
        if(curr is null)
            return -1;

        while(curr.left is not null)
            curr = curr.left;

        return curr.val;
    }

    public int GetMax() {
        var curr = root;
        if(curr is null)
            return -1;

        while(curr.right is not null)
            curr = curr.right;
            
        return curr.val;
    }

    public void Remove(int key) {
        root = remove(root, key);

        TreeNode remove(TreeNode node, int key){
            if(node is null)
                return null;

            if(key > node.key)
                node.right = remove(node.right, key);

            if(key < node.key)
                node.left = remove(node.left, key);

            else{
                if(node.left is null)
                    return node.right;
                else if(node.right is null)
                    return node.left;
                else{
                    var min = FineMinimum(node.right);
                    node.key = min.key;
                    node.val = min.val;
                    node.right = remove(node.right, node.key);
                }
            }

            return node;
        }

        TreeNode FineMinimum(TreeNode node){
            var curr = node;
            while(curr.left is not null)
                curr = curr.left;

            return curr;
        }
    }

    public List<int> GetInorderKeys() {
        var result = new List<int>();
        InorderTraversal(root, result);

        return result;

        void InorderTraversal(TreeNode node, List<int> list){
            if(node is null)
                return;
            InorderTraversal(node.left, list);
            list.Add(node.key);
            InorderTraversal(node.right, list);
        }
    }
}
