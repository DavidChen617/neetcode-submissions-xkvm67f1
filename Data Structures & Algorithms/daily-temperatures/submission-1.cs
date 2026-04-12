public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
         int n = temperatures.Length;
        var result = new int[n];
        var stack = new Stack<(int tempe, int idx)>();

        for(int i = 0; i < n; ++i){
            int t = temperatures[i];

            while(stack.Count > 0 && t > stack.Peek().tempe){
                (int tempe, int idx) = stack.Pop();
                result[idx] = i - idx;
            }
            stack.Push((temperatures[i], i));
        }

        return result;
    }
}
