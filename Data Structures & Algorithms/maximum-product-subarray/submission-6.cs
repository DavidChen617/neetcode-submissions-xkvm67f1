public class Solution {
    public int MaxProduct(int[] nums) {
        var A = new List<List<int>>();
        var cur = new List<int>();
        int res = int.MinValue;

        for(int i = 0; i < nums.Length; ++i){
            var num = nums[i];
            res = Math.Max(res, num);

            if(num == 0){
                if(cur.Count > 0)
                    A.Add(new List<int>(cur));
                cur.Clear();
            }
            else
                cur.Add(num);
        }

        if(cur.Count > 0)
            A.Add(new List<int>(cur));
 
        for(int i = 0; i < A.Count; ++i){
            var sub = A[i];
            var negs = 0;

            foreach(var s in sub)
                if(s < 0)
                    ++negs;
            
            int prod = 1, need = negs % 2 == 0? negs : (negs -1);
            negs = 0;

            for(int a = 0, b = 0; a < sub.Count; ++a){
                prod *= sub[a];

                if(sub[a] < 0){
                    ++negs;

                    while(negs > need){
                        prod /= sub[b];

                        if(sub[b] < 0)
                            --negs;

                        ++b;
                    }
                }
                if(b <= a)
                    res = Math.Max(res, prod);
            }
        }

        return res;
    }
}
