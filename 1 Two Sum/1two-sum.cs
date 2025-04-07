public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        
        Dictionary<int, int> dict = new Dictionary<int,int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
            {
                result[0] = dict[target-nums[i]];
                result[1] = i;
                return result;
            } else {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);                
                }
            }
        }
        return result;
    }
}