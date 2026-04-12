public class Solution {
    public int[] PlusOne(int[] digits) {
        int num = digits[digits.Length -1];
        num++;
        
        if(num < 10){
            digits[digits.Length -1] = num;
            return digits;
        }

        bool carry = true;
        for(int i = digits.Length -1; i >= 0; --i){
            if(carry){
                int n = digits[i];
                ++n;
                carry = n > 9;
                digits[i] = n % 10;
            }
        }

        if(digits[0] == 0){
            var result = new int[digits.Length + 1];
            result[0] = 1;
            for(int i = 1; i < result.Length; ++i){
                result[i] = digits[i - 1];
            }

            return result;
        }

        return digits;
    }
}
