public class Solution {
    public int NumberOfSteps(int num) {
        int numberOfSteps = 0;
        while(num > 0)
        {
            if (num % 2 == 0)
            {
                num = num / 2;
                numberOfSteps++;
            }
            else
            {
                num = num - 1; 
                numberOfSteps++;
            }
        }
        return numberOfSteps;
    }
}