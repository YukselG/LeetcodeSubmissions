public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> resultList = new List<int>();
        if (nums.Length == 1)
        {
            return resultList;
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            bool appears = false;
            
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == i)
                {
                    appears = true;
                    break;
                }
            }
            
            if (appears == false)
            {
                resultList.Add(i);
            }
        }
        
        return resultList;
    }
}