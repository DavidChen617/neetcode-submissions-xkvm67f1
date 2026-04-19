public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0,
            r = numbers.Length - 1;

        while(l < r){
            var sum = numbers[l] + numbers[r];

            if(sum == target)
                return new int[]{l + 1, r + 1};

            if(sum > target)
                --r;
            else
                ++l;
        }

        return new int[]{0, 0};
    }
}
