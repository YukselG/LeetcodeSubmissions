public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] numsSquared = new int[nums.Length];
        
        for (int i = 0; i < nums.Length; i++)
        {
            numsSquared[i] = nums[i] * nums[i];
        }

        /*
        //Own sorting algorithm (bubble sort for now, still a noob)
        for (int i = 0; i < numsSquared.Length-1; i++)
        {
            // we can minus with i because the i last elements has been sorted, so we dont need to check for them.
            for (int j = 0; j < numsSquared.Length -i - 1; j++)
            {
                if (numsSquared[j] >= numsSquared[j+1])
                {
                    // simple swapping
                    int temp = numsSquared[j+1];
                    numsSquared[j+1] = numsSquared[j];
                    numsSquared[j] = temp;
                }
            }
        }
        */

        Array.Sort(numsSquared);
        
        return numsSquared;
    }
}