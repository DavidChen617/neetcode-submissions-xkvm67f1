public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        return MinEatingSpeed(1, piles.Max());
        
        int MinEatingSpeed(int s, int e)
        {
            if (s > e)
                return s;
            
            int m =  s + (e - s) / 2;
            var totalTimes = 0;
            foreach (var p in piles)
                totalTimes += (int)Math.Ceiling((double)p / m);
            
            if (totalTimes > h)
               return MinEatingSpeed(m+1, e); 
            
            return MinEatingSpeed(s, m -1);
        }
    }
}
