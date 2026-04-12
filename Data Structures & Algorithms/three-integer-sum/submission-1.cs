public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<List<int>>();
        
        for(int i = 0; i < nums.Length; ++i){
            if(nums[i] > 0)
                break;
            if(i > 0 && nums[i] == nums[i-1])
                continue;
            
            int l = i + 1,
                r = nums.Length - 1;
            
            while(l < r){
                int vi = nums[i],
                    vl = nums[l],
                    vr = nums[r],
                    sum = vi + vl + vr;

                if(sum > 0)
                    --r;
                else if(sum < 0)
                    ++l;
                else{
                    res.Add(new List<int>(){
                        vi, vl, vr
                    });

                    ++l; --r;
                    while(l < r && nums[l] == nums[l - 1])
                        ++l;
                }
            }
        }

        return res;
    }
}
