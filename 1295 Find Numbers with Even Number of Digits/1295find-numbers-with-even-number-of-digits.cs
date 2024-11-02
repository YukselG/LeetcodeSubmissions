public class Solution {
    public int FindNumbers(int[] nums) {
        int evenNumberOfDigits = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            int length = nums[i].ToString().Length;
            if (length % 2 == 0)
            {
                evenNumberOfDigits = evenNumberOfDigits + 1;
            }
        }
        return evenNumberOfDigits;
    }
}