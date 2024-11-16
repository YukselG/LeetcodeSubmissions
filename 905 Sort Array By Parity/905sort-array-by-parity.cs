public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        for (int i = 0; i < nums.Length-1; i++)
        {
            for (int j = 0; j < nums.Length-1-i; j++)
            {
                if (nums[j] % 2 != 0)
                {
                    int temp = nums[j+1];
                    nums[j+1] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        
        return nums;
    }
}