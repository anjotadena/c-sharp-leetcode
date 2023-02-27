public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int result = 0;
        int count = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            // reset count
            if (nums[i] == 0)
            {
                count = 0;
            } else
            {
                count++;
                
                if (count > result)
                {
                    result = count;
                }
            }
        }
        
        return result;
    }
}