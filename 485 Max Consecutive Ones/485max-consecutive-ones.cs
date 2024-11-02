public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0;
        int maxOnes = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            
            if (nums[i] == 1)
            {
                count = count + 1;
            }
            
            else if (nums[i] == 0)
            {
                count = 0;
            }
            
            if (count > maxOnes)
            {
                maxOnes = count;
            }
        }
        
        return maxOnes;
    }
}