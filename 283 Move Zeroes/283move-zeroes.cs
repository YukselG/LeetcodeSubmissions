public class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums.Length == 1)
        {
            return;
        }
        
        int nextNumberToKeepIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[nextNumberToKeepIndex] = nums[i];
                nextNumberToKeepIndex++;
            }
        }
        
        for (int i = 0; i < nums.Length-nextNumberToKeepIndex; i++)
        {
            nums[nums.Length-i-1] = 0;
        }
        
        return;
    }
}