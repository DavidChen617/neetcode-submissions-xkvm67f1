public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length % groupSize != 0)
            return false;
        
        Array.Sort(hand);
        var dic = new Dictionary<int, int>();
        
        for (int i = 0; i < hand.Length; i++)
        {
            var num = hand[i];
            dic[num] = dic.GetValueOrDefault(num, 0) + 1;
        }

        for (int i = 0; i < hand.Length; i++)
        {
            var num = hand[i];
            if(dic[num] == 0)
                continue;
            
            for (int j = 0; j < groupSize; j++)
            {
                var cur = num + j;
                if(!dic.TryGetValue(cur, out var val) || val < 1)
                    return false;
                
                --dic[cur];
            }
        }
        
        return true;
    }
}
