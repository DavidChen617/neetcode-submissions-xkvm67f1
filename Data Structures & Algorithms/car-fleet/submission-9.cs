public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var arr = new (int pos, int spe)[n];
        var stack = new Stack<double>();

        for(int i = 0; i < n; ++i)
            arr[i] = (position[i], speed[i]);
        
        Array.Sort(arr, (a, b) => b.pos.CompareTo(a.pos));
       
        for(int i = 0; i < n; ++i){
            stack.Push((double) (target - arr[i].pos) / arr[i].spe);
            
            while(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
                stack.Pop();
        }

        return stack.Count();
    }
}
