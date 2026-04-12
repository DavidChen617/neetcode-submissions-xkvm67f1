public class Node{
    public int val;
    public Node next;
    public Node(int val){
        this.val = val;
        next = null;
    }
}
public class MinStack {
    private Node dummy;

    public MinStack() {
        dummy = new Node(-1);
    }
    
    public void Push(int val) {
        var newNode = new Node(val);
        var next = dummy.next;
        newNode.next = next;
        dummy.next = newNode;
    }
    
    public void Pop() {
        var removed = dummy.next;
        dummy.next = dummy.next.next;
        removed = null;
    }
    
    public int Top() {
        return dummy.next.val;
    }
    
    public int GetMin() {
        int res = dummy.next.val;
        var curr = dummy.next.next;
        while(curr != null){
            if(curr.val < res)
                res = curr.val;
            curr = curr.next;
        }
        return res;
    }
}
