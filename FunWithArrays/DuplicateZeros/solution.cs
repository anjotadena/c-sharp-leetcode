public class Solution {
    public void DuplicateZeros(int[] arr) {
        int n = arr.Length;
        int count = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == 0)
            {
                count++;
            }
        }
        
        int l = n - 1;
    
        while (l > 0 && count > 0)
        {
            if (l + count <= n - 1)
            {
                arr[l+count] = arr[l];
            }
            
            if (arr[l] == 0)
            {
                count--;
            }
            
            arr[l] = 0;
            l--;
        }
    }
}