public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1,
            r = piles.Max(),
            res = r;

        while(l <= r){
            int k = l + (r - l) / 2;
            int totalTimes = 0;
            
            for(int i = 0; i < piles.Length; ++i){
                totalTimes += (int) Math.Ceiling((double)piles[i] / k);
            }

            if(totalTimes <= h){
                r = k - 1;
                res = k;
            }
            else{
                l = k + 1;
            }
        }
     
        return res;
    }
}
