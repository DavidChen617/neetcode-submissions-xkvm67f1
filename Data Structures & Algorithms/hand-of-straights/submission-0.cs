public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if (hand.Length % groupSize != 0)
            return false;

        Array.Sort(hand);
        int n = hand.Length;
        var dic = new Dictionary<int, int>();
        
        for (int i = 0; i < n; i++)
        {
            var num = hand[i];
            dic[num] = dic.GetValueOrDefault(num, 0) + 1;
        }

        for (int i = 0; i < n; i++)
        {
            var num = hand[i];
            if(dic[num] == 0)
                continue;

            for (int j = 0; j < groupSize; j++)
            {
                int curNum = num + j;
                if(!dic.TryGetValue(curNum,out var v) || v == 0)
                    return false;

                --dic[curNum];
            }
        }
        
        return true;
    }
}
