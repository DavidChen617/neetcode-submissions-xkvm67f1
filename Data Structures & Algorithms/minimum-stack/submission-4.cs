public class MinStack {

    private class Node {
        public int Value {get;}
        public int Min {get;}
        public Node? Prev {get;}

        public Node(int val, int min, Node prev){
            Value = val;
            Min = min;
            Prev = prev;
        }

    }

    private Node? curr;
    
    public void Push(int val) {
        int min = curr is null ? val : Math.Min(curr.Min, val);
        curr = new Node(val, min, curr);
    }
    
    public void Pop() {
        curr = curr!.Prev;
    }
    
    public int Top() {
        return curr!.Value;
    }
    
    public int GetMin() {
        return curr!.Min;
    }
}
