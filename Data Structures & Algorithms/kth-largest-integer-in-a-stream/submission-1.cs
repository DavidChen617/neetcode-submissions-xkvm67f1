public class KthLargest {
    private List<int> arr;
    private int k = 0;
    private PriorityQueue<int, int> queue = new();

    public KthLargest(int k, int[] nums) {
        this.k = k;
        
        for(int i = 0; i < nums.Length; ++i){
            queue.Enqueue(nums[i], nums[i]);
            
            if(queue.Count > k)
                queue.Dequeue();
        }
    }
    
    public int Add(int val) {
       queue.Enqueue(val, val);

        if(queue.Count > k)
            queue.Dequeue();
        
        return queue.Peek();
    }
}
