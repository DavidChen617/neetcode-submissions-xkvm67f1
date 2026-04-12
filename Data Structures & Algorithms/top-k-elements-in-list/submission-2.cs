public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int n = nums.Length;
        var count = new Dictionary<int, int>();
        var freq = new List<int>[n + 1];
        for(int i = 0; i <= n; ++i)
            freq[i] = new List<int>();

        for(int i = 0; i < n; ++i){
            var num = nums[i];

            if(count.ContainsKey(num))
                ++count[num];
            else
                count[num] = 1;
        }

        foreach(var pair in count)
            freq[pair.Value].Add(pair.Key);
        
        var res = new int[k];
        var index = 0;

        for(int i = n; i >= 0 && index < k; --i){
            for(int j = 0; j < freq[i].Count; ++j){
                res[index++] = freq[i][j];

                if(index == k)
                    return res;
            }
        }

        return res;
    }
}
