public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var result = new List<List<int>>();

        for(int i = 0; i < nums.Length; ++i){
            if(i > 0 && nums[i] == nums[i - 1])
                continue;
                
            int l = i + 1, r = nums.Length - 1;
        
            while(l < r){
                int sun = nums[i] + nums[l] + nums[r];

                if(sun > 0){
                    --r;
                }
                else if(sun < 0){
                    ++l;
                }
                else{
                    result.Add(new (){nums[i], nums[l], nums[r]});
                    --r;
                    ++l;
                    while(l < r && nums[l] == nums[l - 1]){
                        ++l;
                    }
                    while(l < r && nums[r] == nums[r + 1]){
                        --r;
                    }
                }
            }
        }

        return result;
    }
}
