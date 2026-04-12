public class MyStack {

    private Queue<object> q = new Queue<object>();
    
    public MyStack() {
        
    }
    
    public void Push(int x) {
        var newQ = new Queue<object>();
        newQ.Enqueue(x);
        newQ.Enqueue(q);
        q = newQ;
    }
    
    public int Pop() {
        int res = (int)q.Dequeue();
        q = (Queue<object>)q.Dequeue();
        return res;
    }
    
    public int Top() {
        return (int)q.Peek();
    }
    
    public bool Empty() {
        return q.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */