public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1,
            r = piles.Max(),
            res = r;

        while(l <= r){
            int totalTime = 0;
            int k = l + (r - l) / 2;

            for(int i = 0; i < piles.Length; ++i){
                totalTime += (int)Math.Ceiling((double) piles[i] / k);
            }

            if(totalTime <= h){
                res = k;
                r = k - 1;
            }
            else{
                l = k + 1;
            }
        }

        return res;
    }
}
