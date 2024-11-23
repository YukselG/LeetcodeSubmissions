public class Solution {
    public int DominantIndex(int[] nums) {
        int largerNumberIndex = 0;
    
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[largerNumberIndex])
            {
                largerNumberIndex = i;
            }
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[largerNumberIndex] < 2*nums[i] && i != largerNumberIndex)
            {
                return -1;
            }
        }
        
        return largerNumberIndex;
    }
}