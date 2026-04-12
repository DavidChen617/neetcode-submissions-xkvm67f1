public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var minHeap = new PriorityQueue<int[], int>();

        foreach (var ps in points)
        {
            var dist = ps[0] * ps[0] + ps[1] * ps[1];
            minHeap.Enqueue(new int[]{dist, ps[0], ps[1]}, dist);
        }

        var result = new int[k][];

        for (int i = 0; i < k; ++i)
        {
            var q = minHeap.Dequeue();
            result[i] = new []{q[1], q[2]};
        }

        return result;
    }
}

