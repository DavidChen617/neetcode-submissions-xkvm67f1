public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var queue = new PriorityQueue<int, int>();

        for(int i = 0; i < nums.Length; ++i){
            var n = nums[i];
            queue.Enqueue(n, n);

            if(queue.Count > k){
                queue.Dequeue();
            }
        }

        return queue.Peek();
    }
}
