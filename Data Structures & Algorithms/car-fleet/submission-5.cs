public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var pair = new (int posi, int speed)[position.Length];

        for (int i = 0; i < position.Length; i++)
            pair[i] = (position[i], speed[i]);
        
        Array.Sort(pair, (a, b) => b.posi.CompareTo(a.posi));
        
        int fleet = 0;
        double last = -1;

        for (int i = 0; i < pair.Length; i++)
        {
            var t = (double)(target - pair[i].posi) / pair[i].speed;
            if(t > last){
                fleet++;
                last = t;
            }
                
        }
        
        return fleet;
    }
}
