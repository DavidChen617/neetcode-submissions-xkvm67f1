public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        var res = new List<List<int>>();
        var sub = new List<int>();
        DFS(0, 0);

        return res;

        void DFS(int index, int total)
        {
            if (total == target)
            {
                res.Add(new (sub));
                return;
            }
            
            if(index >= candidates.Length || total > target)
                return;
            
            sub.Add(candidates[index]); // 選
            DFS(index + 1, total + candidates[index]);
            sub.RemoveAt(sub.Count - 1);
            
            var next = index + 1;
            while(next < candidates.Length && candidates[next] == candidates[index])
                ++next;
            
            DFS(next, total);
        }
    }
}
