public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // key = number , value = freq
        var dic = new Dictionary<int, int>();
        int n = nums.Length;
        for(int i = 0; i < n; ++i)
            dic[nums[i]] = dic.TryGetValue(nums[i], out var v)? v + 1 : 1;

        var buckets = new List<int>[n + 1];
        foreach(var (num, freq) in dic){
            if(buckets[freq] is null)
                buckets[freq] = new List<int>();
            
            buckets[freq].Add(num);
        }

        var result = new List<int>(k);

        for(int i = buckets.Length - 1; i >= 0 && result.Count < k; --i){
            if(buckets[i] is null)
                continue;
            for(int j = 0; j < buckets[i].Count && result.Count < k; ++j){
                result.Add(buckets[i][j]);
            }
        }

        return result.ToArray();
    }
}
