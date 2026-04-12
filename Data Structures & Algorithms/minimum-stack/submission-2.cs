public class Node{
    public int val;
    public Node next;
    public int min;
    public Node(int val, int min){
        this.val = val;
        this.min = min;
        next = null;
    }
}
public class MinStack {
    private Node dummy;

    public MinStack() {
        dummy = new Node(-1, int.MaxValue);
    }
    
    public void Push(int val) {
        var newNode = new Node(val, Math.Min(val, dummy?.next?.min ?? int.MaxValue));
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
        return dummy.next.min;
    }
}
