public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<(int value, int index)>();
        var result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; ++i){
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
