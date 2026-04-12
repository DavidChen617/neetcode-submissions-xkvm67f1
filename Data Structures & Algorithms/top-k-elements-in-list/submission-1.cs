public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        var freq = new List<int>[nums.Length + 1];

        for(int i = 0; i < freq.Length; ++i)
            freq[i] = new List<int>();

        foreach(int n in nums){
            if(count.ContainsKey(n))
                count[n]++;
            else
                count[n] = 1;
        }

        foreach(var entry in count){
            freq[entry.Value].Add(entry.Key);
        }

        var res = new int[k];
        int index = 0;

        for(int i = freq.Length-1; i > 0 && index < k; --i){
            foreach(int n in freq[i]){
                res[index++] = n;
                 if(index == k)
                    return res;
            }
        }

        return res;
    }
}
