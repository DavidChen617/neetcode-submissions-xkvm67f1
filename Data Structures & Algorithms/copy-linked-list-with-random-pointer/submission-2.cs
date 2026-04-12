/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    private readonly Dictionary<Node, Node> _map = new 
            Dictionary<Node, Node>();

    public Node copyRandomList(Node head) {
        if(head is null)
            return null;
        if(_map.TryGetValue(head, out var value))
            return value;
        
        var copy = new Node(head.val);
        _map.Add(head, copy);
        copy.next = copyRandomList(head.next);

        if(head.random is null)
            copy.random = null;
        else
            copy.random = copyRandomList(head.random);
        
        return copy;
    }
}
