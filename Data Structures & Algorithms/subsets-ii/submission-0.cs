public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        
        var result = new List<List<int>>();
        var sub = new List<int>();
        DFS(0);

        return result;

        void DFS(int index){
            if(index == nums.Length){
                result.Add(new (sub));
                return;
            }

            sub.Add(nums[index]);
            DFS(index + 1);
            sub.RemoveAt(sub.Count - 1);
            
            while(index + 1 < nums.Length && nums[index] == nums[index + 1])
             ++index;

            DFS(index + 1);
        }
    }
}
