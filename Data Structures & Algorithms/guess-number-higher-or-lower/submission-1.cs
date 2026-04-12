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
        if(n == 1)
            return 1;
        int s = 0, e = n;
        
        while(true){
            int mid =  s+(e-s) / 2;
            var res = guess(mid);
            if(res == 0)
                return mid;
            if(res > 0)
                s = mid +1;
            else
               e = mid -1;
        }
    }
}