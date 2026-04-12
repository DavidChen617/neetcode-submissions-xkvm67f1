public class KthLargest {
    private readonly PriorityQueue<int, int> _queue = new();
    private readonly int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        for(int i = 0; i < nums.Length; ++i){
            _queue.Enqueue(nums[i], nums[i]);
            if(_queue.Count > k)
                _queue.Dequeue();
        }    
    }
    
    public int Add(int val) {
        _queue.Enqueue(val, val);

        if(_queue.Count > k)
            _queue.Dequeue();

        return _queue.Peek();
    }
}
