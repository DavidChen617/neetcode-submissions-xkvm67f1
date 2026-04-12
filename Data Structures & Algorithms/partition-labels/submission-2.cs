public class Solution {
    public List<int> PartitionLabels(string s) {
        int n = s.Length;
        int[] map = new int[26];

        for (int i = 0; i < n; i++)
        {
            var mapIdx = s[i] - 'a';
            map[mapIdx] = i;
        }

        var result = new List<int>();
        int start = 0, end = 0;
        
        for (int i = 0; i < n; i++)
        {
            var mapIdx = s[i] - 'a';
            end = Math.Max(end, map[mapIdx]);
            
            if (end == i)
            {
                result.Add(end - start + 1);
                start = i + 1;
            }
        }
        
        return result;
    }
}
