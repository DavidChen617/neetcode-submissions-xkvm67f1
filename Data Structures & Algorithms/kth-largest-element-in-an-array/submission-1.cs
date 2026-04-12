public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var q = new PriorityQueue<int, int>();

        for(int i = 0; i < nums.Length; ++i){
            var n = nums[i];
            q.Enqueue(n, n);

            if(q.Count > k){
                q.Dequeue();
            }
        }

        return q.Peek();
    }
}
