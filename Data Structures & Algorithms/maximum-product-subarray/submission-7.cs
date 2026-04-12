public class Solution {
    public int MaxProduct(int[] nums) {
        var partitionByIsZero = new List<List<int>>();
        var cur = new List<int>();
        var res = int.MinValue;

        for(int i = 0; i < nums.Length; ++i){
            var num = nums[i];

            if(num == 0){
                if(cur.Count > 0)
                    partitionByIsZero.Add(new List<int>(cur));

                cur.Clear();
            }
            else
                cur.Add(num);

            res = Math.Max(res, num);
        }

        if(cur.Count > 0)
            partitionByIsZero.Add(new List<int>(cur));

        for(int s = 0; s < partitionByIsZero.Count; ++s){
            var sub = partitionByIsZero[s];
            var negs = 0;

            for(int l = 0; l < sub.Count; ++l)
                if(sub[l] < 0)
                    ++negs;

            int need = negs % 2 == 0? negs : negs -1, prod = 1;
            negs = 0;

            for(int i = 0, j = 0; i < sub.Count; ++i){
                prod *= sub[i];

                if(sub[i] < 0){
                    ++negs;

                    while(negs > need){
                        prod /= sub[j];

                        if(sub[j] < 0)
                            --negs;

                        ++j;
                    }
                }
                if(j <= i)
                    res = Math.Max(prod, res);
            }
        }

        return res;
    }
}


























