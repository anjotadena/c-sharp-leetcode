public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        if (nums == null || nums.Length < 2)
        {
            return Array.Empty<int>();
        }

        // TwoSumBruteForce(nums, target);

        TwoSumOptimize(nums, target);
    }

    // Time complexity O(n^2)
    // Space complexity O(1)
    public int[] TwoSumBruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return Array.Empty<int>();
    }

    // Time complexity O(n)
    // Space complecity O(n)
    public int[] TwoSumOptimize(int[] nums, int target)
    {
        // optimize way
        Dictionary<int, int> value = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (value.TryGetValue(target - nums[i], out int index))
            {
                return new[] { index, i };
            }

            value[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
