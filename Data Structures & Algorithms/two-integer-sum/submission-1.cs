public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      var dic = new Dictionary<int, int>();
      int a = 0, b = 0;

      for(int i = 0; i < nums.Length; ++i){
        if(dic.ContainsKey(nums[i])){
            a = dic[nums[i]];
            b = i;
            break;
        }
        
        dic.Add(target - nums[i], i);
      }

      return new int[]{a, b};
    }
}
