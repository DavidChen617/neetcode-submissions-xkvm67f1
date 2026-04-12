public class MyStack {

    private Queue<int> _q1 = new Queue<int>();
    private Queue<int> _q2 = new Queue<int>();
    
    public MyStack() {
        
    }
    
    public void Push(int x) {
        _q2.Enqueue(x);
        while (_q1.Count > 0)
        {
            _q2.Enqueue(_q1.Dequeue());
        }

        var temp = _q1;
        _q1 = _q2;
        _q2 = temp;
    }
    
    public int Pop() {
        return _q1.Dequeue();
    }
    
    public int Top() {
        return _q1.Peek();
    }
    
    public bool Empty() {
        return _q1.Count == 0;
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