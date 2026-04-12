/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node is null)
            return null;
        
        var oldToNew = new Dictionary<Node, Node>();
        
        return Dfs(node);

        Node Dfs(Node n)
        {
            if (oldToNew.TryGetValue(n, out var cloned))
                return cloned;
            
            var copy = new Node(n.val);
            oldToNew[n] = copy;
            
            foreach (var neighbor in n.neighbors)
                copy.neighbors.Add(Dfs(neighbor));
            
            return copy;
        }
    }
}
