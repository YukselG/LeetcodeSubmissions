public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int results = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum = sum + accounts[i][j];
                if (sum >= results)
                {
                    results = sum;
                }
            }
        }
        return results;
    }
}