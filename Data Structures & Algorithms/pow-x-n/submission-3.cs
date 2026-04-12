public class Solution {
    public double MyPow(double x, int n) {
        if (x == 0)
            return 0;

        if (n == 0)
            return 1;

        var res = DFS(Math.Abs((long) n));
        
        return n < 0 ? 1 / res : res;

        double DFS(long arg1)
        {
            if (arg1 == 0)
                return 1;

            var half = DFS(arg1 / 2);

            return (arg1 % 2 == 0) ? half * half : x * half * half;
        }
    }
}
