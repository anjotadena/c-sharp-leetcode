public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;

        return MergeSort(nums, 0, n-1);
    }

    public int[] MergeSort(int[] a, int l, int r)
    {
        if (l < r)
        {
            int m = (l + (r-1)) / 2 + 1;

            MergeSort(a, l, m-1);
            MergeSort(a, m, r);
            Merge(a, l, m, r);
        }

        return a;
    }

    public void Merge(int[] nums, int l, int m, int r)
    {
        int lArrLength = m - l;
        int rArrLength = r - m + 1;
        int[] tLArr = new int[lArrLength];
        int[] tRArr = new int[rArrLength];
        int i, j;

        for (i = 0; i < lArrLength; i++)
        {
            tLArr[i] = nums[l+i];
        }

        for (i = 0; i < rArrLength; i++)
        {
            tRArr[i] = nums[m+i];
        }

        // reset pointer
        i = 0;
        j = 0;
        int k = l;

        while (i < lArrLength && j < rArrLength)
        {
            if (tLArr[i] <= tRArr[j])
            {
                nums[k++] = tLArr[i++];
            }
            else
            {
                nums[k++] = tRArr[j++];
            }
        }
        
        if (i == lArrLength)
        {
            for (int ii = j; ii < rArrLength; ii++)
            {
                nums[k++] = tRArr[ii];
            }
        }

        if (j == rArrLength)
        {
            for (int ii = i; ii < lArrLength; ii++)
            {
                nums[k++] = tLArr[ii];
            }
        }
    }
}