public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var stack = new Stack<double>();
        var pair = new (int posi, int speed)[position.Length];

        for (int i = 0; i < position.Length; i++)
        {
            pair[i] = (position[i], speed[i]);
        }

        Array.Sort(pair, (a, b) => b.posi.CompareTo(a.posi));

        for (int i = 0; i < pair.Length; i++)
        {
            stack.Push((double)(target - pair[i].posi) / pair[i].speed);
            
            if(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
                stack.Pop();
        }
        
        return stack.Count;
    }
}
