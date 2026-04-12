public class Solution {
    public double MyPow(double x, int n) {
        if(x == 0)
            return 0;
        if(n == 0)
            return 1;
        
        double res = 1;

        for(int i = 0; i < Math.Abs(n); ++i){
            res *= x;
        }

        res = n >= 0? res : 1 / res;
        return res;
    }
}
