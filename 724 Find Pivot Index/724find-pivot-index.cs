public class Solution {
    public int PivotIndex(int[] nums) {
        if (nums.Length == 1)
        {
            return 0;
        }
        
        int[] sumLeft = new int[nums.Length];
        int[] sumRight = new int[nums.Length];

        sumLeft[0] = 0;
        
        for (int i = 1; i < nums.Length; i++)
        {
            sumLeft[i] =  nums[i-1] + sumLeft[i-1];
        }
        
        sumRight[sumRight.Length-1] = 0;
        for (int i = nums.Length-2; i >= 0  ; i--)
        {
            sumRight[i] = nums[i+1] + sumRight[i+1];
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (sumRight[i] == sumLeft[i])
            {
                return i;
            }
        }
        
        return -1;
    }
}