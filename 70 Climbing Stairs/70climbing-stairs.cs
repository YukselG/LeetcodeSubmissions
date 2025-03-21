public class Solution {
    // memoization: dictionary to keep track of steps that gets calculated, so we dont do duplicate calculations
    public Dictionary<int,int> steps = new Dictionary<int,int>();
    
    public int ClimbStairs(int n) {
         // base case:
        if (n == 0 || n == 1)
        {
            return 1;
        }
        
        bool keyExists = steps.TryGetValue(n, out int val);
        if (keyExists)
        {
            return val;
        } else {
            // calculcate the ways to reach the last step and store it
            int lastStep = ClimbStairs(n-1) + ClimbStairs(n-2);
            steps[n] = lastStep;
            return lastStep;
        }

    }
}