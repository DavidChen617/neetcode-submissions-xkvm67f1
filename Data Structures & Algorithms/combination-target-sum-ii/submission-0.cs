public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        var sub = new List<int>();
        var result = new List<List<int>>();

        DFS(0, 0);
        
        return result;
        
        void DFS(int index, int total)
        {
            if (total == target)
            {
                result.Add(new (sub));
                return;
            }
            
            if(index >= candidates.Length || total > target)
            {
                return;
            }
            
            sub.Add(candidates[index]); // 選
            DFS(index + 1, total + candidates[index]);
            sub.RemoveAt(sub.Count - 1); // 不選
            
            int next = index + 1; // 跳過已經選過的值
            while(next < candidates.Length && candidates[index] == candidates[next])
                ++next;
            DFS(next, total);
        }
    }
}
