public class MinStack {

    private class Node {
        public int Value { get; set; }
        public Node? Prev { get; set; }
        public int Min { get; private set;}

        public Node(){

        }

        public Node(int v, int min, Node prev = null){
            Value = v;
            Prev = prev;
            Min = min;
        }
    }

    private Node? curr;
  
    public void Push(int val) {
       int min = curr is null? val: Math.Min(curr.Min, val);
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
