public class Solution {
    public int LeastInterval(char[] tasks, int n) {
     var count = new int[26];
        var result = tasks.Length;
     
        // 使用 char 做索引，並計算頻率
        for (int i = 0; i < result; i++)
            ++count[tasks[i] - 'A'];

        var maxQueue = new PriorityQueue<int, int>();
        for (int i = 0; i < 26; i++)
            if(count[i] > 0)
                // 使用最大堆, 讓頻率越高的排越前面
                maxQueue.Enqueue(count[i], -count[i]);

        // 表示每一輪工作的數量, e.g. n = 2, cycle = 3, A__
        int cycle = n + 1;
        while (maxQueue.Count > 0)
        {
            // 當 Dequeue 出來的值大於 0 時，暫時記錄下來的 List
            var used = new List<int>();

            for (int i = 0; i < cycle; i++)
            {
                if (maxQueue.Count > 0)
                {
                    var v = maxQueue.Dequeue();
                    if(--v > 0)
                        used.Add(v);
                }
                else
                {
                    if(used.Count == 0)
                        break;
                    
                    ++result;
                }
            }
            
            for (int i = 0; i < used.Count; i++)
            {
                var remainder = used[i];
                maxQueue.Enqueue(remainder, -remainder);
            }
        }

        return result;
}
}
