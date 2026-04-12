public class Solution {
    public uint ReverseBits(uint n)
    {
        var binary = string.Empty;

        for (int i = 0; i < 32; i++)
        {
            if ((n & (1 << i)) != 0)
                binary += '1';
            else
                binary += '0';
        }

        uint res = 0;
        for (int i = 0; i < 32; i++)
        {
            if (binary[31 - i] == '1')
            {
                res = res | (uint)(1 << i);
            }
        }
        
        return res;
    }
}
