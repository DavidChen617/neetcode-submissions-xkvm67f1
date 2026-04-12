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
        var dic = new Dictionary<Node, Node>();

        return DFS(node);

        Node DFS(Node n){
            if(n is null)
                return null;

            if(dic.ContainsKey(n))
                return dic[n];
            
            var copy = new Node(n.val);
            dic[n] = copy;

            foreach(var nei in n.neighbors){
                copy.neighbors.Add(DFS(nei));
            }

            return copy;
        }
    }
}





