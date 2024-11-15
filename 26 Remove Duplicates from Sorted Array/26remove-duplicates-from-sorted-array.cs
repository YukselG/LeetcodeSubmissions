public class Solution {
    public int RemoveDuplicates(int[] nums) {
        /*
        if(nums.Length == 0)
        {
            return 0;
        }
        
        int uniqueNumber = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i-1])
            {
                nums[uniqueNumber] = nums[i];
                uniqueNumber++;
            }
        }
        
        return uniqueNumber;
        */
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return 1;
    
        int uniqueNumber = 0;
        
        for (int i = 0; i < nums.Length-1; i++) {
            if (nums[i] != nums[i+1]) {
                nums[uniqueNumber] = nums[i];
                uniqueNumber++;
            }
        }
    
        // Handle last element
        nums[uniqueNumber] = nums[nums.Length-1];
        uniqueNumber++;
    
        return uniqueNumber;
    }
}