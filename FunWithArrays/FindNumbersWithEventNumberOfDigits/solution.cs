public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            int n = nums[i];
            int nDigits = 0;
            
            while (n > 0)
            {
                n = n / 10;
                nDigits++;
            }
            
            if (nDigits % 2 == 0) {
                result++;
            }
        }
        
        return result;
    }
}