public class MyStack {

    private Queue<int> _q1 = new Queue<int>();
    
    public MyStack() {
        
    }
    
    public void Push(int x) {
      _q1.Enqueue(x);
      for(int i = _q1.Count -1; i > 0; --i){
         _q1.Enqueue(_q1.Dequeue());
      }
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