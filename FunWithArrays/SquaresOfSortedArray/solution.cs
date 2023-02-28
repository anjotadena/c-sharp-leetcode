public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int[] values = new int[n];
        int highestIndex = n - 1;
        
        int left = 0;
        int right = n - 1;
        
        while (left <= right)
        {
            int leftSquare = nums[left] * nums[left];
            int rightSquare = nums[right] * nums[right];
            
            if (leftSquare > rightSquare)
            {
                values[highestIndex--] = leftSquare;
                left++;
            } else {
                values[highestIndex--] = rightSquare;
                right--;
            }
        }
        
        return values;
    }
}