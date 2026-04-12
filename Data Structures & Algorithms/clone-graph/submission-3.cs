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

        var dic = new Dictionary<Node, Node>();
        var q = new Queue<Node>();
        q.Enqueue(node);
        dic[node] = new Node(node.val);

        while(q.Count > 0){
            var cur = q.Dequeue();

            foreach(var nei in cur.neighbors){
                if(!dic.ContainsKey(nei)){
                    dic[nei] = new Node(nei.val);
                    q.Enqueue(nei);
                }

                dic[cur].neighbors.Add(dic[nei]);
            }
        }

        return dic[node];
    }
}













