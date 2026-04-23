public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var pairs = new (int posi, int speed)[n];
        
        for(int i = 0; i < n; ++i){
            pairs[i] = (position[i], speed[i]);
        }

        Array.Sort(pairs, (a, b) => b.posi.CompareTo(a.posi));

        var stack = new Stack<double>();

        for(int i = 0; i < n; ++i){
            var p = pairs[i];
            stack.Push((double)(target - p.posi) / p.speed);

            while(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)){
                stack.Pop();
            }
        }

        return stack.Count();
    }
}
