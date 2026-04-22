public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        var stack = new Stack<(int value, int index)>();
        var result = new int[n];

        for(int i = 0; i < n; ++i){
            var t = temperatures[i];

            while(stack.Count > 0 && t > stack.Peek().value){
                var touple = stack.Pop();
                result[touple.index] = i - touple.index;
            }

            stack.Push((t, i));
        }
        
        return result;
    }
}
