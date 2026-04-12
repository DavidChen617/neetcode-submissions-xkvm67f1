public class Solution {
    public int MaxProduct(int[] nums) {
        int res = int.MinValue, n = nums.Length;
        var partitions = new List<List<int>>();
        var cur = new List<int>();

        for(int i = 0; i < n; ++i){
            var num = nums[i];
            res = Math.Max(num, res);

            if(num == 0){
                if(cur.Count > 0)
                    partitions.Add(new List<int>(cur));
                cur.Clear();
            }
            else
                cur.Add(num);
        }

        if(cur.Count > 0)
            partitions.Add(new List<int>(cur));

        for(int p = 0; p < partitions.Count; ++p){
            var sub = partitions[p];
            int negs = 0, sn = sub.Count;

            for(int s = 0; s < sn; ++s)
                if(sub[s] < 0)
                    ++negs;
            
            int need = negs % 2 == 0? negs : negs-1, 
            prod = 1;
            negs = 0;

            for(int i = 0, j = 0; i < sn; ++i){
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
                    res = Math.Max(res, prod);
            }
        }
        return res;
    }
}
