public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> value = new();

        if (nums == null || nums.Length < 2)
        {
            return Array.Empty<int>();
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (value.TryGetValue(target - nums[i], out int index))
            {
                return new[] { index, i};
            }

            value[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}