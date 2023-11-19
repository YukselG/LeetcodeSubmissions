public class Solution {
    public int[] RunningSum(int[] nums) {
        // the length of the runningSum array will be the same as the length of the input nums array
        int[] runningSum = new int[nums.Length];

        // the value of the first element in the runningSum will be the same as the first element of the input nums array;
        runningSum[0] = nums[0];

        // so we can start the for loop at index 1, and then add the given index' value of nums and the previous index' value of nums to the given index of the running sum
        for (int i = 1; i < nums.Length; i++)
        {
            runningSum[i] = runningSum[i-1] + nums[i];
        }

        return runningSum;
    }
}