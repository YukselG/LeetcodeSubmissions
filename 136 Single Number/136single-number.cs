public class Solution {
    public int SingleNumber(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        HashSet<int> setNums = new HashSet<int>();
        int result = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (setNums.Contains(nums[i]))
            {
                setNums.Remove(nums[i]);
            } else {
                setNums.Add(nums[i]);
            }
        }
        result = setNums.ToArray()[0];
        return result;
    }
}