public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] result = new int[2];
        int sum = 0;
        int j = numbers.Length-1;
        
        for (int i = 0; i < j; i++)
        {
            sum = numbers[i] + numbers[j];
            Console.WriteLine(sum);
            if (sum == target)
            {
                result[0] = i+1;
                result[1] = j+1;
            } else if (sum > target)
            {
                j--;
                i--;
            }
        }
        return result;
    }
}