public class MyStack {
    private int _size;
    private int[] array;

    public MyStack() {
        array = new int[4];
    }
    
    public void Push(int x) {
        if (array.Length == _size)
            Resize(array.Length * 2);

        array[_size] = x;
        ++_size;
    }

    public int Pop() {
        var a = array[--_size];
        array[_size] = default;
        return a;
    }
    
    public int Top() {
       return array[_size -1];
    }

    public bool Empty() => _size == 0;
    
    private void Resize(int arrayLength)
    {
        var copy = array;
        array = new int[arrayLength];
        for (int i = 0; i < copy.Length; ++i)
        {
            array[i] = copy[i];
        }
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