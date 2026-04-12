/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
         return GuessNumber(0, n);
        
        int GuessNumber(int s, int e)
        {
            int m = s + (e - s) / 2;
            
            var ans = guess(m);
            
            if(ans == 0)
                return m;

            if (ans > 0)
                return GuessNumber(m + 1, e);
            
            return GuessNumber(s, m - 1);
        }
        
    }
}