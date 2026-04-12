public class Solution {
    public int MaxProduct(int[] nums) {
        var patitions = new List<List<int>>();
        int n = nums.Length;
        var cur = new List<int>();
        var result = int.MinValue;

        for(int i = 0; i < n; ++i){
            var num = nums[i];
            result = Math.Max(num, result);

            if(num == 0){
                if(cur.Count > 0){
                    patitions.Add(new List<int>(cur));
                    cur.Clear();
                }
            }else
                cur.Add(num);
        }

        if(cur.Count > 0)
             patitions.Add(new List<int>(cur));
        
        for(int i = 0; i < patitions.Count; ++i){
            var sub = patitions[i];
            int negs = 0;

            for(int s = 0; s < sub.Count; ++s)
                if(sub[s] < 0)
                    ++negs;
            
            var need = negs % 2 == 0? negs : negs - 1;
            negs = 0;
            var prod = 1;

            for(int s = 0, j = 0; s < sub.Count; ++s){
                prod *= sub[s];

                if(sub[s] < 0){
                    ++negs;

                    while(negs > need){
                        prod /= sub[j];

                        if(sub[j] < 0)
                            --negs;

                        ++j;
                    }
                }

                if(j <= s)
                    result = Math.Max(result, prod);
            }
        }

        return result;
    }
}
